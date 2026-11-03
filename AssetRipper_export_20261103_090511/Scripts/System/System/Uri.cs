using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[TypeConverter(typeof(UriTypeConverter))]
public class Uri : ISerializable
{
	[Flags]
	private enum Flags : ulong
	{
		Zero = 0uL,
		SchemeNotCanonical = 1uL,
		UserNotCanonical = 2uL,
		HostNotCanonical = 4uL,
		PortNotCanonical = 8uL,
		PathNotCanonical = 0x10uL,
		QueryNotCanonical = 0x20uL,
		FragmentNotCanonical = 0x40uL,
		CannotDisplayCanonical = SchemeNotCanonical | UserNotCanonical | HostNotCanonical | PortNotCanonical | PathNotCanonical | QueryNotCanonical | FragmentNotCanonical,
		E_UserNotCanonical = 0x80uL,
		E_HostNotCanonical = 0x100uL,
		E_PortNotCanonical = 0x200uL,
		E_PathNotCanonical = 0x400uL,
		E_QueryNotCanonical = 0x800uL,
		E_FragmentNotCanonical = 0x1000uL,
		E_CannotDisplayCanonical = E_UserNotCanonical | E_HostNotCanonical | E_PortNotCanonical | E_PathNotCanonical | E_QueryNotCanonical | E_FragmentNotCanonical,
		ShouldBeCompressed = 0x2000uL,
		FirstSlashAbsent = 0x4000uL,
		BackslashInPath = 0x8000uL,
		IndexMask = CannotDisplayCanonical | E_CannotDisplayCanonical | ShouldBeCompressed | FirstSlashAbsent | BackslashInPath,
		HostTypeMask = 0x70000uL,
		HostNotParsed = 0uL,
		IPv6HostType = 0x10000uL,
		IPv4HostType = 0x20000uL,
		DnsHostType = 0x30000uL,
		UncHostType = 0x40000uL,
		BasicHostType = 0x50000uL,
		UnusedHostType = 0x60000uL,
		UnknownHostType = HostTypeMask,
		UserEscaped = 0x80000uL,
		AuthorityFound = 0x100000uL,
		HasUserInfo = 0x200000uL,
		LoopbackHost = 0x400000uL,
		NotDefaultPort = 0x800000uL,
		UserDrivenParsing = 0x1000000uL,
		CanonicalDnsHost = 0x2000000uL,
		ErrorOrParsingRecursion = 0x4000000uL,
		DosPath = 0x8000000uL,
		UncPath = 0x10000000uL,
		ImplicitFile = 0x20000000uL,
		MinimalUriInfoSet = 0x40000000uL,
		AllUriInfoSet = 0x80000000uL,
		IdnHost = 0x100000000uL,
		HasUnicode = 0x200000000uL,
		HostUnicodeNormalized = 0x400000000uL,
		RestUnicodeNormalized = 0x800000000uL,
		UnicodeHost = 0x1000000000uL,
		IntranetUri = 0x2000000000uL,
		UseOrigUncdStrOffset = 0x4000000000uL,
		UserIriCanonical = 0x8000000000uL,
		PathIriCanonical = 0x10000000000uL,
		QueryIriCanonical = 0x20000000000uL,
		FragmentIriCanonical = 0x40000000000uL,
		IriCanonical = UserIriCanonical | PathIriCanonical | QueryIriCanonical | FragmentIriCanonical,
		CompressedSlashes = 0x100000000000uL
	}

	private class UriInfo
	{
		public string Host;

		public string ScopeId;

		public string String;

		public Offset Offset;

		public string DnsSafeHost;

		public MoreInfo MoreInfo;
	}

	[StructLayout((LayoutKind)0, Pack = 1, Size = 16)]
	private struct Offset
	{
		public ushort Scheme;

		public ushort User;

		public ushort Host;

		public ushort PortValue;

		public ushort Path;

		public ushort Query;

		public ushort Fragment;

		public ushort End;
	}

	private class MoreInfo
	{
		public string Path;

		public string Fragment;

		public string AbsoluteUri;

		public int Hash;

		public string RemoteUrl;
	}

	[Flags]
	private enum Check
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 0x80,
		BackslashInPath = 0x10,
		ReservedFound = 0x20,
		NotIriCanonical = 0x40,
		FoundNonAscii = 8
	}

	public static readonly string UriSchemeFile;

	public static readonly string UriSchemeFtp;

	public static readonly string UriSchemeGopher;

	public static readonly string UriSchemeHttp;

	public static readonly string UriSchemeHttps;

	internal static readonly string UriSchemeWs;

	internal static readonly string UriSchemeWss;

	public static readonly string UriSchemeMailto;

	public static readonly string UriSchemeNews;

	public static readonly string UriSchemeNntp;

	public static readonly string UriSchemeNetTcp;

	public static readonly string UriSchemeNetPipe;

	public static readonly string SchemeDelimiter;

	private string m_String;

	private string m_originalUnicodeString;

	private UriParser m_Syntax;

	private string m_DnsSafeHost;

	private Flags m_Flags;

	private UriInfo m_Info;

	private bool m_iriParsing;

	private static bool s_ConfigInitialized;

	private static bool s_ConfigInitializing;

	private static UriIdnScope s_IdnScope;

	private static bool s_IriParsing;

	private static bool useDotNetRelativeOrAbsolute;

	internal static readonly bool IsWindowsFileSystem;

	private static object s_initLock;

	internal static readonly char[] HexLowerChars;

	private static readonly char[] _WSchars;

	private bool IsImplicitFile => false;

	private bool IsUncOrDosPath => false;

	private bool IsDosPath => false;

	private bool IsUncPath => false;

	private Flags HostType => Flags.Zero;

	private UriParser Syntax => null;

	private bool IsNotAbsoluteUri => false;

	private bool AllowIdn => false;

	internal bool UserDrivenParsing => false;

	private ushort SecuredPathIndex => 0;

	public string AbsolutePath => null;

	private string PrivateAbsolutePath => null;

	public string AbsoluteUri => null;

	public bool IsFile => false;

	public bool IsLoopback => false;

	public string PathAndQuery => null;

	public bool IsUnc => false;

	private static object InitializeLock => null;

	public int Port => 0;

	public string Fragment => null;

	public string Scheme => null;

	private bool OriginalStringSwitched => false;

	public string OriginalString => null;

	public string DnsSafeHost => null;

	public bool IsAbsoluteUri => false;

	public bool UserEscaped => false;

	internal static bool IriParsingStatic(UriParser syntax)
	{
		return false;
	}

	private bool AllowIdnStatic(UriParser syntax, Flags flags)
	{
		return false;
	}

	private bool IsIntranet(string schemeHost)
	{
		return false;
	}

	private void SetUserDrivenParsing()
	{
	}

	private bool NotAny(Flags flags)
	{
		return false;
	}

	private bool InFact(Flags flags)
	{
		return false;
	}

	private static bool StaticNotAny(Flags allFlags, Flags checkFlags)
	{
		return false;
	}

	private static bool StaticInFact(Flags allFlags, Flags checkFlags)
	{
		return false;
	}

	private UriInfo EnsureUriInfo()
	{
		return null;
	}

	private void EnsureParseRemaining()
	{
	}

	private void EnsureHostString(bool allowDnsOptimization)
	{
	}

	public Uri(string uriString)
	{
	}

	public Uri(string uriString, UriKind uriKind)
	{
	}

	public Uri(Uri baseUri, string relativeUri)
	{
	}

	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
	{
	}

	public Uri(Uri baseUri, Uri relativeUri)
	{
	}

	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
	{
		return ParsingError.None;
	}

	private static UriFormatException GetException(ParsingError err)
	{
		return null;
	}

	protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private static bool StaticIsFile(UriParser syntax)
	{
		return false;
	}

	private static void InitializeUriConfig()
	{
	}

	internal static bool IsGenDelim(char ch)
	{
		return false;
	}

	public static bool IsHexDigit(char character)
	{
		return false;
	}

	public static int FromHex(char digit)
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static bool operator ==(Uri uri1, Uri uri2)
	{
		return false;
	}

	public static bool operator !=(Uri uri1, Uri uri2)
	{
		return false;
	}

	public override bool Equals(object comparand)
	{
		return false;
	}

	private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax)
	{
		return ParsingError.None;
	}

	internal UriFormatException ParseMinimal()
	{
		return null;
	}

	private ParsingError PrivateParseMinimal()
	{
		return ParsingError.None;
	}

	private void PrivateParseMinimalIri(string newHost, ushort idx)
	{
	}

	private void CreateUriInfo(Flags cF)
	{
	}

	private void CreateHostString()
	{
	}

	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId)
	{
		return null;
	}

	private void GetHostViaCustomSyntax()
	{
	}

	internal string GetParts(UriComponents uriParts, UriFormat formatAs)
	{
		return null;
	}

	private string GetEscapedParts(UriComponents uriParts)
	{
		return null;
	}

	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
	{
		return null;
	}

	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
	{
		return null;
	}

	private string GetUriPartsFromUserString(UriComponents uriParts)
	{
		return null;
	}

	private void ParseRemaining()
	{
	}

	private unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax)
	{
		return 0;
	}

	private unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
	{
		return false;
	}

	private unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
	{
		return ParsingError.None;
	}

	private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost)
	{
		return 0;
	}

	private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
	{
	}

	private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err)
	{
	}

	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
	{
	}

	private unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
	{
	}

	private unsafe Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
	{
		return Check.None;
	}

	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs)
	{
		return null;
	}

	private unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
	{
	}

	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax)
	{
		return null;
	}

	internal static int CalculateCaseInsensitiveHashCode(string text)
	{
		return 0;
	}

	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
	{
		return null;
	}

	private static bool IsLWS(char ch)
	{
		return false;
	}

	private static bool IsAsciiLetter(char character)
	{
		return false;
	}

	internal static bool IsAsciiLetterOrDigit(char character)
	{
		return false;
	}

	internal static bool IsBidiControlCharacter(char ch)
	{
		return false;
	}

	internal unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
	{
		return null;
	}

	private void CreateThis(string uri, bool dontEscape, UriKind uriKind)
	{
	}

	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
	{
		e = null;
	}

	private bool CheckForConfigLoad(string data)
	{
		return false;
	}

	private bool CheckForUnicode(string data)
	{
		return false;
	}

	private bool CheckForEscapedUnreserved(string data)
	{
		return false;
	}

	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
	{
		result = null;
		return false;
	}

	public string GetComponents(UriComponents components, UriFormat format)
	{
		return null;
	}

	public static string UnescapeDataString(string stringToUnescape)
	{
		return null;
	}

	public static string EscapeDataString(string stringToEscape)
	{
		return null;
	}

	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
	{
		return null;
	}

	private Uri(Flags flags, UriParser uriParser, string uri)
	{
	}

	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
	{
		return null;
	}

	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
	{
		e = null;
		return null;
	}

	private string GetRelativeSerializationString(UriFormat format)
	{
		return null;
	}

	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
	{
		return null;
	}

	private void CreateThisFromUri(Uri otherUri)
	{
	}
}

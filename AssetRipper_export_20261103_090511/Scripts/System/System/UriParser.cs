using System.Collections.Generic;

namespace System;

public abstract class UriParser
{
	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3
	}

	private class BuiltInUriParser : UriParser
	{
		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
			: base(UriSyntaxFlags.None)
		{
		}
	}

	private static readonly Dictionary<string, UriParser> m_Table;

	private static Dictionary<string, UriParser> m_TempTable;

	private UriSyntaxFlags m_Flags;

	private UriSyntaxFlags m_UpdatableFlags;

	private bool m_UpdatableFlagsUsed;

	private int m_Port;

	private string m_Scheme;

	internal static UriParser HttpUri;

	internal static UriParser HttpsUri;

	internal static UriParser WsUri;

	internal static UriParser WssUri;

	internal static UriParser FtpUri;

	internal static UriParser FileUri;

	internal static UriParser GopherUri;

	internal static UriParser NntpUri;

	internal static UriParser NewsUri;

	internal static UriParser MailToUri;

	internal static UriParser UuidUri;

	internal static UriParser TelnetUri;

	internal static UriParser LdapUri;

	internal static UriParser NetTcpUri;

	internal static UriParser NetPipeUri;

	internal static UriParser VsMacrosUri;

	private static readonly UriQuirksVersion s_QuirksVersion;

	private static readonly UriSyntaxFlags HttpSyntaxFlags;

	private static readonly UriSyntaxFlags FileSyntaxFlags;

	internal string SchemeName => null;

	internal int DefaultPort => 0;

	internal static bool ShouldUseLegacyV2Quirks => false;

	internal UriSyntaxFlags Flags => UriSyntaxFlags.None;

	internal bool IsSimple => false;

	protected virtual UriParser OnNewUri()
	{
		return null;
	}

	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
	{
		parsingError = null;
	}

	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
	{
		parsingError = null;
		return null;
	}

	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
	{
		return null;
	}

	static UriParser()
	{
	}

	internal bool NotAny(UriSyntaxFlags flags)
	{
		return false;
	}

	internal bool InFact(UriSyntaxFlags flags)
	{
		return false;
	}

	internal bool IsAllSet(UriSyntaxFlags flags)
	{
		return false;
	}

	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
	{
		return false;
	}

	internal UriParser(UriSyntaxFlags flags)
	{
	}

	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
	{
		return null;
	}

	internal UriParser InternalOnNewUri()
	{
		return null;
	}

	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError)
	{
		parsingError = null;
	}

	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
	{
		parsingError = null;
		return null;
	}

	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
	{
		return null;
	}
}

using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
[ComVisible(true)]
public abstract class Encoding : ICloneable
{
	[Serializable]
	internal class DefaultEncoder : Encoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding;

		[NonSerialized]
		private bool m_hasInitializedEncoding;

		[NonSerialized]
		internal char charLeftOver;

		public DefaultEncoder(Encoding encoding)
		{
		}

		internal DefaultEncoder(SerializationInfo info, StreamingContext context)
		{
		}

		public object GetRealObject(StreamingContext context)
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return 0;
		}

		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			return 0;
		}

		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return 0;
		}

		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			return 0;
		}
	}

	[Serializable]
	internal class DefaultDecoder : Decoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding;

		[NonSerialized]
		private bool m_hasInitializedEncoding;

		public DefaultDecoder(Encoding encoding)
		{
		}

		internal DefaultDecoder(SerializationInfo info, StreamingContext context)
		{
		}

		public object GetRealObject(StreamingContext context)
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return 0;
		}

		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			return 0;
		}

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return 0;
		}

		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			return 0;
		}
	}

	internal class EncodingCharBuffer
	{
		private unsafe char* chars;

		private unsafe char* charStart;

		private unsafe char* charEnd;

		private int charCountResult;

		private Encoding enc;

		private DecoderNLS decoder;

		private unsafe byte* byteStart;

		private unsafe byte* byteEnd;

		private unsafe byte* bytes;

		private DecoderFallbackBuffer fallbackBuffer;

		internal bool MoreData => false;

		internal int BytesUsed => 0;

		internal int Count => 0;

		internal unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
		{
		}

		internal bool AddChar(char ch, int numBytes)
		{
			return false;
		}

		internal bool AddChar(char ch)
		{
			return false;
		}

		internal void AdjustBytes(int count)
		{
		}

		internal byte GetNextByte()
		{
			return 0;
		}

		internal bool Fallback(byte fallbackByte)
		{
			return false;
		}

		internal bool Fallback(byte[] byteBuffer)
		{
			return false;
		}
	}

	internal class EncodingByteBuffer
	{
		private unsafe byte* bytes;

		private unsafe byte* byteStart;

		private unsafe byte* byteEnd;

		private unsafe char* chars;

		private unsafe char* charStart;

		private unsafe char* charEnd;

		private int byteCountResult;

		private Encoding enc;

		private EncoderNLS encoder;

		internal EncoderFallbackBuffer fallbackBuffer;

		internal bool MoreData => false;

		internal int CharsUsed => 0;

		internal int Count => 0;

		internal unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
		{
		}

		internal bool AddByte(byte b, int moreBytesExpected)
		{
			return false;
		}

		internal bool AddByte(byte b1)
		{
			return false;
		}

		internal bool AddByte(byte b1, byte b2)
		{
			return false;
		}

		internal bool AddByte(byte b1, byte b2, int moreBytesExpected)
		{
			return false;
		}

		internal void MovePrevious(bool bThrow)
		{
		}

		internal char GetNextChar()
		{
			return '\0';
		}
	}

	private static Encoding defaultEncoding;

	private static Encoding unicodeEncoding;

	private static Encoding bigEndianUnicode;

	private static Encoding utf7Encoding;

	private static Encoding utf8Encoding;

	private static Encoding utf32Encoding;

	private static Encoding asciiEncoding;

	private static Encoding latin1Encoding;

	private static Dictionary<int, Encoding> encodings;

	private const int MIMECONTF_MAILNEWS = 1;

	private const int MIMECONTF_BROWSER = 2;

	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;

	private const int MIMECONTF_SAVABLE_BROWSER = 512;

	private const int CodePageDefault = 0;

	private const int CodePageNoOEM = 1;

	private const int CodePageNoMac = 2;

	private const int CodePageNoThread = 3;

	private const int CodePageNoSymbol = 42;

	private const int CodePageUnicode = 1200;

	private const int CodePageBigEndian = 1201;

	private const int CodePageWindows1252 = 1252;

	private const int CodePageMacGB2312 = 10008;

	private const int CodePageGB2312 = 20936;

	private const int CodePageMacKorean = 10003;

	private const int CodePageDLLKorean = 20949;

	private const int ISO2022JP = 50220;

	private const int ISO2022JPESC = 50221;

	private const int ISO2022JPSISO = 50222;

	private const int ISOKorean = 50225;

	private const int ISOSimplifiedCN = 50227;

	private const int EUCJP = 51932;

	private const int ChineseHZ = 52936;

	private const int DuplicateEUCCN = 51936;

	private const int EUCCN = 936;

	private const int EUCKR = 51949;

	internal const int CodePageASCII = 20127;

	internal const int ISO_8859_1 = 28591;

	private const int ISCIIAssemese = 57006;

	private const int ISCIIBengali = 57003;

	private const int ISCIIDevanagari = 57002;

	private const int ISCIIGujarathi = 57010;

	private const int ISCIIKannada = 57008;

	private const int ISCIIMalayalam = 57009;

	private const int ISCIIOriya = 57007;

	private const int ISCIIPanjabi = 57011;

	private const int ISCIITamil = 57004;

	private const int ISCIITelugu = 57005;

	private const int GB18030 = 54936;

	private const int ISO_8859_8I = 38598;

	private const int ISO_8859_8_Visual = 28598;

	private const int ENC50229 = 50229;

	private const int CodePageUTF7 = 65000;

	private const int CodePageUTF8 = 65001;

	private const int CodePageUTF32 = 12000;

	private const int CodePageUTF32BE = 12001;

	internal int m_codePage;

	internal CodePageDataItem dataItem;

	[NonSerialized]
	internal bool m_deserializedFromEverett;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback;

	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject => null;

	public virtual ReadOnlySpan<byte> Preamble => default;

	public virtual string EncodingName => null;

	public virtual string HeaderName => null;

	public virtual string WebName => null;

	[ComVisible(false)]
	public EncoderFallback EncoderFallback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[ComVisible(false)]
	public DecoderFallback DecoderFallback
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[ComVisible(false)]
	public bool IsReadOnly => false;

	public static Encoding ASCII => null;

	private static Encoding Latin1 => null;

	public virtual int CodePage => 0;

	public static Encoding Default => null;

	public static Encoding Unicode => null;

	public static Encoding BigEndianUnicode => null;

	public static Encoding UTF7 => null;

	public static Encoding UTF8 => null;

	public static Encoding UTF32 => null;

	protected Encoding()
	{
	}

	protected Encoding(int codePage)
	{
	}

	internal virtual void SetDefaultFallbacks()
	{
	}

	internal void OnDeserializing()
	{
	}

	internal void OnDeserialized()
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context)
	{
	}

	internal void SerializeEncoding(SerializationInfo info, StreamingContext context)
	{
	}

	public static Encoding GetEncoding(int codepage)
	{
		return null;
	}

	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
	{
		return null;
	}

	public static Encoding GetEncoding(string name)
	{
		return null;
	}

	public virtual byte[] GetPreamble()
	{
		return null;
	}

	private void GetDataItem()
	{
	}

	[ComVisible(false)]
	public virtual object Clone()
	{
		return null;
	}

	public virtual int GetByteCount(string s)
	{
		return 0;
	}

	public abstract int GetByteCount(char[] chars, int index, int count);

	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetByteCount(char* chars, int count)
	{
		return 0;
	}

	internal unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
	{
		return 0;
	}

	public virtual byte[] GetBytes(char[] chars, int index, int count)
	{
		return null;
	}

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	public virtual byte[] GetBytes(string s)
	{
		return null;
	}

	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	internal unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		return 0;
	}

	[ComVisible(false)]
	[CLSCompliant(false)]
	public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
	{
		return 0;
	}

	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetCharCount(byte* bytes, int count)
	{
		return 0;
	}

	internal unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
	{
		return 0;
	}

	public virtual char[] GetChars(byte[] bytes, int index, int count)
	{
		return null;
	}

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
	{
		return 0;
	}

	internal unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
	{
		return 0;
	}

	[CLSCompliant(false)]
	[ComVisible(false)]
	public unsafe string GetString(byte* bytes, int byteCount)
	{
		return null;
	}

	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars)
	{
		return 0;
	}

	public string GetString(ReadOnlySpan<byte> bytes)
	{
		return null;
	}

	public virtual Decoder GetDecoder()
	{
		return null;
	}

	private static Encoding CreateDefaultEncoding()
	{
		return null;
	}

	internal void setReadOnly(bool value = true)
	{
	}

	public virtual Encoder GetEncoder()
	{
		return null;
	}

	public abstract int GetMaxByteCount(int charCount);

	public abstract int GetMaxCharCount(int byteCount);

	public virtual string GetString(byte[] bytes)
	{
		return null;
	}

	public virtual string GetString(byte[] bytes, int index, int count)
	{
		return null;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal virtual char[] GetBestFitUnicodeToBytesData()
	{
		return null;
	}

	internal virtual char[] GetBestFitBytesToUnicodeData()
	{
		return null;
	}

	internal void ThrowBytesOverflow()
	{
	}

	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
	{
	}

	internal void ThrowCharsOverflow()
	{
	}

	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
	{
	}

	public virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes)
	{
		return 0;
	}
}

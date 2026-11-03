namespace System.Security.Cryptography.X509Certificates;

public sealed class X509SubjectKeyIdentifierExtension : X509Extension
{
	internal const string oid = "2.5.29.14";

	internal const string friendlyName = "Subject Key Identifier";

	private byte[] _subjectKeyIdentifier;

	private string _ski;

	private AsnDecodeStatus _status;

	public string SubjectKeyIdentifier => null;

	public X509SubjectKeyIdentifierExtension()
	{
	}

	public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
	{
	}

	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
	{
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal static byte FromHexChar(char c)
	{
		return 0;
	}

	internal static byte FromHexChars(char c1, char c2)
	{
		return 0;
	}

	internal static byte[] FromHex(string hex)
	{
		return null;
	}

	internal AsnDecodeStatus Decode(byte[] extension)
	{
		return AsnDecodeStatus.Ok;
	}

	internal byte[] Encode()
	{
		return null;
	}

	internal override string ToString(bool multiLine)
	{
		return null;
	}
}

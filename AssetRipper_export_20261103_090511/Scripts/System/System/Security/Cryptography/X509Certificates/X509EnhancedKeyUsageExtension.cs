namespace System.Security.Cryptography.X509Certificates;

public sealed class X509EnhancedKeyUsageExtension : X509Extension
{
	private OidCollection _enhKeyUsage;

	private AsnDecodeStatus _status;

	public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
	{
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal AsnDecodeStatus Decode(byte[] extension)
	{
		return AsnDecodeStatus.Ok;
	}

	internal override string ToString(bool multiLine)
	{
		return null;
	}
}

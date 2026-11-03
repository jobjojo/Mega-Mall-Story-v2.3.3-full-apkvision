namespace System.Security.Cryptography.X509Certificates;

public sealed class X509KeyUsageExtension : X509Extension
{
	internal const string oid = "2.5.29.15";

	internal const string friendlyName = "Key Usage";

	internal const X509KeyUsageFlags all = X509KeyUsageFlags.EncipherOnly | X509KeyUsageFlags.CrlSign | X509KeyUsageFlags.KeyCertSign | X509KeyUsageFlags.KeyAgreement | X509KeyUsageFlags.DataEncipherment | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.DecipherOnly;

	private X509KeyUsageFlags _keyUsages;

	private AsnDecodeStatus _status;

	public X509KeyUsageFlags KeyUsages => X509KeyUsageFlags.None;

	public X509KeyUsageExtension()
	{
	}

	public X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
	{
	}

	public X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
	{
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
	{
		return X509KeyUsageFlags.None;
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

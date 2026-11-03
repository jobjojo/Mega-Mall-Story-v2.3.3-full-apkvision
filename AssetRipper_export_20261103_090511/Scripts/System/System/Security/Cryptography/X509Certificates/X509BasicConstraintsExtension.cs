namespace System.Security.Cryptography.X509Certificates;

public sealed class X509BasicConstraintsExtension : X509Extension
{
	internal const string oid = "2.5.29.19";

	internal const string friendlyName = "Basic Constraints";

	private bool _certificateAuthority;

	private bool _hasPathLengthConstraint;

	private int _pathLengthConstraint;

	private AsnDecodeStatus _status;

	public bool CertificateAuthority => false;

	public bool HasPathLengthConstraint => false;

	public int PathLengthConstraint => 0;

	public X509BasicConstraintsExtension()
	{
	}

	public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
	{
	}

	public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
	{
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
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

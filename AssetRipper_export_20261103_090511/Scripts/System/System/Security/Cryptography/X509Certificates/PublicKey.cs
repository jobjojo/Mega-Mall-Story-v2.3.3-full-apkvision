namespace System.Security.Cryptography.X509Certificates;

public sealed class PublicKey
{
	private AsnEncodedData _keyValue;

	private AsnEncodedData _params;

	private Oid _oid;

	private static byte[] Empty;

	public AsnEncodedData EncodedKeyValue => null;

	public AsnEncodedData EncodedParameters => null;

	public Oid Oid => null;
}

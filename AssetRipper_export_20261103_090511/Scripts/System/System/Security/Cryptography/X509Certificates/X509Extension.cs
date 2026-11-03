namespace System.Security.Cryptography.X509Certificates;

public class X509Extension : AsnEncodedData
{
	private bool _critical;

	public bool Critical
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected X509Extension()
	{
	}

	public override void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal string FormatUnkownData(byte[] data)
	{
		return null;
	}
}

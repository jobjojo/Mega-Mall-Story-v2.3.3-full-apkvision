namespace System.Security.Cryptography;

public class AsnEncodedData
{
	internal Oid _oid;

	internal byte[] _raw;

	public Oid Oid
	{
		set
		{
		}
	}

	public byte[] RawData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected AsnEncodedData()
	{
	}

	public virtual void CopyFrom(AsnEncodedData asnEncodedData)
	{
	}

	internal virtual string ToString(bool multiLine)
	{
		return null;
	}

	internal string Default(bool multiLine)
	{
		return null;
	}

	internal string BasicConstraintsExtension(bool multiLine)
	{
		return null;
	}

	internal string EnhancedKeyUsageExtension(bool multiLine)
	{
		return null;
	}

	internal string KeyUsageExtension(bool multiLine)
	{
		return null;
	}

	internal string SubjectKeyIdentifierExtension(bool multiLine)
	{
		return null;
	}

	internal string SubjectAltName(bool multiLine)
	{
		return null;
	}

	internal string NetscapeCertType(bool multiLine)
	{
		return null;
	}
}

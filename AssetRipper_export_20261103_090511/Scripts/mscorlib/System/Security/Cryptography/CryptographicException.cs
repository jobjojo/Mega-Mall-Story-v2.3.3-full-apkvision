using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography;

[Serializable]
[ComVisible(true)]
public class CryptographicException : SystemException
{
	public CryptographicException()
	{
	}

	public CryptographicException(string message)
	{
	}

	protected CryptographicException(SerializationInfo info, StreamingContext context)
	{
	}
}

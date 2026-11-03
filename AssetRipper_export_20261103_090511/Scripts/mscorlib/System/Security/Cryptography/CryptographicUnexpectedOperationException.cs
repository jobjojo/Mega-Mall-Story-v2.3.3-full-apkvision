using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Cryptography;

[Serializable]
[ComVisible(true)]
public class CryptographicUnexpectedOperationException : CryptographicException
{
	public CryptographicUnexpectedOperationException()
	{
	}

	public CryptographicUnexpectedOperationException(string message)
	{
	}

	protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context)
	{
	}
}

using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
public class MarshalDirectiveException : SystemException
{
	public MarshalDirectiveException()
	{
	}

	public MarshalDirectiveException(string message)
	{
	}

	protected MarshalDirectiveException(SerializationInfo info, StreamingContext context)
	{
	}
}

using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
public class ExternalException : SystemException
{
	public ExternalException()
	{
	}

	public ExternalException(string message)
	{
	}

	protected ExternalException(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

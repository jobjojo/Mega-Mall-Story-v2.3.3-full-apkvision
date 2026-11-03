using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
public class COMException : ExternalException
{
	public COMException()
	{
	}

	protected COMException(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

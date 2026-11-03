using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
public class CustomAttributeFormatException : FormatException
{
	public CustomAttributeFormatException()
	{
	}

	public CustomAttributeFormatException(string message)
	{
	}

	public CustomAttributeFormatException(string message, Exception inner)
	{
	}

	protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context)
	{
	}
}

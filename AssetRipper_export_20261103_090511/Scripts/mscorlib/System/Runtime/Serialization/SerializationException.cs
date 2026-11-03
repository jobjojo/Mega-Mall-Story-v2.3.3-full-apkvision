namespace System.Runtime.Serialization;

[Serializable]
public class SerializationException : SystemException
{
	private static string s_nullMessage;

	public SerializationException()
	{
	}

	public SerializationException(string message)
	{
	}

	public SerializationException(string message, Exception innerException)
	{
	}

	protected SerializationException(SerializationInfo info, StreamingContext context)
	{
	}
}

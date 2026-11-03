using System.Runtime.Serialization;

namespace System.Text.RegularExpressions;

[Serializable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable
{
	public string Input { get; }

	public string Pattern { get; }

	public TimeSpan MatchTimeout { get; }

	public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
	{
	}

	public RegexMatchTimeoutException()
	{
	}

	protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}

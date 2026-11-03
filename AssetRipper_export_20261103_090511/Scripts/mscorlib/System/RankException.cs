using System.Runtime.Serialization;

namespace System;

[Serializable]
public class RankException : SystemException
{
	public RankException()
	{
	}

	public RankException(string message)
	{
	}

	protected RankException(SerializationInfo info, StreamingContext context)
	{
	}
}

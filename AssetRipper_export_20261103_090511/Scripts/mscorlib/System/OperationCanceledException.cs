using System.Runtime.Serialization;
using System.Threading;

namespace System;

[Serializable]
public class OperationCanceledException : SystemException
{
	[NonSerialized]
	private CancellationToken _cancellationToken;

	public CancellationToken CancellationToken
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public OperationCanceledException()
	{
	}

	public OperationCanceledException(string message)
	{
	}

	public OperationCanceledException(string message, CancellationToken token)
	{
	}

	protected OperationCanceledException(SerializationInfo info, StreamingContext context)
	{
	}
}

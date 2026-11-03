using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[DebuggerDisplay("Count = {InnerExceptionCount}")]
public class AggregateException : Exception
{
	private ReadOnlyCollection<Exception> m_innerExceptions;

	public override string Message => null;

	public AggregateException()
	{
	}

	public AggregateException(IEnumerable<Exception> innerExceptions)
	{
	}

	public AggregateException(params Exception[] innerExceptions)
	{
	}

	public AggregateException(string message, IEnumerable<Exception> innerExceptions)
	{
	}

	public AggregateException(string message, params Exception[] innerExceptions)
	{
	}

	private AggregateException(string message, IList<Exception> innerExceptions)
	{
	}

	internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
	{
	}

	internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
	{
	}

	private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
	{
	}

	protected AggregateException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

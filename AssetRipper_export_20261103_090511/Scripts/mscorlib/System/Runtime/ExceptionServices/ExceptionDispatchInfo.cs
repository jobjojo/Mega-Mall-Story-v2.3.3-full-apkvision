using System.Diagnostics;

namespace System.Runtime.ExceptionServices;

public sealed class ExceptionDispatchInfo
{
	private Exception m_Exception;

	private object m_stackTrace;

	internal object BinaryStackTraceArray => null;

	public Exception SourceException => null;

	private ExceptionDispatchInfo(Exception exception)
	{
	}

	public static ExceptionDispatchInfo Capture(Exception source)
	{
		return null;
	}

	[StackTraceHidden]
	public void Throw()
	{
	}

	internal ExceptionDispatchInfo()
	{
	}
}

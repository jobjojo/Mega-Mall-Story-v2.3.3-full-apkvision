namespace System;

[Serializable]
public class UnhandledExceptionEventArgs : EventArgs
{
	private object _exception;

	private bool _isTerminating;

	public object ExceptionObject => null;

	public bool IsTerminating => false;

	public UnhandledExceptionEventArgs(object exception, bool isTerminating)
	{
	}
}

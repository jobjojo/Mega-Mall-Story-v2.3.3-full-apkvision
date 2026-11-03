namespace System;

[Serializable]
public sealed class ConsoleCancelEventArgs : EventArgs
{
	private readonly ConsoleSpecialKey _type;

	public bool Cancel { get; }

	internal ConsoleCancelEventArgs(ConsoleSpecialKey type)
	{
	}

	internal ConsoleCancelEventArgs()
	{
	}
}

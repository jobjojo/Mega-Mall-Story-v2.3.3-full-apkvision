using System.Reflection;

namespace System;

public class ResolveEventArgs : EventArgs
{
	private readonly Assembly RequestingAssembly;

	public string Name { get; }

	public ResolveEventArgs(string name)
	{
	}

	public ResolveEventArgs(string name, Assembly requestingAssembly)
	{
	}
}

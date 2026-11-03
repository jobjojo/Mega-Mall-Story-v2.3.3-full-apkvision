using System.Reflection;

namespace System;

public class AssemblyLoadEventArgs : EventArgs
{
	private readonly Assembly LoadedAssembly;

	public AssemblyLoadEventArgs(Assembly loadedAssembly)
	{
	}
}

using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class TypeLoadException : SystemException, ISerializable
{
	private string ClassName;

	private string AssemblyName;

	private string MessageArg;

	internal int ResourceId;

	public override string Message => null;

	public TypeLoadException()
	{
	}

	public TypeLoadException(string message)
	{
	}

	private void SetMessageField()
	{
	}

	private TypeLoadException(string className, string assemblyName)
	{
	}

	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
	{
	}

	protected TypeLoadException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}

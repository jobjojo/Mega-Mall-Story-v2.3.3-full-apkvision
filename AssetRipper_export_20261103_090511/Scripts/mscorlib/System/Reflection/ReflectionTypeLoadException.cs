using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	private readonly Type[] Types;

	public Exception[] LoaderExceptions { get; }

	public override string Message => null;

	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions)
	{
	}

	private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private string CreateString(bool isMessage)
	{
		return null;
	}
}

using System.Runtime.Serialization;

namespace System.Reflection;

[CLSCompliant(false)]
public sealed class Pointer : ISerializable
{
	private unsafe readonly void* _ptr;

	private readonly Type _ptrType;

	private unsafe Pointer(void* ptr, Type ptrType)
	{
	}

	public unsafe static object Box(void* ptr, Type type)
	{
		return null;
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}

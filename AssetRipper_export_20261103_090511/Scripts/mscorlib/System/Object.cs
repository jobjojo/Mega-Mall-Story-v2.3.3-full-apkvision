using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class Object
{
	public virtual bool Equals(object obj)
	{
		return false;
	}

	public static bool Equals(object objA, object objB)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public Object()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	~Object()
	{
	}

	public virtual int GetHashCode()
	{
		return 0;
	}

	public Type GetType()
	{
		return null;
	}

	protected object MemberwiseClone()
	{
		return null;
	}

	public virtual string ToString()
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static bool ReferenceEquals(object objA, object objB)
	{
		return false;
	}

	internal static int InternalGetHashCode(object o)
	{
		return 0;
	}

	private void FieldGetter(string typeName, string fieldName, ref object val)
	{
	}

	private void FieldSetter(string typeName, string fieldName, object val)
	{
	}
}

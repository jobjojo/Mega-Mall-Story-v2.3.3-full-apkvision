using System.Reflection;

namespace System;

[Serializable]
[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
public abstract class Attribute
{
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
	{
		return null;
	}

	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
	{
		return null;
	}

	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
	{
		return false;
	}

	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
	{
		return false;
	}

	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
	{
		return null;
	}

	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
	{
		return null;
	}

	public static Attribute[] GetCustomAttributes(MemberInfo element)
	{
		return null;
	}

	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
	{
		return null;
	}

	public static bool IsDefined(MemberInfo element, Type attributeType)
	{
		return false;
	}

	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
	{
		return false;
	}

	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
	{
		return null;
	}

	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
	{
		return null;
	}

	public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
	{
		return null;
	}

	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	private static bool AreFieldValuesEqual(object thisValue, object thatValue)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

using System.Collections.Generic;

namespace System.Reflection;

public static class CustomAttributeExtensions
{
	public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
	{
		return null;
	}

	public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
	{
		return null;
	}

	public static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
	{
		return null;
	}

	public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
	{
		return null;
	}

	public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
	{
		return null;
	}

	public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
	{
		return null;
	}

	public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
	{
		return null;
	}

	public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
	{
		return null;
	}

	public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : Attribute
	{
		return null;
	}

	public static bool IsDefined(this MemberInfo element, Type attributeType)
	{
		return false;
	}
}

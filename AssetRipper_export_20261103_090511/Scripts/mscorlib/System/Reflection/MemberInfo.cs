namespace System.Reflection;

[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider
{
	public abstract MemberTypes MemberType { get; }

	public abstract string Name { get; }

	public abstract Type DeclaringType { get; }

	public abstract Type ReflectedType { get; }

	public virtual Module Module => null;

	public virtual int MetadataToken => 0;

	public abstract bool IsDefined(Type attributeType, bool inherit);

	public abstract object[] GetCustomAttributes(bool inherit);

	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(MemberInfo left, MemberInfo right)
	{
		return false;
	}

	public static bool operator !=(MemberInfo left, MemberInfo right)
	{
		return false;
	}
}

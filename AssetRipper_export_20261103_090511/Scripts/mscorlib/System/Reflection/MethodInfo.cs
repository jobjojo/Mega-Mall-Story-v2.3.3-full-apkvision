namespace System.Reflection;

[Serializable]
public abstract class MethodInfo : MethodBase
{
	public override MemberTypes MemberType => (MemberTypes)0;

	public virtual ParameterInfo ReturnParameter => null;

	public virtual Type ReturnType => null;

	internal virtual int GenericParameterCount => 0;

	public override Type[] GetGenericArguments()
	{
		return null;
	}

	public virtual MethodInfo GetGenericMethodDefinition()
	{
		return null;
	}

	public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
	{
		return null;
	}

	public virtual Delegate CreateDelegate(Type delegateType, object target)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(MethodInfo left, MethodInfo right)
	{
		return false;
	}

	public static bool operator !=(MethodInfo left, MethodInfo right)
	{
		return false;
	}
}

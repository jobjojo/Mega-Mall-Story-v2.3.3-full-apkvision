using System.Diagnostics;
using System.Globalization;

namespace System.Reflection;

[Serializable]
public abstract class MethodBase : MemberInfo
{
	public abstract MethodAttributes Attributes { get; }

	public virtual CallingConventions CallingConvention => (CallingConventions)0;

	public bool IsAbstract => false;

	public bool IsConstructor => false;

	public bool IsStatic => false;

	public bool IsVirtual => false;

	public bool IsPublic => false;

	public virtual bool IsGenericMethod => false;

	public virtual bool IsGenericMethodDefinition => false;

	public virtual bool ContainsGenericParameters => false;

	public abstract RuntimeMethodHandle MethodHandle { get; }

	public virtual bool IsSecurityCritical => false;

	public abstract ParameterInfo[] GetParameters();

	public abstract MethodImplAttributes GetMethodImplementationFlags();

	public virtual Type[] GetGenericArguments()
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public object Invoke(object obj, object[] parameters)
	{
		return null;
	}

	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(MethodBase left, MethodBase right)
	{
		return false;
	}

	public static bool operator !=(MethodBase left, MethodBase right)
	{
		return false;
	}

	internal virtual ParameterInfo[] GetParametersInternal()
	{
		return null;
	}

	internal virtual int GetParametersCount()
	{
		return 0;
	}

	internal virtual string FormatNameAndSig(bool serialization)
	{
		return null;
	}

	internal virtual Type[] GetParameterTypes()
	{
		return null;
	}

	internal virtual ParameterInfo[] GetParametersNoCopy()
	{
		return null;
	}

	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
	{
		return null;
	}

	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
	{
		return null;
	}
}

using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[StructLayout((LayoutKind)0)]
public abstract class Delegate : ICloneable, ISerializable
{
	private IntPtr method_ptr;

	private IntPtr invoke_impl;

	private object m_target;

	private IntPtr method;

	private IntPtr delegate_trampoline;

	private IntPtr extra_arg;

	private IntPtr method_code;

	private IntPtr interp_method;

	private IntPtr interp_invoke_impl;

	private MethodInfo method_info;

	private MethodInfo original_method_info;

	private DelegateData data;

	private bool method_is_virtual;

	public MethodInfo Method => null;

	public object Target => null;

	private MethodInfo GetVirtualMethod_internal()
	{
		return null;
	}

	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure)
	{
		return null;
	}

	private static bool arg_type_match(Type delArgType, Type argType)
	{
		return false;
	}

	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
	{
		return false;
	}

	private static bool return_type_match(Type delReturnType, Type returnType)
	{
		return false;
	}

	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, MethodInfo method)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, object target, string method)
	{
		return null;
	}

	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, Type target, string method)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
	{
		return null;
	}

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
	{
		return null;
	}

	public virtual object Clone()
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

	protected virtual MethodInfo GetMethodImpl()
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual Delegate[] GetInvocationList()
	{
		return null;
	}

	public static Delegate Combine(Delegate a, Delegate b)
	{
		return null;
	}

	[ComVisible(true)]
	public static Delegate Combine(params Delegate[] delegates)
	{
		return null;
	}

	protected virtual Delegate CombineImpl(Delegate d)
	{
		return null;
	}

	public static Delegate Remove(Delegate source, Delegate value)
	{
		return null;
	}

	protected virtual Delegate RemoveImpl(Delegate d)
	{
		return null;
	}

	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d)
	{
		return null;
	}
}

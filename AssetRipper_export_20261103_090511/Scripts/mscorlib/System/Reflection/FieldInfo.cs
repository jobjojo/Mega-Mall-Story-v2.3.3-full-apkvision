using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection;

[Serializable]
public abstract class FieldInfo : MemberInfo
{
	public override MemberTypes MemberType => (MemberTypes)0;

	public abstract FieldAttributes Attributes { get; }

	public abstract Type FieldType { get; }

	public bool IsInitOnly => false;

	public bool IsLiteral => false;

	public bool IsNotSerialized => false;

	public bool IsStatic => false;

	public bool IsPublic => false;

	public abstract RuntimeFieldHandle FieldHandle { get; }

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(FieldInfo left, FieldInfo right)
	{
		return false;
	}

	public static bool operator !=(FieldInfo left, FieldInfo right)
	{
		return false;
	}

	public abstract object GetValue(object obj);

	[DebuggerStepThrough]
	[DebuggerHidden]
	public void SetValue(object obj, object value)
	{
	}

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[CLSCompliant(false)]
	public virtual void SetValueDirect(TypedReference obj, object value)
	{
	}

	public virtual object GetRawConstantValue()
	{
		return null;
	}

	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle)
	{
		return null;
	}

	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
	{
		return null;
	}

	[ComVisible(false)]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
	{
		return null;
	}

	internal virtual int GetFieldOffset()
	{
		return 0;
	}

	private MarshalAsAttribute get_marshal_info()
	{
		return null;
	}

	internal object[] GetPseudoCustomAttributes()
	{
		return null;
	}

	internal CustomAttributeData[] GetPseudoCustomAttributesData()
	{
		return null;
	}
}

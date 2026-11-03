using System.Diagnostics;
using System.Globalization;

namespace System.Reflection;

[Serializable]
public abstract class ConstructorInfo : MethodBase
{
	public static readonly string ConstructorName;

	public static readonly string TypeConstructorName;

	public override MemberTypes MemberType => (MemberTypes)0;

	[DebuggerStepThrough]
	[DebuggerHidden]
	public object Invoke(object[] parameters)
	{
		return null;
	}

	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
	{
		return false;
	}

	public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
	{
		return false;
	}
}

using System.Globalization;

namespace System.Reflection.Emit;

public sealed class DynamicMethod : MethodInfo
{
	public override MethodAttributes Attributes => MethodAttributes.PrivateScope;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override RuntimeMethodHandle MethodHandle => default;

	public override Type ReflectedType => null;

	public override ParameterInfo[] GetParameters()
	{
		return null;
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return MethodImplAttributes.IL;
	}

	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}
}

using System.Globalization;

namespace System.Reflection.Emit;

public sealed class PropertyBuilder : PropertyInfo
{
	public override bool CanWrite => false;

	public override Type DeclaringType => null;

	public override string Name => null;

	public override Type PropertyType => null;

	public override Type ReflectedType => null;

	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public override MethodInfo GetGetMethod(bool nonPublic)
	{
		return null;
	}

	public override ParameterInfo[] GetIndexParameters()
	{
		return null;
	}

	public override MethodInfo GetSetMethod(bool nonPublic)
	{
		return null;
	}

	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
	}
}

using System.Globalization;

namespace System.Reflection.Emit;

public sealed class FieldBuilder : FieldInfo
{
	public override FieldAttributes Attributes => FieldAttributes.PrivateScope;

	public override Type DeclaringType => null;

	public override RuntimeFieldHandle FieldHandle => default;

	public override Type FieldType => null;

	public override string Name => null;

	public override Type ReflectedType => null;

	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public override object GetValue(object obj)
	{
		return null;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
	}
}

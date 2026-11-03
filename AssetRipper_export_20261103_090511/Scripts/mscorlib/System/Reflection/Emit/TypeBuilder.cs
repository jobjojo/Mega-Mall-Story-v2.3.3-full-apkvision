using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

public sealed class TypeBuilder : TypeInfo
{
	public const int UnspecifiedTypeSize = 0;

	public override Assembly Assembly => null;

	public override string AssemblyQualifiedName => null;

	public override Type BaseType => null;

	public override string FullName => null;

	public override Module Module => null;

	public override string Name => null;

	public override string Namespace => null;

	public override Type UnderlyingSystemType => null;

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return TypeAttributes.NotPublic;
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
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

	public override Type GetElementType()
	{
		return null;
	}

	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return null;
	}

	public override Type GetInterface(string name, bool ignoreCase)
	{
		return null;
	}

	public override Type[] GetInterfaces()
	{
		return null;
	}

	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return null;
	}

	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected override bool HasElementTypeImpl()
	{
		return false;
	}

	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		return null;
	}

	protected override bool IsArrayImpl()
	{
		return false;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}
}

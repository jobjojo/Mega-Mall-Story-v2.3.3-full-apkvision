using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

[Serializable]
public abstract class Type : MemberInfo
{
	private static Binder s_defaultBinder;

	public static readonly char Delimiter;

	public static readonly Type[] EmptyTypes;

	public static readonly object Missing;

	public static readonly MemberFilter FilterAttribute;

	public static readonly MemberFilter FilterName;

	public static readonly MemberFilter FilterNameIgnoreCase;

	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	internal RuntimeTypeHandle _impl;

	internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";

	public virtual bool IsSerializable => false;

	public virtual bool ContainsGenericParameters => false;

	public override MemberTypes MemberType => (MemberTypes)0;

	public abstract string Namespace { get; }

	public abstract string AssemblyQualifiedName { get; }

	public abstract string FullName { get; }

	public abstract Assembly Assembly { get; }

	public new abstract Module Module { get; }

	public bool IsNested => false;

	public override Type DeclaringType => null;

	public virtual MethodBase DeclaringMethod => null;

	public override Type ReflectedType => null;

	public abstract Type UnderlyingSystemType { get; }

	public bool IsArray => false;

	public bool IsByRef => false;

	public bool IsPointer => false;

	public virtual bool IsConstructedGenericType => false;

	public virtual bool IsGenericParameter => false;

	public virtual bool IsGenericMethodParameter => false;

	public virtual bool IsGenericType => false;

	public virtual bool IsGenericTypeDefinition => false;

	public virtual bool IsSZArray => false;

	public virtual bool IsVariableBoundArray => false;

	public bool HasElementType => false;

	public virtual Type[] GenericTypeArguments => null;

	public virtual int GenericParameterPosition => 0;

	public virtual GenericParameterAttributes GenericParameterAttributes => GenericParameterAttributes.None;

	public TypeAttributes Attributes => TypeAttributes.NotPublic;

	public bool IsAbstract => false;

	public bool IsSealed => false;

	public bool IsClass => false;

	public bool IsNestedAssembly => false;

	public bool IsNestedPublic => false;

	public bool IsNotPublic => false;

	public bool IsPublic => false;

	public bool IsExplicitLayout => false;

	public bool IsCOMObject => false;

	public bool IsContextful => false;

	public virtual bool IsEnum => false;

	public bool IsMarshalByRef => false;

	public bool IsPrimitive => false;

	public bool IsValueType => false;

	public virtual bool IsSignatureType => false;

	public virtual RuntimeTypeHandle TypeHandle => default;

	public abstract Type BaseType { get; }

	public static Binder DefaultBinder => null;

	internal virtual bool IsSzArray => false;

	public bool IsInterface => false;

	internal string FullNameOrDefault => null;

	internal string InternalNameIfAvailable => null;

	internal string NameOrDefault => null;

	public virtual bool IsEnumDefined(object value)
	{
		return false;
	}

	public virtual string GetEnumName(object value)
	{
		return null;
	}

	public virtual string[] GetEnumNames()
	{
		return null;
	}

	private Array GetEnumRawConstantValues()
	{
		return null;
	}

	private void GetEnumData(out string[] enumNames, out Array enumValues)
	{
		enumNames = null;
		enumValues = null;
	}

	private static int BinarySearch(Array array, object value)
	{
		return 0;
	}

	internal static bool IsIntegerType(Type t)
	{
		return false;
	}

	internal Type GetRootElementType()
	{
		return null;
	}

	[ComVisible(true)]
	public virtual bool IsSubclassOf(Type c)
	{
		return false;
	}

	public virtual bool IsAssignableFrom(Type c)
	{
		return false;
	}

	internal bool ImplementInterface(Type ifaceType)
	{
		return false;
	}

	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria)
	{
		return false;
	}

	private static bool FilterNameImpl(MemberInfo m, object filterCriteria)
	{
		return false;
	}

	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria)
	{
		return false;
	}

	public new Type GetType()
	{
		return null;
	}

	protected abstract bool IsArrayImpl();

	protected abstract bool IsByRefImpl();

	protected abstract bool IsPointerImpl();

	protected abstract bool HasElementTypeImpl();

	public abstract Type GetElementType();

	public virtual int GetArrayRank()
	{
		return 0;
	}

	public virtual Type GetGenericTypeDefinition()
	{
		return null;
	}

	public virtual Type[] GetGenericArguments()
	{
		return null;
	}

	public virtual Type[] GetGenericParameterConstraints()
	{
		return null;
	}

	protected abstract TypeAttributes GetAttributeFlagsImpl();

	protected abstract bool IsCOMObjectImpl();

	protected virtual bool IsContextfulImpl()
	{
		return false;
	}

	protected virtual bool IsMarshalByRefImpl()
	{
		return false;
	}

	protected abstract bool IsPrimitiveImpl();

	protected virtual bool IsValueTypeImpl()
	{
		return false;
	}

	[ComVisible(true)]
	public ConstructorInfo GetConstructor(Type[] types)
	{
		return null;
	}

	[ComVisible(true)]
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	[ComVisible(true)]
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisible(true)]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	public FieldInfo GetField(string name)
	{
		return null;
	}

	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	public MemberInfo[] GetMember(string name)
	{
		return null;
	}

	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
	{
		return null;
	}

	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

	public MethodInfo GetMethod(string name)
	{
		return null;
	}

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public MethodInfo GetMethod(string name, Type[] types)
	{
		return null;
	}

	public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	public MethodInfo[] GetMethods()
	{
		return null;
	}

	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	public PropertyInfo GetProperty(string name)
	{
		return null;
	}

	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	public PropertyInfo GetProperty(string name, Type returnType)
	{
		return null;
	}

	public PropertyInfo GetProperty(string name, Type returnType, Type[] types)
	{
		return null;
	}

	public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	public static RuntimeTypeHandle GetTypeHandle(object o)
	{
		return default;
	}

	public static TypeCode GetTypeCode(Type type)
	{
		return TypeCode.Empty;
	}

	protected virtual TypeCode GetTypeCodeImpl()
	{
		return TypeCode.Empty;
	}

	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	public Type GetInterface(string name)
	{
		return null;
	}

	public abstract Type GetInterface(string name, bool ignoreCase);

	public abstract Type[] GetInterfaces();

	public virtual bool IsInstanceOfType(object o)
	{
		return false;
	}

	public virtual bool IsEquivalentTo(Type other)
	{
		return false;
	}

	public virtual Type GetEnumUnderlyingType()
	{
		return null;
	}

	public virtual Array GetEnumValues()
	{
		return null;
	}

	public virtual Type MakeArrayType()
	{
		return null;
	}

	public virtual Type MakeArrayType(int rank)
	{
		return null;
	}

	public virtual Type MakeByRefType()
	{
		return null;
	}

	public virtual Type MakeGenericType(params Type[] typeArguments)
	{
		return null;
	}

	public virtual Type MakePointerType()
	{
		return null;
	}

	public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public virtual bool Equals(Type o)
	{
		return false;
	}

	public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
	{
		return null;
	}

	private static Type internal_from_handle(IntPtr handle)
	{
		return null;
	}

	internal string FormatTypeName()
	{
		return null;
	}

	internal virtual string FormatTypeName(bool serialization)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, bool throwOnError)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
	{
		return null;
	}

	public static bool operator ==(Type left, Type right)
	{
		return false;
	}

	public static bool operator !=(Type left, Type right)
	{
		return false;
	}

	internal bool IsRuntimeImplemented()
	{
		return false;
	}

	internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure)
	{
		return null;
	}
}

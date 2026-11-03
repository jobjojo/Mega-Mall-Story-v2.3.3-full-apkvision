using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
{
	public static readonly TypeFilter FilterTypeName;

	public static readonly TypeFilter FilterTypeNameIgnoreCase;

	private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	public virtual Assembly Assembly => null;

	public virtual Guid ModuleVersionId => default;

	public virtual string ScopeName => null;

	public virtual bool IsResource()
	{
		return false;
	}

	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(Module left, Module right)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private static bool FilterTypeNameImpl(Type cls, object filterCriteria)
	{
		return false;
	}

	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria)
	{
		return false;
	}

	internal virtual Guid GetModuleVersionId()
	{
		return default;
	}
}

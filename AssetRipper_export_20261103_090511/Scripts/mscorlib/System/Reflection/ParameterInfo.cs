using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
{
	protected ParameterAttributes AttrsImpl;

	protected Type ClassImpl;

	protected object DefaultValueImpl;

	protected MemberInfo MemberImpl;

	protected string NameImpl;

	protected int PositionImpl;

	private const int MetadataToken_ParamDef = 134217728;

	public virtual ParameterAttributes Attributes => ParameterAttributes.None;

	public virtual MemberInfo Member => null;

	public virtual string Name => null;

	public virtual Type ParameterType => null;

	public virtual int Position => 0;

	public bool IsIn => false;

	public bool IsOptional => false;

	public bool IsOut => false;

	public virtual object DefaultValue => null;

	protected ParameterInfo()
	{
	}

	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public object GetRealObject(StreamingContext context)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}

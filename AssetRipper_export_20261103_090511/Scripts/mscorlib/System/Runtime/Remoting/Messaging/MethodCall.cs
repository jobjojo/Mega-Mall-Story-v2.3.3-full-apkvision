using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[ComVisible(true)]
[CLSCompliant(false)]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _uri;

	private string _typeName;

	private string _methodName;

	private object[] _args;

	private Type[] _methodSignature;

	private MethodBase _methodBase;

	private LogicalCallContext _callContext;

	private Identity _targetIdentity;

	private Type[] _genericArguments;

	protected IDictionary ExternalProperties;

	protected IDictionary InternalProperties;

	public int ArgCount => 0;

	public object[] Args => null;

	public LogicalCallContext LogicalCallContext => null;

	public MethodBase MethodBase => null;

	public string MethodName => null;

	public object MethodSignature => null;

	public virtual IDictionary Properties => null;

	public string TypeName => null;

	public string Uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	string IInternalMessage.Uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	Identity IInternalMessage.TargetIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private Type[] GenericArguments => null;

	internal MethodCall(SerializationInfo info, StreamingContext context)
	{
	}

	internal MethodCall(CADMethodCallMessage msg)
	{
	}

	internal MethodCall()
	{
	}

	internal void CopyFrom(IMethodMessage call)
	{
	}

	internal virtual void InitMethodProperty(string key, object value)
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal virtual void InitDictionary()
	{
	}

	public object GetArg(int argNum)
	{
		return null;
	}

	public virtual void Init()
	{
	}

	public void ResolveMethod()
	{
	}

	private Type CastTo(string clientType, Type serverType)
	{
		return null;
	}

	private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
	{
		return null;
	}
}

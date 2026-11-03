using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
{
	private string _methodName;

	private string _uri;

	private string _typeName;

	private MethodBase _methodBase;

	private object _returnValue;

	private Exception _exception;

	private Type[] _methodSignature;

	private ArgInfo _inArgInfo;

	private object[] _args;

	private object[] _outArgs;

	private IMethodCallMessage _callMsg;

	private LogicalCallContext _callContext;

	private Identity _targetIdentity;

	protected IDictionary ExternalProperties;

	protected IDictionary InternalProperties;

	public int ArgCount => 0;

	public object[] Args => null;

	public Exception Exception => null;

	public LogicalCallContext LogicalCallContext => null;

	public MethodBase MethodBase => null;

	public string MethodName => null;

	public object MethodSignature => null;

	public object[] OutArgs => null;

	public virtual IDictionary Properties => null;

	public object ReturnValue => null;

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

	internal MethodResponse(Exception e, IMethodCallMessage msg)
	{
	}

	internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
	{
	}

	internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
	{
	}

	internal MethodResponse(SerializationInfo info, StreamingContext context)
	{
	}

	internal void InitMethodProperty(string key, object value)
	{
	}

	public object GetArg(int argNum)
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}

using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

[ComVisible(true)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
{
	private object[] _outArgs;

	private object[] _args;

	private LogicalCallContext _callCtx;

	private object _returnValue;

	private string _uri;

	private Exception _exception;

	private MethodBase _methodBase;

	private string _methodName;

	private Type[] _methodSignature;

	private string _typeName;

	private MethodReturnDictionary _properties;

	private Identity _targetIdentity;

	private ArgInfo _inArgInfo;

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

	public Exception Exception => null;

	public object[] OutArgs => null;

	public virtual object ReturnValue => null;

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

	public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
	{
	}

	public ReturnMessage(Exception e, IMethodCallMessage mcm)
	{
	}

	public object GetArg(int argNum)
	{
		return null;
	}
}

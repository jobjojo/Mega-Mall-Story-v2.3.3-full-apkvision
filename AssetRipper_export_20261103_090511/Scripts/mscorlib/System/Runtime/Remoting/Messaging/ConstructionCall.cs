using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
{
	private IActivator _activator;

	private object[] _activationAttributes;

	private IList _contextProperties;

	private Type _activationType;

	private string _activationTypeName;

	private bool _isContextOk;

	[NonSerialized]
	private RemotingProxy _sourceProxy;

	internal bool IsContextOk
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Type ActivationType => null;

	public string ActivationTypeName => null;

	public IActivator Activator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object[] CallSiteActivationAttributes => null;

	public IList ContextProperties => null;

	public override IDictionary Properties => null;

	internal RemotingProxy SourceProxy
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ConstructionCall(Type type)
		: base(null, default)
	{
	}

	internal ConstructionCall(SerializationInfo info, StreamingContext context)
		: base(null, default)
	{
	}

	internal override void InitDictionary()
	{
	}

	internal void SetActivationAttributes(object[] attributes)
	{
	}

	internal override void InitMethodProperty(string key, object value)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}

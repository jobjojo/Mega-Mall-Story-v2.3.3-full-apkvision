using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Proxies;

[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class RealProxy
{
	private Type class_to_proxy;

	internal Context _targetContext;

	internal MarshalByRefObject _server;

	private int _targetDomainId;

	internal string _targetUri;

	internal Identity _objectIdentity;

	private object _objTP;

	private object _stubData;

	internal Identity ObjectIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected RealProxy()
	{
	}

	protected RealProxy(Type classToProxy)
	{
	}

	internal RealProxy(Type classToProxy, ClientIdentity identity)
	{
	}

	protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
	{
	}

	private static Type InternalGetProxyType(object transparentProxy)
	{
		return null;
	}

	public Type GetProxiedType()
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public abstract IMessage Invoke(IMessage msg);

	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args)
	{
		exc = null;
		out_args = null;
		return null;
	}

	internal virtual object InternalGetTransparentProxy(string className)
	{
		return null;
	}

	public virtual object GetTransparentProxy()
	{
		return null;
	}

	protected void AttachServer(MarshalByRefObject s)
	{
	}

	internal void SetTargetDomain(int domainId)
	{
	}

	internal object GetAppDomainTarget()
	{
		return null;
	}

	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
	{
		return null;
	}
}

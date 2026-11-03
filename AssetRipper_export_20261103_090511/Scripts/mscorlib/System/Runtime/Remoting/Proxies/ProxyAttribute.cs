using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Proxies;

[AttributeUsage(AttributeTargets.Class)]
[ComVisible(true)]
public class ProxyAttribute : Attribute, IContextAttribute
{
	public virtual MarshalByRefObject CreateInstance(Type serverType)
	{
		return null;
	}

	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext)
	{
		return null;
	}

	[ComVisible(true)]
	public void GetPropertiesForNewContext(IConstructionCallMessage msg)
	{
	}

	[ComVisible(true)]
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg)
	{
		return false;
	}
}

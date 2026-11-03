using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[ComVisible(true)]
public sealed class CallContext
{
	private CallContext()
	{
	}

	internal static object SetCurrentCallContext(LogicalCallContext ctx)
	{
		return null;
	}

	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
	{
		return null;
	}
}

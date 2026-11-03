using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
{
	public override IDictionary Properties => null;

	internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
		: base((Exception)null, (IMethodCallMessage)null)
	{
	}

	internal ConstructionResponse(Exception e, IMethodCallMessage msg)
		: base((Exception)null, (IMethodCallMessage)null)
	{
	}

	internal ConstructionResponse(SerializationInfo info, StreamingContext context)
		: base((Exception)null, (IMethodCallMessage)null)
	{
	}
}

using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

[ComVisible(true)]
public class RemotingSurrogateSelector : ISurrogateSelector
{
	private static Type s_cachedTypeObjRef;

	private static ObjRefSurrogate _objRefSurrogate;

	private static RemotingSurrogate _objRemotingSurrogate;

	private ISurrogateSelector _next;

	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
	{
		ssout = null;
		return null;
	}
}

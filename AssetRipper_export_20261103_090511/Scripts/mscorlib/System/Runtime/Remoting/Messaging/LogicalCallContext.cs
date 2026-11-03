using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[ComVisible(true)]
public sealed class LogicalCallContext : ISerializable, ICloneable
{
	internal struct Reader(LogicalCallContext ctx)
	{
		private LogicalCallContext m_ctx = null;

		public bool IsNull => false;

		public bool HasInfo => false;

		public LogicalCallContext Clone()
		{
			return null;
		}
	}

	private static Type s_callContextType;

	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";

	private Hashtable m_Datastore;

	private CallContextRemotingData m_RemotingData;

	private CallContextSecurityData m_SecurityData;

	private object m_HostContext;

	private bool m_IsCorrelationMgr;

	private Header[] _sendHeaders;

	private Header[] _recvHeaders;

	public bool HasInfo => false;

	private bool HasUserData => false;

	private Hashtable Datastore => null;

	internal LogicalCallContext()
	{
	}

	internal LogicalCallContext(SerializationInfo info, StreamingContext context)
	{
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public object Clone()
	{
		return null;
	}

	internal void Merge(LogicalCallContext lc)
	{
	}
}

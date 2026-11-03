using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting;

[Serializable]
[ComVisible(true)]
public class ObjRef : IObjectReference, ISerializable
{
	private IChannelInfo channel_info;

	private string uri;

	private IRemotingTypeInfo typeInfo;

	private IEnvoyInfo envoyInfo;

	private int flags;

	private Type _serverType;

	private static int MarshalledObjectRef;

	private static int WellKnowObjectRef;

	internal bool IsReferenceToWellKnow => false;

	public virtual IChannelInfo ChannelInfo
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return null;
		}
	}

	public virtual IEnvoyInfo EnvoyInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual IRemotingTypeInfo TypeInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string URI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Type ServerType => null;

	public ObjRef()
	{
	}

	internal ObjRef(string uri, IChannelInfo cinfo)
	{
	}

	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo)
	{
		return null;
	}

	internal byte[] SerializeType()
	{
		return null;
	}

	internal ObjRef(Type type, string url, object remoteChannelData)
	{
	}

	protected ObjRef(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual object GetRealObject(StreamingContext context)
	{
		return null;
	}

	internal void UpdateChannelInfo()
	{
	}
}

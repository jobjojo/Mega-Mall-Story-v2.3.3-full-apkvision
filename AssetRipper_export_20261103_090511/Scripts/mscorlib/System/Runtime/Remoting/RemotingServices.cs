using System.Collections;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public static class RemotingServices
{
	[Serializable]
	private class CACD
	{
		public object d;

		public object c;
	}

	private static Hashtable uri_hash;

	private static BinaryFormatter _serializationFormatter;

	private static BinaryFormatter _deserializationFormatter;

	private static string app_id;

	private static readonly object app_id_lock;

	private static int next_id;

	private static readonly MethodInfo FieldSetterMethod;

	private static readonly MethodInfo FieldGetterMethod;

	static RemotingServices()
	{
	}

	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args)
	{
		out_args = null;
		return null;
	}

	internal static MethodBase GetVirtualMethod(Type type, MethodBase method)
	{
		return null;
	}

	public static bool IsTransparentProxy(object proxy)
	{
		return false;
	}

	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
	{
		return null;
	}

	[ComVisible(true)]
	public static object Connect(Type classToProxy, string url)
	{
		return null;
	}

	[ComVisible(true)]
	public static object Connect(Type classToProxy, string url, object data)
	{
		return null;
	}

	public static Type GetServerTypeForUri(string URI)
	{
		return null;
	}

	public static object Unmarshal(ObjRef objectRef)
	{
		return null;
	}

	public static object Unmarshal(ObjRef objectRef, bool fRefine)
	{
		return null;
	}

	public static ObjRef Marshal(MarshalByRefObject Obj)
	{
		return null;
	}

	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
	{
		return null;
	}

	private static string NewUri()
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static RealProxy GetRealProxy(object proxy)
	{
		return null;
	}

	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
	{
		return null;
	}

	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature)
	{
		return null;
	}

	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature)
	{
		return null;
	}

	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	public static bool IsOneWay(MethodBase method)
	{
		return false;
	}

	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
	{
		return null;
	}

	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes)
	{
		return null;
	}

	internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
	{
		return null;
	}

	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes)
	{
		return null;
	}

	internal static Identity GetIdentityForUri(string uri)
	{
		return null;
	}

	private static string RemoveAppNameFromUri(string uri)
	{
		return null;
	}

	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy)
	{
		clientProxy = null;
		return null;
	}

	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri)
	{
		objectUri = null;
		return null;
	}

	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
	{
		return null;
	}

	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
	{
		return null;
	}

	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
	{
		return null;
	}

	private static void RegisterServerIdentity(ServerIdentity identity)
	{
	}

	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
	{
		return null;
	}

	internal static object GetRemoteObject(ObjRef objRef, Type proxyType)
	{
		return null;
	}

	internal static byte[] SerializeCallData(object obj)
	{
		return null;
	}

	internal static object DeserializeCallData(byte[] array)
	{
		return null;
	}

	internal static byte[] SerializeExceptionData(Exception ex)
	{
		return null;
	}

	private static void RegisterInternalChannels()
	{
	}

	internal static void DisposeIdentity(Identity ident)
	{
	}

	internal static Identity GetMessageTargetIdentity(IMessage msg)
	{
		return null;
	}

	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident)
	{
	}

	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote)
	{
		return false;
	}

	private static string GetNormalizedUri(string uri)
	{
		return null;
	}
}

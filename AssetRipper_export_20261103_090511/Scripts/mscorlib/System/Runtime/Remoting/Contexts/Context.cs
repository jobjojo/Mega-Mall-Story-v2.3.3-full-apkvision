using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts;

[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class Context
{
	private int domain_id;

	private int context_id;

	private UIntPtr static_data;

	private UIntPtr data;

	[ContextStatic]
	private static object[] local_slots;

	private static IMessageSink default_server_context_sink;

	private IMessageSink server_context_sink_chain;

	private IMessageSink client_context_sink_chain;

	private List<IContextProperty> context_properties;

	private static int global_count;

	private LocalDataStoreHolder _localDataStore;

	private static LocalDataStoreMgr _localDataStoreMgr;

	private static DynamicPropertyCollection global_dynamic_properties;

	private DynamicPropertyCollection context_dynamic_properties;

	private ContextCallbackObject callback_object;

	public static Context DefaultContext => null;

	public virtual int ContextID => 0;

	public virtual IContextProperty[] ContextProperties => null;

	internal bool IsDefaultContext => false;

	internal bool NeedsContextSink => false;

	internal static bool HasGlobalDynamicSinks => false;

	internal bool HasDynamicSinks => false;

	internal bool HasExitSinks => false;

	private LocalDataStore MyLocalStore => null;

	private static void RegisterContext(Context ctx)
	{
	}

	private static void ReleaseContext(Context ctx)
	{
	}

	~Context()
	{
	}

	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
	{
		return false;
	}

	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
	{
		return false;
	}

	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
	{
		return null;
	}

	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
	{
	}

	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
	{
	}

	public virtual IContextProperty GetProperty(string name)
	{
		return null;
	}

	public virtual void SetProperty(IContextProperty prop)
	{
	}

	public virtual void Freeze()
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal IMessageSink GetServerContextSinkChain()
	{
		return null;
	}

	internal IMessageSink GetClientContextSinkChain()
	{
		return null;
	}

	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
	{
		return null;
	}

	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
	{
		return null;
	}

	internal static Context SwitchToContext(Context newContext)
	{
		return null;
	}

	internal static Context CreateNewContext(IConstructionCallMessage msg)
	{
		return null;
	}

	public void DoCallBack(CrossContextDelegate deleg)
	{
	}

	public static LocalDataStoreSlot AllocateDataSlot()
	{
		return null;
	}

	public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
	{
		return null;
	}

	public static void FreeNamedDataSlot(string name)
	{
	}

	public static LocalDataStoreSlot GetNamedDataSlot(string name)
	{
		return null;
	}

	public static object GetData(LocalDataStoreSlot slot)
	{
		return null;
	}

	public static void SetData(LocalDataStoreSlot slot, object data)
	{
	}
}

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;

namespace System;

[StructLayout((LayoutKind)0)]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public sealed class AppDomain : MarshalByRefObject
{
	private IntPtr _mono_app_domain;

	private static string _process_guid;

	[ThreadStatic]
	private static Dictionary<string, object> type_resolve_in_progress;

	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress;

	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly;

	private object _evidence;

	private object _granted;

	private int _principalPolicy;

	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad;

	[CompilerGenerated]
	private ResolveEventHandler m_AssemblyResolve;

	[CompilerGenerated]
	private EventHandler DomainUnload;

	[CompilerGenerated]
	private EventHandler ProcessExit;

	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve;

	[CompilerGenerated]
	private ResolveEventHandler TypeResolve;

	[CompilerGenerated]
	private UnhandledExceptionEventHandler m_UnhandledException;

	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;

	private object _domain_manager;

	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve;

	private object _activation;

	private object _applicationIdentity;

	private List<string> compatibility_switch;

	public static AppDomain CurrentDomain => null;

	public event ResolveEventHandler AssemblyResolve
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event UnhandledExceptionEventHandler UnhandledException
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Intrinsic]
	internal static bool IsAppXModel()
	{
		return false;
	}

	private AppDomain()
	{
	}

	private string getFriendlyName()
	{
		return null;
	}

	private static AppDomain getCurDomain()
	{
		return null;
	}

	public object GetData(string name)
	{
		return null;
	}

	public override object InitializeLifetimeService()
	{
		return null;
	}

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Assembly Load(string assemblyString)
	{
		return null;
	}

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private static AppDomain InternalSetDomainByID(int domain_id)
	{
		return null;
	}

	private static AppDomain InternalSetDomain(AppDomain context)
	{
		return null;
	}

	internal static void InternalPushDomainRefByID(int domain_id)
	{
	}

	internal static void InternalPopDomainRef()
	{
	}

	internal static Context InternalSetContext(Context context)
	{
		return null;
	}

	internal static Context InternalGetContext()
	{
		return null;
	}

	internal static Context InternalGetDefaultContext()
	{
		return null;
	}

	internal static string InternalGetProcessGuid(string newguid)
	{
		return null;
	}

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args)
	{
		return null;
	}

	internal static string GetProcessGuid()
	{
		return null;
	}

	private static bool InternalIsFinalizingForUnload(int domain_id)
	{
		return false;
	}

	public bool IsFinalizingForUnload()
	{
		return false;
	}

	private int getDomainID()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	private void DoAssemblyLoad(Assembly assembly)
	{
	}

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly)
	{
		return null;
	}

	internal Assembly DoTypeResolve(string name)
	{
		return null;
	}

	internal Assembly DoResourceResolve(string name, Assembly requesting)
	{
		return null;
	}

	private void DoDomainUnload()
	{
	}

	internal byte[] GetMarshalledDomainObjRef()
	{
		return null;
	}

	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm)
	{
		arrResponse = null;
		cadMrm = null;
	}
}

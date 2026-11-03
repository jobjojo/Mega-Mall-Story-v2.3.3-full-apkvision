using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;

namespace System.Threading;

[StructLayout((LayoutKind)0)]
public sealed class Thread : CriticalFinalizerObject
{
	private static LocalDataStoreMgr s_LocalDataStoreMgr;

	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore;

	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture;

	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture;

	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

	private InternalThread internal_thread;

	private object m_ThreadStartArg;

	private object pending_exception;

	[ThreadStatic]
	private static Thread current_thread;

	private MulticastDelegate m_Delegate;

	private ExecutionContext m_ExecutionContext;

	private bool m_ExecutionContextBelongsToOuterScope;

	private IPrincipal principal;

	private int principal_version;

	internal bool ExecutionContextBelongsToCurrentScope
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ThreadPriority Priority
	{
		set
		{
		}
	}

	public CultureInfo CurrentUICulture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CultureInfo CurrentCulture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private InternalThread Internal => null;

	public static Context CurrentContext => null;

	public static Thread CurrentThread
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		get
		{
			return null;
		}
	}

	public bool IsThreadPoolThread => false;

	internal bool IsThreadPoolThreadInternal => false;

	public bool IsBackground
	{
		set
		{
		}
	}

	public string Name
	{
		set
		{
		}
	}

	public ThreadState ThreadState => ThreadState.Running;

	public int ManagedThreadId
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
	{
	}

	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args)
	{
	}

	public Thread(ThreadStart start)
	{
	}

	public Thread(ParameterizedThreadStart start)
	{
	}

	public Thread(ParameterizedThreadStart start, int maxStackSize)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start(object parameter)
	{
	}

	private void Start(ref StackCrawlMark stackMark)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext.Reader GetExecutionContextReader()
	{
		return default;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal ExecutionContext GetMutableExecutionContext()
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
	{
	}

	public void Interrupt()
	{
	}

	private void InterruptInternal()
	{
	}

	private void SetPriorityNative(int priority)
	{
	}

	private static void SleepInternal(int millisecondsTimeout)
	{
	}

	public static void Sleep(int millisecondsTimeout)
	{
	}

	private static bool YieldInternal()
	{
		return false;
	}

	public static bool Yield()
	{
		return false;
	}

	private void SetStartHelper(Delegate start, int maxStackSize)
	{
	}

	internal CultureInfo GetCurrentUICultureNoAppX()
	{
		return null;
	}

	private CultureInfo GetCurrentCultureNoAppX()
	{
		return null;
	}

	private static void nativeInitCultureAccessors()
	{
	}

	public static void MemoryBarrier()
	{
	}

	private void ConstructInternalThread()
	{
	}

	private static void GetCurrentThread_icall(ref Thread thread)
	{
	}

	private static Thread GetCurrentThread()
	{
		return null;
	}

	public static int GetDomainID()
	{
		return 0;
	}

	private bool Thread_internal(MulticastDelegate start)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	~Thread()
	{
	}

	private unsafe static void SetName_icall(InternalThread thread, char* name, int nameLength)
	{
	}

	private static void SetName_internal(InternalThread thread, string name)
	{
	}

	private static void Abort_internal(InternalThread thread, object stateInfo)
	{
	}

	public void Abort()
	{
	}

	private static void SpinWait_nop()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void SpinWait(int iterations)
	{
	}

	private void StartInternal(object principal, ref StackCrawlMark stackMark)
	{
	}

	private static void SetState(InternalThread thread, ThreadState set)
	{
	}

	private static void ClrState(InternalThread thread, ThreadState clr)
	{
	}

	private static ThreadState GetState(InternalThread thread)
	{
		return ThreadState.Running;
	}

	private static int SystemMaxStackStize()
	{
		return 0;
	}

	private static int GetProcessDefaultStackSize(int maxStackSize)
	{
		return 0;
	}

	private void SetStart(MulticastDelegate start, int maxStackSize)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static void BeginCriticalRegion()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void EndCriticalRegion()
	{
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		return 0;
	}

	private ThreadState ValidateThreadState()
	{
		return ThreadState.Running;
	}
}

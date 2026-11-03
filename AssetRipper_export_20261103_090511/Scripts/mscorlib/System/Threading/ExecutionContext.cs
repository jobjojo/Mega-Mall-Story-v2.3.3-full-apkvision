using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable
{
	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4
	}

	internal struct Reader(ExecutionContext ec)
	{
		private ExecutionContext m_ec = null;

		public bool IsNull => false;

		public bool IsFlowSuppressed
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public SynchronizationContext SynchronizationContext => null;

		public SynchronizationContext SynchronizationContextNoFlow => null;

		public LogicalCallContext.Reader LogicalCallContext => default;

		public ExecutionContext DangerousGetRawExecutionContext()
		{
			return null;
		}

		public bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			return false;
		}

		public bool HasSameLocalValues(ExecutionContext other)
		{
			return false;
		}
	}

	[Flags]
	internal enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2
	}

	private SynchronizationContext _syncContext;

	private SynchronizationContext _syncContextNoFlow;

	private LogicalCallContext _logicalCallContext;

	private IllogicalCallContext _illogicalCallContext;

	private Flags _flags;

	private Dictionary<IAsyncLocal, object> _localValues;

	private List<IAsyncLocal> _localChangeNotifications;

	private static readonly ExecutionContext s_dummyDefaultEC;

	internal static readonly ExecutionContext Default;

	internal bool isNewCapture
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isFlowSuppressed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool IsPreAllocatedDefault => false;

	internal LogicalCallContext LogicalCallContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal IllogicalCallContext IllogicalCallContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal SynchronizationContext SynchronizationContext
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return null;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
		}
	}

	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return null;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext(bool isPreAllocatedDefault)
	{
	}

	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications)
	{
	}

	[HandleProcessCorruptedStateExceptions]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
	{
	}

	public void Dispose()
	{
	}

	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
	{
	}

	[FriendAccessAllowed]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
	{
	}

	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
	{
	}

	[HandleProcessCorruptedStateExceptions]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
	{
	}

	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
	{
	}

	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
	{
		return default;
	}

	internal ExecutionContext CreateMutableCopy()
	{
		return null;
	}

	public static bool IsFlowSuppressed()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ExecutionContext Capture()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[FriendAccessAllowed]
	internal static ExecutionContext FastCapture()
	{
		return null;
	}

	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options)
	{
		return null;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private ExecutionContext(SerializationInfo info, StreamingContext context)
	{
	}

	internal bool IsDefaultFTContext(bool ignoreSyncCtx)
	{
		return false;
	}
}

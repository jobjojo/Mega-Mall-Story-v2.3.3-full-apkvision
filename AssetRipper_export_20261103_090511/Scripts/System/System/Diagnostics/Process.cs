using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
public class Process : Component
{
	private enum StreamReadMode
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2
	}

	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12
	}

	private struct ProcInfo
	{
		public IntPtr process_handle;

		public int pid;

		public string[] envVariables;

		public string UserName;

		public string Domain;

		public IntPtr Password;

		public bool LoadUserProfile;
	}

	private bool haveProcessId;

	private int processId;

	private bool haveProcessHandle;

	private SafeProcessHandle m_processHandle;

	private bool isRemoteMachine;

	private string machineName;

	private int m_processAccess;

	private ProcessThreadCollection threads;

	private ProcessModuleCollection modules;

	private bool haveWorkingSetLimits;

	private IntPtr minWorkingSet;

	private IntPtr maxWorkingSet;

	private bool havePriorityClass;

	private ProcessPriorityClass priorityClass;

	private ProcessStartInfo startInfo;

	private bool watchForExit;

	private bool watchingForExit;

	private EventHandler onExited;

	private bool exited;

	private int exitCode;

	private bool signaled;

	private DateTime exitTime;

	private bool haveExitTime;

	private bool raisedOnExited;

	private RegisteredWaitHandle registeredWaitHandle;

	private WaitHandle waitHandle;

	private ISynchronizeInvoke synchronizingObject;

	private StreamReader standardOutput;

	private StreamWriter standardInput;

	private StreamReader standardError;

	private OperatingSystem operatingSystem;

	private bool disposed;

	private StreamReadMode outputStreamReadMode;

	private StreamReadMode errorStreamReadMode;

	private StreamReadMode inputStreamReadMode;

	[CompilerGenerated]
	private DataReceivedEventHandler OutputDataReceived;

	[CompilerGenerated]
	private DataReceivedEventHandler ErrorDataReceived;

	internal AsyncStreamReader output;

	internal AsyncStreamReader error;

	internal bool pendingOutputRead;

	internal bool pendingErrorRead;

	internal static TraceSwitch processTracing;

	private string process_name;

	private static ProcessModule current_main_module;

	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	private bool Associated => false;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	public bool HasExited => false;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
	public IntPtr Handle => (IntPtr)0;

	[MonitoringDescription("Specifies information used to start a process.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public ProcessStartInfo StartInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	public ISynchronizeInvoke SynchronizingObject => null;

	[MonitoringDescription("Whether the process component should watch for the associated process to exit, and raise the Exited event.")]
	[DefaultValue(false)]
	[Browsable(false)]
	public bool EnableRaisingEvents
	{
		set
		{
		}
	}

	[MonitoringDescription("Standard output stream of the process.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public StreamReader StandardOutput => null;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName => null;

	private static bool IsWindows => false;

	[MonitoringDescription("If the WatchForExit property is set to true, then this event is raised when the associated process exits.")]
	[Category("Behavior")]
	public event EventHandler Exited
	{
		add
		{
		}
		remove
		{
		}
	}

	public Process()
	{
	}

	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
	{
	}

	private void ReleaseProcessHandle(SafeProcessHandle handle)
	{
	}

	private void CompletionCallback(object context, bool wasSignaled)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public void Close()
	{
	}

	private void EnsureState(State state)
	{
	}

	private void EnsureWatchingForExit()
	{
	}

	public static Process GetProcessById(int processId)
	{
		return null;
	}

	public static Process[] GetProcessesByName(string processName)
	{
		return null;
	}

	public static Process[] GetProcesses()
	{
		return null;
	}

	public static Process GetCurrentProcess()
	{
		return null;
	}

	protected void OnExited()
	{
	}

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
	{
		return null;
	}

	private SafeProcessHandle GetProcessHandle(int access)
	{
		return null;
	}

	private SafeProcessHandle OpenProcessHandle()
	{
		return null;
	}

	private SafeProcessHandle OpenProcessHandle(int access)
	{
		return null;
	}

	public void Refresh()
	{
	}

	private void SetProcessHandle(SafeProcessHandle processHandle)
	{
	}

	private void SetProcessId(int processId)
	{
	}

	public bool Start()
	{
		return false;
	}

	public static Process Start(string fileName)
	{
		return null;
	}

	public static Process Start(ProcessStartInfo startInfo)
	{
		return null;
	}

	public void Kill()
	{
	}

	private void StopWatchingForExit()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public bool WaitForExit(int milliseconds)
	{
		return false;
	}

	public void WaitForExit()
	{
	}

	private Process(SafeProcessHandle handle, int id)
	{
	}

	private static string ProcessName_icall(IntPtr handle)
	{
		return null;
	}

	private static string ProcessName_internal(SafeProcessHandle handle)
	{
		return null;
	}

	private static IntPtr GetProcess_internal(int pid)
	{
		return (IntPtr)0;
	}

	[MonoTODO("There is no support for retrieving process information from a remote machine")]
	public static Process GetProcessById(int processId, string machineName)
	{
		return null;
	}

	public static Process[] GetProcessesByName(string processName, string machineName)
	{
		return null;
	}

	private static int[] GetProcesses_internal()
	{
		return null;
	}

	[MonoTODO("There is no support for retrieving process information from a remote machine")]
	public static Process[] GetProcesses(string machineName)
	{
		return null;
	}

	private static bool IsLocalMachine(string machineName)
	{
		return false;
	}

	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref ProcInfo procInfo)
	{
		return false;
	}

	private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref ProcInfo procInfo)
	{
		return false;
	}

	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
	{
		return false;
	}

	private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection)
	{
		read = default;
		write = default;
	}

	private bool StartWithCreateProcess(ProcessStartInfo startInfo)
	{
		return false;
	}

	private static void FillUserInfo(ProcessStartInfo startInfo, ref ProcInfo procInfo)
	{
	}

	private void RaiseOnExited()
	{
	}
}

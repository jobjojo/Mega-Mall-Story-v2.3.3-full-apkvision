using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Diagnostics;

[Serializable]
[ComVisible(true)]
[MonoTODO("Serialized objects are not compatible with .NET")]
public class StackTrace
{
	internal enum TraceFormat
	{
		Normal = 0,
		TrailingNewLine = 1,
		NoResourceLookup = 2
	}

	public const int METHODS_TO_SKIP = 0;

	private const string prefix = "  at ";

	private StackFrame[] frames;

	private readonly StackTrace[] captured_traces;

	private bool debug_info;

	private static bool isAotidSet;

	private static string aotid;

	public virtual int FrameCount => 0;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackTrace()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackTrace(bool fNeedFileInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackTrace(int skipFrames, bool fNeedFileInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void init_frames(int skipFrames, bool fNeedFileInfo)
	{
	}

	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo)
	{
		return null;
	}

	public StackTrace(Exception e, bool fNeedFileInfo)
	{
	}

	public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
	{
	}

	public virtual StackFrame GetFrame(int index)
	{
		return null;
	}

	private static string GetAotId()
	{
		return null;
	}

	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync)
	{
		isAsync = default;
		return false;
	}

	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync)
	{
		skipped = default;
		isAsync = default;
	}

	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal string ToString(TraceFormat traceFormat)
	{
		return null;
	}
}

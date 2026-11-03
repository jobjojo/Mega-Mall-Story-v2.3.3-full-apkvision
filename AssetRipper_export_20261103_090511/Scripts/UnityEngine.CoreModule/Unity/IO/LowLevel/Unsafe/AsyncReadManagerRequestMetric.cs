using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe;

[RequiredByNativeCode]
[NativeConditional("ENABLE_PROFILER")]
public struct AsyncReadManagerRequestMetric
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string AssetName;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string FileName;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong OffsetBytes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong SizeBytes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong AssetTypeId;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong CurrentBytesRead;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly uint BatchReadCount;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly bool IsBatchRead;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ProcessingState State;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly FileReadType ReadType;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Priority PriorityLevel;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly AssetLoadingSubsystem Subsystem;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly double RequestTimeMicroseconds;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly double TimeInQueueMicroseconds;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly double TotalTimeMicroseconds;
}

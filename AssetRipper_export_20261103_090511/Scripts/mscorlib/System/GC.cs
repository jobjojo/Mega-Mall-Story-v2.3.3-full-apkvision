using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System;

public static class GC
{
	internal static readonly object EPHEMERON_TOMBSTONE;

	public static int MaxGeneration => 0;

	private static int GetMaxGeneration()
	{
		return 0;
	}

	private static void InternalCollect(int generation)
	{
	}

	internal static void register_ephemeron_array(Ephemeron[] array)
	{
	}

	private static object get_ephemeron_tombstone()
	{
		return null;
	}

	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
	{
		highMemLoadThreshold = default;
		totalPhysicalMem = default;
		lastRecordedMemLoad = default;
		lastRecordedHeapSize = default;
		lastRecordedFragmentation = default;
	}

	public static void Collect(int generation)
	{
	}

	public static void Collect()
	{
	}

	public static void Collect(int generation, GCCollectionMode mode)
	{
	}

	public static void Collect(int generation, GCCollectionMode mode, bool blocking)
	{
	}

	public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void KeepAlive(object obj)
	{
	}

	public static void WaitForPendingFinalizers()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void _SuppressFinalize(object o)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void SuppressFinalize(object obj)
	{
	}

	private static void _ReRegisterForFinalize(object o)
	{
	}

	public static void ReRegisterForFinalize(object obj)
	{
	}
}

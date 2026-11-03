using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe;

[NativeHeader("Runtime/Jobs/JobSystem.h")]
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public static class JobsUtility
{
	internal delegate void PanicFunction_();

	internal static PanicFunction_ PanicFunction;

	[FreeFunction(ThrowsException = true, IsThreadSafe = true)]
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2)
	{
		return (IntPtr)0;
	}

	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null)
	{
		return (IntPtr)0;
	}

	[RequiredByNativeCode]
	private static void InvokePanicFunction()
	{
	}
}

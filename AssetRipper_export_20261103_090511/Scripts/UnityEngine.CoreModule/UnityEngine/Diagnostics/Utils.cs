using UnityEngine.Bindings;

namespace UnityEngine.Diagnostics;

[NativeHeader("Runtime/Misc/GarbageCollectSharedAssets.h")]
[NativeHeader("Runtime/Export/Diagnostics/DiagnosticsUtils.bindings.h")]
public static class Utils
{
	[FreeFunction("DiagnosticsUtils_Bindings::ForceCrash", IsThreadSafe = true, ThrowsException = true)]
	public static void ForceCrash(ForcedCrashCategory crashCategory)
	{
	}
}

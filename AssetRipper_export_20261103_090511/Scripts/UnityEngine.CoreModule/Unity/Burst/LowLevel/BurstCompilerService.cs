using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/Burst.h")]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType.Arrow)]
internal static class BurstCompilerService
{
	[ThreadSafe]
	public unsafe static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment)
	{
		return null;
	}
}

using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", StaticAccessorType.DoubleColon)]
internal static class BurstLike
{
	internal readonly struct SharedStatic<T> where T : struct
	{
		private unsafe readonly void* _buffer = null;

		public ref T Data
		{
			get
			{
				throw null;
			}
		}

		private unsafe SharedStatic(void* buffer)
		{
		}

		public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0u)
		{
			return default;
		}
	}

	internal static class SharedStatic
	{
		public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
		{
			return null;
		}
	}
}

using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
public class Time
{
	[NativeProperty("CurTime")]
	public static float time => 0f;

	public static float unscaledTime => 0f;

	public static float fixedUnscaledTime => 0f;

	public static float fixedDeltaTime
	{
		set
		{
		}
	}

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup => 0f;
}

using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/DrawSplashScreenAndWatermarks.h")]
public class SplashScreen
{
	public static bool isFinished
	{
		[FreeFunction("IsSplashScreenFinished")]
		get
		{
			return false;
		}
	}
}

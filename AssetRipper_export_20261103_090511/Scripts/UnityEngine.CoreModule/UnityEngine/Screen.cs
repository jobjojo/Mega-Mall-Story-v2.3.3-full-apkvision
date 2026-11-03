using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
public sealed class Screen
{
	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	public static float dpi
	{
		[NativeName("GetDPI")]
		get
		{
			return 0f;
		}
	}

	public static ScreenOrientation orientation
	{
		get
		{
			return ScreenOrientation.Unknown;
		}
		set
		{
		}
	}

	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout
	{
		set
		{
		}
	}

	public static bool autorotateToPortrait => false;

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		get
		{
			return false;
		}
		[NativeName("RequestSetFullscreenFromScript")]
		set
		{
		}
	}

	private static void RequestOrientation(ScreenOrientation orient)
	{
	}

	private static ScreenOrientation GetScreenOrientation()
	{
		return ScreenOrientation.Unknown;
	}

	[NativeName("GetIsOrientationEnabled")]
	private static bool IsOrientationEnabled(EnabledOrientation orient)
	{
		return false;
	}

	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
	{
	}

	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void SetResolution(int width, int height, bool fullscreen, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate)
	{
	}

	public static void SetResolution(int width, int height, bool fullscreen)
	{
	}

	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
	{
	}
}

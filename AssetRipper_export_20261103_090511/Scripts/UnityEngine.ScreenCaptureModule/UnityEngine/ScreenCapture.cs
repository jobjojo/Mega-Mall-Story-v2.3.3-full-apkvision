using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
public static class ScreenCapture
{
	public enum StereoScreenCaptureMode
	{
		LeftEye = 1,
		RightEye = 2,
		BothEyes = 3
	}

	public static void CaptureScreenshot(string filename)
	{
	}

	public static void CaptureScreenshot(string filename, int superSize)
	{
	}

	public static void CaptureScreenshot(string filename, StereoScreenCaptureMode stereoCaptureMode)
	{
	}

	public static Texture2D CaptureScreenshotAsTexture()
	{
		return null;
	}

	public static Texture2D CaptureScreenshotAsTexture(int superSize)
	{
		return null;
	}

	public static Texture2D CaptureScreenshotAsTexture(StereoScreenCaptureMode stereoCaptureMode)
	{
		return null;
	}

	public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture)
	{
	}

	private static void CaptureScreenshot(string filename, [DefaultValue("1")] int superSize, [DefaultValue("1")] StereoScreenCaptureMode CaptureMode)
	{
	}

	private static Texture2D CaptureScreenshotAsTexture(int superSize, StereoScreenCaptureMode stereoScreenCaptureMode)
	{
		return null;
	}
}

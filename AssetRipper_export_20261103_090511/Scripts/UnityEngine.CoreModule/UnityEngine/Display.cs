using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/DisplayManager.h")]
public class Display
{
	public delegate void DisplaysUpdatedDelegate();

	internal IntPtr nativeDisplay;

	public static Display[] displays;

	private static Display _mainDisplay;

	private static int m_ActiveEditorGameViewTarget;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static DisplaysUpdatedDelegate onDisplaysUpdated;

	public int systemWidth => 0;

	public int systemHeight => 0;

	internal Display()
	{
	}

	internal Display(IntPtr nativeDisplay)
	{
	}

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
	{
		return default;
	}

	[RequiredByNativeCode]
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay)
	{
	}

	[RequiredByNativeCode]
	internal static void FireDisplaysUpdated()
	{
	}

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
	{
		w = default;
		h = default;
	}

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
	{
		rx = default;
		ry = default;
		return 0;
	}
}

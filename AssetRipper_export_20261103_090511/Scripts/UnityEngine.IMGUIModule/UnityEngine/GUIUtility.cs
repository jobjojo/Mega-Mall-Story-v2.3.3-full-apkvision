using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
public class GUIUtility
{
	internal static int s_ControlCount;

	internal static int s_SkinMode;

	internal static int s_OriginalID;

	internal static Action takeCapture;

	internal static Action releaseCapture;

	internal static Func<int, IntPtr, bool> processEvent;

	internal static Func<Exception, bool> endContainerGUIFromException;

	internal static Action guiChanged;

	internal static Action<EventType, KeyCode> beforeEventProcessed;

	private static Event m_Event;

	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc;

	[NativeProperty("GetGUIState().m_PixelsPerPoint", true, TargetType.Field)]
	internal static float pixelsPerPoint => 0f;

	[NativeProperty("GetGUIState().m_OnGUIDepth", true, TargetType.Field)]
	internal static int guiDepth => 0;

	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, TargetType.Field)]
	internal static bool mouseUsed
	{
		set
		{
		}
	}

	[StaticAccessor("GetInputManager()", StaticAccessorType.Dot)]
	internal static bool textFieldInput
	{
		set
		{
		}
	}

	public static string systemCopyBuffer
	{
		[FreeFunction("GetCopyBuffer")]
		get
		{
			return null;
		}
		[FreeFunction("SetCopyBuffer")]
		set
		{
		}
	}

	[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
	internal static string compositionString => null;

	[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
	internal static Vector2 compositionCursorPos
	{
		set
		{
		}
	}

	internal static bool guiIsExiting { set; }

	public static int hotControl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int keyboardControl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[FreeFunction("GetGUIState().GetControlID")]
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
	{
		return 0;
	}

	public static int GetControlID(int hint, FocusType focusType, Rect rect)
	{
		return 0;
	}

	private static int Internal_GetHotControl()
	{
		return 0;
	}

	private static int Internal_GetKeyboardControl()
	{
		return 0;
	}

	private static void Internal_SetHotControl(int value)
	{
	}

	private static void Internal_SetKeyboardControl(int value)
	{
	}

	private static object Internal_GetDefaultSkin(int skinMode)
	{
		return null;
	}

	private static void Internal_ExitGUI()
	{
	}

	[RequiredByNativeCode]
	private static void MarkGUIChanged()
	{
	}

	public static int GetControlID(FocusType focus)
	{
		return 0;
	}

	public static int GetControlID(int hint, FocusType focus)
	{
		return 0;
	}

	public static object GetStateObject(Type t, int controlID)
	{
		return null;
	}

	[RequiredByNativeCode]
	internal static void TakeCapture()
	{
	}

	[RequiredByNativeCode]
	internal static void RemoveCapture()
	{
	}

	internal static bool HasKeyFocus(int controlID)
	{
		return false;
	}

	internal static GUISkin GetDefaultSkin()
	{
		return null;
	}

	[RequiredByNativeCode]
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
	{
		result = default;
	}

	[RequiredByNativeCode]
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
	{
	}

	[RequiredByNativeCode]
	internal static void DestroyGUI(int instanceID)
	{
	}

	[RequiredByNativeCode]
	internal static void EndGUI(int layoutType)
	{
	}

	[RequiredByNativeCode]
	internal static bool EndGUIFromException(Exception exception)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal static bool EndContainerGUIFromException(Exception exception)
	{
		return false;
	}

	internal static void ResetGlobalState()
	{
	}

	internal static bool IsExitGUIException(Exception exception)
	{
		return false;
	}

	internal static bool ShouldRethrowException(Exception exception)
	{
		return false;
	}

	internal static void CheckOnGUI()
	{
	}

	internal static bool HitTest(Rect rect, Vector2 point, int offset)
	{
		return false;
	}

	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
	{
		return false;
	}

	internal static bool HitTest(Rect rect, Event evt)
	{
		return false;
	}

	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect)
	{
		return 0;
	}

	[SpecialName]
	private static void set_compositionCursorPos_Injected(ref Vector2 value)
	{
	}
}

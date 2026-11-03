using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIClip.h")]
[NativeHeader("Modules/IMGUI/GUIState.h")]
internal sealed class GUIClip
{
	internal static Rect visibleRect
	{
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
		get
		{
			return default;
		}
	}

	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
	}

	internal static void Internal_Pop()
	{
	}

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos)
	{
		return default;
	}

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
	}

	internal static void Pop()
	{
	}

	public static Vector2 UnclipToWindow(Vector2 pos)
	{
		return default;
	}

	[SpecialName]
	private static void get_visibleRect_Injected(out Rect ret)
	{
		ret = default;
	}

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset)
	{
	}

	private static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret)
	{
		ret = default;
	}
}

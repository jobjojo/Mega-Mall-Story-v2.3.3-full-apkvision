using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
public sealed class Event
{
	[NonSerialized]
	internal IntPtr m_Ptr;

	private static Event s_Current;

	private static Event s_MasterEvent;

	[NativeProperty("type", false, TargetType.Field)]
	public EventType rawType => EventType.MouseDown;

	[NativeProperty("mousePosition", false, TargetType.Field)]
	public Vector2 mousePosition => default;

	[NativeProperty("delta", false, TargetType.Field)]
	public Vector2 delta => default;

	[NativeProperty("pointerType", false, TargetType.Field)]
	public PointerType pointerType => PointerType.Mouse;

	[NativeProperty("modifiers", false, TargetType.Field)]
	public EventModifiers modifiers
	{
		get
		{
			return EventModifiers.None;
		}
		set
		{
		}
	}

	[NativeProperty("clickCount", false, TargetType.Field)]
	public int clickCount => 0;

	[NativeProperty("character", false, TargetType.Field)]
	public char character
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	[NativeProperty("keycode", false, TargetType.Field)]
	public KeyCode keyCode
	{
		get
		{
			return KeyCode.None;
		}
		set
		{
		}
	}

	[NativeProperty("displayIndex", false, TargetType.Field)]
	public int displayIndex
	{
		set
		{
		}
	}

	public EventType type
	{
		[FreeFunction("GUIEvent::GetType", HasExplicitThis = true)]
		get
		{
			return EventType.MouseDown;
		}
		[FreeFunction("GUIEvent::SetType", HasExplicitThis = true)]
		set
		{
		}
	}

	public string commandName
	{
		[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public bool shift => false;

	public bool control => false;

	public bool alt => false;

	public bool command => false;

	public static Event current => null;

	public bool isKey => false;

	public bool isMouse => false;

	internal bool isDirectManipulationDevice => false;

	[NativeMethod("Use")]
	private void Internal_Use()
	{
	}

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
	private static IntPtr Internal_Create(int displayIndex)
	{
		return (IntPtr)0;
	}

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = true)]
	public EventType GetTypeForControl(int controlID)
	{
		return EventType.MouseDown;
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = true, HasExplicitThis = true)]
	internal void CopyFromPtr(IntPtr ptr)
	{
	}

	private static void Internal_SetNativeEvent(IntPtr ptr)
	{
	}

	[RequiredByNativeCode]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex)
	{
	}

	public Event()
	{
	}

	public Event(int displayIndex)
	{
	}

	~Event()
	{
	}

	public static Event KeyboardEvent(string key)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void Use()
	{
	}

	[SpecialName]
	private void get_mousePosition_Injected(out Vector2 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void get_delta_Injected(out Vector2 ret)
	{
		ret = default;
	}
}

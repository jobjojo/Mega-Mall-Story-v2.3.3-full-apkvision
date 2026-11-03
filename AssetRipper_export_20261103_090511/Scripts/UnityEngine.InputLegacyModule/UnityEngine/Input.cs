using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input
{
	[NativeThrows]
	public static bool anyKey => false;

	[NativeThrows]
	public static string inputString => null;

	[NativeThrows]
	public static Vector3 mousePosition => default;

	[NativeThrows]
	public static Vector2 mouseScrollDelta => default;

	public static int touchCount
	{
		[FreeFunction("GetTouchCount")]
		get
		{
			return 0;
		}
	}

	public static bool multiTouchEnabled
	{
		[FreeFunction("IsMultiTouchEnabled")]
		get
		{
			return false;
		}
		[FreeFunction("SetMultiTouchEnabled")]
		set
		{
		}
	}

	public static float GetAxis(string axisName)
	{
		return 0f;
	}

	[NativeThrows]
	private static bool GetKeyInt(KeyCode key)
	{
		return false;
	}

	[NativeThrows]
	private static bool GetKeyUpInt(KeyCode key)
	{
		return false;
	}

	[NativeThrows]
	private static bool GetKeyDownInt(KeyCode key)
	{
		return false;
	}

	[NativeThrows]
	public static bool GetMouseButton(int button)
	{
		return false;
	}

	[NativeThrows]
	public static bool GetMouseButtonDown(int button)
	{
		return false;
	}

	[NativeThrows]
	public static bool GetMouseButtonUp(int button)
	{
		return false;
	}

	[NativeThrows]
	public static Touch GetTouch(int index)
	{
		return default;
	}

	public static bool GetKey(KeyCode key)
	{
		return false;
	}

	public static bool GetKey(string name)
	{
		return false;
	}

	public static bool GetKeyUp(KeyCode key)
	{
		return false;
	}

	public static bool GetKeyUp(string name)
	{
		return false;
	}

	public static bool GetKeyDown(KeyCode key)
	{
		return false;
	}

	public static bool GetKeyDown(string name)
	{
		return false;
	}

	internal static bool CheckDisabled()
	{
		return false;
	}

	private static void GetTouch_Injected(int index, out Touch ret)
	{
		ret = default;
	}

	[SpecialName]
	private static void get_mousePosition_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private static void get_mouseScrollDelta_Injected(out Vector2 ret)
	{
		ret = default;
	}
}

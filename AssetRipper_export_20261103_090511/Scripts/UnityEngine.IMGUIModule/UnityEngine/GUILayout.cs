namespace UnityEngine;

public class GUILayout
{
	public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
	}

	public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return false;
	}

	private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return false;
	}

	public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return null;
	}

	private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options)
	{
		return null;
	}

	public static void Space(float pixels)
	{
	}

	public static void FlexibleSpace()
	{
	}

	public static void BeginHorizontal(params GUILayoutOption[] options)
	{
	}

	public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
	{
	}

	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
	}

	public static void EndHorizontal()
	{
	}

	public static void BeginArea(Rect screenRect)
	{
	}

	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
	{
	}

	public static void EndArea()
	{
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
	{
		return default;
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
	{
		return default;
	}

	public static void EndScrollView()
	{
	}

	internal static void EndScrollView(bool handleScrollWheel)
	{
	}

	public static GUILayoutOption Width(float width)
	{
		return null;
	}

	public static GUILayoutOption MaxWidth(float maxWidth)
	{
		return null;
	}

	public static GUILayoutOption Height(float height)
	{
		return null;
	}

	public static GUILayoutOption MaxHeight(float maxHeight)
	{
		return null;
	}

	public static GUILayoutOption ExpandWidth(bool expand)
	{
		return null;
	}

	public static GUILayoutOption ExpandHeight(bool expand)
	{
		return null;
	}
}

using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace kairo.unity.ui;

public class Font
{
	public const int SIZE_SMALL = 0;

	public const int SIZE_MEDIUM = 1;

	public const int SIZE_LARGE = 2;

	public const int STYLE_PLAIN = 0;

	public const int STYLE_BOLD = 1;

	public const int STYLE_ITALIC = 2;

	public const int FACE_SYSTEM = 0;

	public const int FACE_MONOSPACE = 1;

	public const int FACE_PROPORTIONAL = 2;

	private static readonly int[] HEIGHT;

	private static readonly int[] WIDTH;

	internal int size_;

	private static readonly FontStyle[] STYLE;

	internal int style_;

	internal int face_;

	internal int usedSize_;

	internal bool usePreset_;

	internal int guiStyleId_;

	internal FontStyle guiFontStyle_;

	internal int guiFontSize_;

	internal Color guiTextColor_;

	internal float scale_;

	private static UnityEngine.Font defaultGUIFont_;

	private static string defaultGUIFontLanguage_;

	private static List<string> invalidFontNames_;

	private static bool localizeSettingLock_;

	private static List<bool> localizeSettingStack_;

	private static int localizeSettingCount_;

	internal static int requestFontScale_;

	internal static float requestFontOffset_;

	internal int fontScale_;

	internal static bool LT_DISABLE_TEXTLAYOUT;

	internal bool useFontTexture_;

	private static List<GUIStyle> guiStyleTable_;

	internal static bool FONT_CANCEL;

	private Font _set_param;

	private Graphics Draw_param1;

	private string Draw_param2;

	private float Draw_param3;

	private float Draw_param4;

	private int _setSize_param1;

	private bool _setSize_param2;

	private int _setStyle_param1;

	private TextFormat StringWidth_param1;

	private string StringWidth_param2;

	private TextFormat StringWidthF_param1;

	private string StringWidthF_param2;

	private static Dictionary<string, string> replaceCache_;

	private static GUIContent guiContents_;

	private Font _copy_param;

	private float _adjustFontSize_param;

	private static Dictionary<UnityEngine.Font, bool> invalidFontCache_;

	public Font()
	{
	}

	internal void Init()
	{
	}

	private void _init()
	{
	}

	public Font(Font font)
	{
	}

	public void Set(Font font)
	{
	}

	private void _set(Font font)
	{
	}

	public UnityEngine.Font GetFont()
	{
		return null;
	}

	public void Draw(Graphics g, string text, float x, float y)
	{
	}

	private void _draw(Graphics g, string text, float x, float y)
	{
	}

	public int GetSize()
	{
		return 0;
	}

	public void SetSize(int size, bool usePreset = true)
	{
	}

	private void _setSize(int size, bool usePreset = true)
	{
	}

	public int GetStyle()
	{
		return 0;
	}

	public FontStyle GetFontStyle()
	{
		return FontStyle.Normal;
	}

	public void SetStyle(int style)
	{
	}

	private void _setStyle(int style)
	{
	}

	public int GetFace()
	{
		return 0;
	}

	public void SetFace(int face)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public float GetWidth()
	{
		return 0f;
	}

	public int StringWidth(string text)
	{
		return 0;
	}

	public int StringWidth(TextFormat lf, string text)
	{
		return 0;
	}

	private int _stringWidth(TextFormat lf, string text)
	{
		return 0;
	}

	public float StringWidthF(string text)
	{
		return 0f;
	}

	public float StringWidthF(TextFormat lf, string text)
	{
		return 0f;
	}

	private float _stringWidthF(TextFormat lf, string text)
	{
		return 0f;
	}

	public int StringWidth2(string text)
	{
		return 0;
	}

	public int StringWidth2(TextFormat lf, string text)
	{
		return 0;
	}

	private int _stringWidth2(TextFormat lf, string text)
	{
		return 0;
	}

	public float StringWidthF2(string text)
	{
		return 0f;
	}

	public float StringWidthF2(TextFormat lf, string text)
	{
		return 0f;
	}

	private float _stringWidthF2(TextFormat lf, string text)
	{
		return 0f;
	}

	public void Dispose()
	{
	}

	public void Copy(Font font)
	{
	}

	private void _copy(Font font)
	{
	}

	public bool Equals(Font font)
	{
		return false;
	}

	public void AdjustFontSize(float scaleRatio)
	{
	}

	private void _adjustFontSize(float scaleRatio)
	{
	}

	internal bool IsNeedLocalizeScale()
	{
		return false;
	}

	internal int GetLocalizeScale()
	{
		return 0;
	}

	internal static void LockLocalizeSetting()
	{
	}

	internal static void UnlockLocalizeSetting()
	{
	}

	public static void PushLocalizeSetting(bool scale)
	{
	}

	public static void PopLocalizeSetting()
	{
	}

	internal static void ClearLocalizeSettings()
	{
	}

	internal static void SetScale(int scale)
	{
	}

	internal static void SetOffset(float offset)
	{
	}

	private void UpdateFontScale()
	{
	}

	private static UnityEngine.Font GetDefaultGUIFont()
	{
		return null;
	}

	private static UnityEngine.Font _getDefaultGUIFont()
	{
		return null;
	}

	private UnityEngine.Font UpdateGUIFont()
	{
		return null;
	}

	private UnityEngine.Font _updateGUIFont()
	{
		return null;
	}

	private static string GetFontKey(UnityEngine.Font font)
	{
		return null;
	}

	public float GetOffset()
	{
		return 0f;
	}

	private static object RunOnUiThread(IApplication.UIMethod start)
	{
		return null;
	}

	private static void RunOnUiThread(ThreadStart start)
	{
	}

	internal static int GetFontTextureScale()
	{
		return 0;
	}

	internal static int GetGUIStyleId(UnityEngine.Font font)
	{
		return 0;
	}

	internal static GUIStyle GetGUIStyle(UnityEngine.Font font)
	{
		return null;
	}

	internal static GUIStyle GetGUIStyle(int guiStyleId)
	{
		return null;
	}

	internal GUIStyle GetGUIStyle()
	{
		return null;
	}
}

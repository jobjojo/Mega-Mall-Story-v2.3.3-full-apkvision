using System;
using System.Collections.Generic;
using kairo.unity.type;

namespace kairo.unity.ui;

public class TextLayout
{
	internal class TextBlock
	{
		internal class TextRuby
		{
			public string text_;

			public float x_;

			public float y_;
		}

		protected TextLayout parent_;

		public Font font_;

		public int color_;

		public string text_;

		public float x_;

		public float y_;

		public int blink_;

		public int blinkCnt_;

		public float width_;

		public bool isButton_;

		public bool isPictograph_;

		public string[] pictographParam_;

		internal int start_;

		internal int length_;

		internal int borderColor_;

		internal bool isBold_;

		internal bool isEmphasis_;

		internal List<TextRuby> textRubies_;

		private static Dictionary<string, bool> languageCheckCache_;

		public TextBlock(TextLayout parent, Font font, int color, float x, float y, int blink)
		{
		}

		public int Draw(Graphics g, float x, float y, float boxY, float boxH, int len)
		{
			return 0;
		}

		public int StringWidth(int len, out int width)
		{
			width = default;
			return 0;
		}

		private void DrawStringBold(Graphics g, Font font, string text, float x, float y, int color)
		{
		}

		public void Dispose()
		{
		}
	}

	private class MacroRuby
	{
		public string src_;

		public string ruby_;

		public string[] rubyAry_;

		public int index_;
	}

	private class Cache
	{
		public string Text;

		public int HashCode;

		public float Width;

		public float Height;

		public int Color;

		public int LineSpace;

		public int Anchor;

		public int Font;

		public float ScaleRatio;

		public int LastAccess;

		public TextLayout Layout;

		public bool IsEmpty => false;

		public void Set(string text, int hashCode, float width, float height, int color, int lineSpace, int anchor, int font, float scaleRatio)
		{
		}

		public void Dispose()
		{
		}
	}

	private class Ruby
	{
		public string word_;

		public char[] charas_;

		public string[] ruby_;
	}

	internal TextBlock[] textBlocks_;

	private static Dictionary<string, Pictograph> pictographList_;

	private Font font_;

	private int color_;

	private string text_;

	private int textHashCode_;

	private int length_;

	private float width_;

	private float height_;

	private int pos_;

	private int speed_;

	private long beginTime_;

	private int timeOffset_;

	private long lastAppFrame_;

	private int lineSpace_;

	private int anchor_;

	private float textWidth_;

	private bool format_;

	private int frame_;

	private int draw_;

	private bool autoScale_;

	private float scaleRatio_;

	private int textCheckSize_;

	private bool multiLine_;

	private bool localizeFontEnable_;

	private bool adjustFontSize_;

	public bool overArea_;

	private int requestFontSize_;

	private bool rubyEnable_;

	private static bool renderRectVisible_;

	private static bool pictographVisible_;

	private static bool buttonVisible_;

	private static Dictionary<string, string> replaceTable_;

	private List<MacroRuby> macroRubies_;

	private static readonly string[] TAG;

	private static readonly int DEFAULT_CACHE_SIZE;

	private static Cache[] cache_;

	private static Dictionary<char, List<Ruby>> rubyTable_;

	private Font fontBuf_;

	private static Font fontBuf2_;

	static TextLayout()
	{
	}

	[Obsolete("互換性のため残してますが、使う必要ありません。キャッシュは自動的に拡張されます。")]
	public static void SetCacheSize(int size)
	{
	}

	public static void ClearCache()
	{
	}

	public TextLayout()
	{
	}

	public TextLayout(bool autoScale, bool localizeFontEnable = true)
	{
	}

	public void Init()
	{
	}

	public void SetText(string text)
	{
	}

	private void SetText(string text, int hashCode)
	{
	}

	public string GetText()
	{
		return null;
	}

	private void _makeTextBlocks()
	{
	}

	private void _makeTextRubies()
	{
	}

	private Ruby CheckRuby(int textBlockIndex, int charaIndex)
	{
		return null;
	}

	public int GetHeight()
	{
		return 0;
	}

	public int GetNextHeight()
	{
		return 0;
	}

	public void Draw(Graphics g, float dx, float dy)
	{
	}

	public void Draw(Graphics g, float dx, float dy, int scrollV)
	{
	}

	public int StringWidth()
	{
		return 0;
	}

	public void Frame()
	{
	}

	public void Reset()
	{
	}

	public void SetSpeed(int speed)
	{
	}

	public int GetSpeed()
	{
		return 0;
	}

	public void SetColor(int color)
	{
	}

	public int GetColor()
	{
		return 0;
	}

	public void SetFontSize(int size)
	{
	}

	public void SetFont(Font font)
	{
	}

	public Font GetFont()
	{
		return null;
	}

	public void SetAnchor(int anchor)
	{
	}

	public int GetAnchor()
	{
		return 0;
	}

	public void Flush()
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void SetSize(float w, float h)
	{
	}

	public void SetLineSpace(int lineSpace)
	{
	}

	public void SetTextFormat(bool enable)
	{
	}

	public void Dispose()
	{
	}

	public static RectF Draw(Graphics g, string text, float x, float y, int color, int anchor = 0, bool ruby = false)
	{
		return default;
	}

	public static RectF Draw(TextFormat lf, Graphics g, string text, float x, float y, int color, int anchor = 0, bool ruby = false)
	{
		return default;
	}

	public static RectF Draw(Graphics g, string text, float x, float y, float w, float h, int color, int lineSpace, int anchor = 0, bool ruby = false)
	{
		return default;
	}

	public static RectF Draw(TextFormat lf, Graphics g, string text, float x, float y, float w, float h, int color, int lineSpace, int anchor = 0, bool ruby = false)
	{
		return default;
	}

	internal static int StringWidth(Font font, string text)
	{
		return 0;
	}

	internal static int StringWidth(TextFormat lf, Font font, string text)
	{
		return 0;
	}

	internal static float StringWidthF(Font font, string text)
	{
		return 0f;
	}

	internal static float StringWidthF(TextFormat lf, Font font, string text)
	{
		return 0f;
	}

	private static Cache SearchCache(string text, int hashCode, float width, float height, int color, int lineSpace, int anchor, int font, float scaleRatio)
	{
		return null;
	}

	private static Cache AddCache(string text, int hashCode, float width, float height, int color, int lineSpace, int anchor, int font, float scaleRatio, TextLayout lay)
	{
		return null;
	}

	public int GetTextWidth()
	{
		return 0;
	}

	public float GetTextWidthF()
	{
		return 0f;
	}

	public void SetGraphicsScale(float scaleRatio)
	{
	}

	public int GetRenderingFontSize()
	{
		return 0;
	}

	public int GetRenderingRequestFontSize()
	{
		return 0;
	}

	public int GetRenderingWidth()
	{
		return 0;
	}

	public int GetRenderingHeight()
	{
		return 0;
	}

	public float GetRenderingWidthF()
	{
		return 0f;
	}

	public float GetRenderingHeightF()
	{
		return 0f;
	}

	public void SetTextCheckSize(int size = -1)
	{
	}

	public static void SetRenderRectVisible(bool visible)
	{
	}

	public static bool GetRenderRectVisible()
	{
		return false;
	}

	public static Pictograph AddPictograph(string key, Seb seb, int frame = -1, int wait = 1, int x = 0, int y = 0, int margin = 0, int scale = 100, bool enableColor = false)
	{
		return null;
	}

	public static Pictograph GetPictograph(string key)
	{
		return null;
	}

	public static void RemovePictograph(string key)
	{
	}

	public static void ClearPictographs()
	{
	}

	public static void SetPictographVisible(bool visible)
	{
	}

	public static bool IsPictographVisible()
	{
		return false;
	}

	public static void SetButtonVisible(bool visible)
	{
	}

	public static bool IsButtonVisible()
	{
		return false;
	}

	public void SetLocalizeFontEnable(bool enable)
	{
	}

	public static string RemoveTag(string text)
	{
		return null;
	}

	public static string RemovePositionTag(string text)
	{
		return null;
	}

	public static string RemoveColorTag(string text)
	{
		return null;
	}

	public int GetLineHeight()
	{
		return 0;
	}

	public int GetLineSpace()
	{
		return 0;
	}

	public int GetLineStep()
	{
		return 0;
	}

	public static void SetReplaceWord(string from, string to)
	{
	}

	public static string Replace(string text, string args = null)
	{
		return null;
	}

	public void AdjustSize()
	{
	}

	public static void AddRuby(string word, string ruby)
	{
	}

	public static void AddRuby(string source)
	{
	}

	public static void ClearRuby()
	{
	}

	private static int GetRubyFontScale()
	{
		return 0;
	}

	public void SetRubyEnable(bool enable)
	{
	}

	private static int GetEmphasisFontScale()
	{
		return 0;
	}
}

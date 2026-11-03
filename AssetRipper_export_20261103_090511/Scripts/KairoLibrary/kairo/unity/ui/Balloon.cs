using System.Collections.Generic;
using UnityEngine;
using kairo.unity.graphics;
using kairo.unity.type;

namespace kairo.unity.ui;

public class Balloon
{
	public enum Colors
	{
		Blue = -15972869,
		Red = -51144,
		Black = -14803426,
		Shadow = -5460820
	}

	public delegate void BalloonRender(Graphics g, float y, RectangleF left, RectangleF right);

	public delegate void BalloonRender2(Graphics g, float y, RectangleF left, RectangleF right, int frame);

	public const int COLOR_BLUE = -15972869;

	public const int COLOR_RED = -51144;

	public const int COLOR_BLACK = -14803426;

	public const int COLOR_SHADOW = -5460820;

	internal float scale2_;

	private string text_;

	private bool isTail_;

	private int leftSpace_;

	private int rightSpace_;

	private int topSpace_;

	private int bottomSpace_;

	private bool isClip_;

	private int shadowColor_;

	private bool isShadow_;

	private Seb leftSpaceSeb_;

	private int leftSpaceSebFrame_;

	private Seb rightSpaceSeb_;

	private int rightSpaceSebFrame_;

	private BalloonRender render_;

	private BalloonRender2 render2_;

	private List<Rectangle> maskList_;

	private RectangleF clip_;

	private RectangleF leftSpaceRect_;

	private RectangleF rightSpaceRect_;

	private static RectangleF Draw_tmp;

	private static float borderLeft_;

	private static float borderRight_;

	private static float borderTop_;

	private static float borderBottom_;

	private Font fontBuf_;

	private static kairo.unity.type.Rect[] balloonTemplateList_;

	private static Image balloonTemplateImage_;

	private static int balloonTemplateHeight_;

	private static Seb balloonTemplateSeb_;

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int TextColor { get; set; }

	public float Scale { get; set; }

	public Seb Seb { get; set; }

	public int FontSize { get; set; }

	public int WidthMax { get; set; }

	public int Frame { get; set; }

	public Balloon(Balloon balloon)
	{
	}

	public Balloon(string text = "", int color = -15972869)
	{
	}

	public void Init(string text, int color = -15972869)
	{
	}

	public void Init(Balloon from)
	{
	}

	internal void AddMask(int x, int y, int width, int height)
	{
	}

	internal void SetClip(int x, int y, int width, int height)
	{
	}

	public void SetSpace(int left, int right, int top = 0, int bottom = 0, BalloonRender render = null)
	{
	}

	public void SetSpace(int left, int right, int top, int bottom, BalloonRender2 render)
	{
	}

	public void SetSpace(Seb leftSeb, int leftFrame, Seb rightSeb, int rightFrame, int top = 0, int bottom = 0, BalloonRender render = null)
	{
	}

	public void SetSpace(Seb leftSeb, int leftFrame, Seb rightSeb, int rightFrame, int top, int bottom, BalloonRender2 render)
	{
	}

	public void SetTail(bool show)
	{
	}

	public void SetShadow(bool show, int color = -5460820)
	{
	}

	public void Draw(Graphics g, float x, float y)
	{
	}

	public void Draw(Graphics g, float x, float y, Matrix4x4 matrix)
	{
	}

	private static void DrawRepeat(Graphics g, float x, float y, int width, int height, Seb seb, int frame)
	{
	}

	private static float Clamp(float val, float min, float max)
	{
		return 0f;
	}

	private static float ClampMin(float val, float min)
	{
		return 0f;
	}

	private static float ClampMax(float val, float max)
	{
		return 0f;
	}

	public static void SetBorder(float left = float.NaN, float right = float.NaN, float top = float.NaN, float bottom = float.NaN)
	{
	}

	internal static void MakeTemplate()
	{
	}

	private static void DrawTemplate(Graphics g, int x, int y, int width, int height)
	{
	}

	internal static bool HasTemplate()
	{
		return false;
	}
}

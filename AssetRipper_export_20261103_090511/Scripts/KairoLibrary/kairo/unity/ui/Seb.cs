using System;
using System.Collections.Generic;
using java.io;
using kairo.unity.type;

namespace kairo.unity.ui;

public class Seb
{
	private class WorkStaticValue
	{
		internal int[][][] works_;

		internal int[][][] result_;

		internal int[] getBoundingRectI_result;

		internal short[] getBoundingRect_result;

		internal int[] getSprite_sp1;

		internal int[] getSprite_sp2;
	}

	private class WorkValue
	{
		internal int[][] works_;

		internal int[][] result_;

		internal Sprite[] result2_;
	}

	public enum WrapModes
	{
		Repeat = 0,
		Magnify = 1,
		Scale = 2,
		Ratio = 3,
		Clamp = 4
	}

	public delegate float DepthDelegate(float x, float y);

	public const int SP_FRAME_NO = 0;

	public const int SP_TEX_ID = 1;

	public const int SP_U = 2;

	public const int SP_V = 3;

	public const int SP_W = 4;

	public const int SP_H = 5;

	public const int SP_TRANS_X = 6;

	public const int SP_TRANS_Y = 7;

	public const int SP_REVERS_U = 8;

	public const int SP_REVERS_V = 9;

	public const int SP_BLEND = 10;

	public const int SP_COLOR = 11;

	public const int SP_END = 12;

	public const int TEXID_NONE = -1;

	public const int TEXID_FRECT = -2;

	public const int TEXID_RECT = -3;

	public const int TEXID_LINE = -4;

	public const int TEXID_HIDELINE = -8;

	public const int TEXID_HIDERECT = -9;

	private string name_;

	private int currentFrame_;

	private int maxFrame_;

	private int[] layerHeads_;

	private short[] spriteFrames_;

	private const int SPBUF_TEX = 0;

	private const int SPBUF_X = 1;

	private const int SPBUF_Y = 2;

	private const int SPBUF_U = 3;

	private const int SPBUF_V = 4;

	private const int SPBUF_W = 5;

	private const int SPBUF_H = 6;

	private const int SPBUF_FLAG = 7;

	private const int SPBUF_END = 8;

	private sbyte[] spriteBuffer_;

	private const int SPBUFEX_TEX = 0;

	private const int SPBUFEX_X = 1;

	private const int SPBUFEX_Y = 2;

	private const int SPBUFEX_U = 3;

	private const int SPBUFEX_V = 4;

	private const int SPBUFEX_W = 5;

	private const int SPBUFEX_H = 6;

	private const int SPBUFEX_END = 7;

	private short[] spritesBufferEx_;

	private sbyte flip_;

	private int[][][] cache_;

	private long boundingRect_;

	private sbyte[] boundingRects_;

	private short[] boundingRectsEx_;

	private Rect[] pixelBoundingRects_;

	private Rect pixelBoundingRect_;

	private DepthInfo[][] depthInfoList_;

	private float[] offset_;

	private static int defaultDepth_;

	internal bool isThisFrameRedner_;

	internal int lastRenderFrame_;

	internal static List<Seb> thisFrameRenderSebs_;

	internal static int thisFrameRenderSebCount_;

	[ThreadStatic]
	private static WorkStaticValue threadLocalStatic_;

	[ThreadStatic]
	private WorkValue threadLocal_;

	public static DepthDelegate DepthMethod;

	public ResourceManager Resource { get; internal set; }

	public static bool AutoAnimation { get; set; }

	public Image[] img => null;

	public Sprite[] this[int frameNo] => null;

	public Sprite this[int frameNo, int lineNo] => default;

	public int Length => 0;

	internal bool Flip { get; set; }

	internal Image GetImage(int texId)
	{
		return null;
	}

	private static WorkStaticValue GetWorkStaticValue()
	{
		return null;
	}

	private WorkValue GetWorkValue()
	{
		return null;
	}

	public static void SetClip(int x, int y, int w, int h)
	{
	}

	public static int[] GetClip()
	{
		return null;
	}

	public static void ClearClip()
	{
	}

	public Seb(InputStream stream)
	{
	}

	public Seb(byte[] data)
	{
	}

	public Seb(Seb seb)
	{
	}

	public void Dispose()
	{
	}

	private void _load(byte[] data)
	{
	}

	private void _load(InputStream stream)
	{
	}

	public int[] GetBoundingRect()
	{
		return null;
	}

	public Rect GetBRect()
	{
		return default;
	}

	public short[] GetBoundingRect(int frame)
	{
		return null;
	}

	public Rect GetBRect(int frame)
	{
		return default;
	}

	public Rect GetBRect(int frame, int layer)
	{
		return default;
	}

	public Rect GetPixelRect(int frame)
	{
		return default;
	}

	public Rect GetPixelRect()
	{
		return default;
	}

	public int GetCurFrame()
	{
		return 0;
	}

	public void SetCurFrame(int frame)
	{
	}

	public int GetMaxFrame()
	{
		return 0;
	}

	public void Frame()
	{
	}

	public int[][] GetSprites(int frameNo)
	{
		return null;
	}

	public Sprite[] Get(int frameNo)
	{
		return null;
	}

	private int[][] GetSpritesLocal(int frameNo)
	{
		return null;
	}

	public Sprite Get(int frameNo, int lineNo)
	{
		return default;
	}

	public int[] GetSprite(int frameNo, int lineNo)
	{
		return null;
	}

	private int[] GetSpriteLocal(int frameNo, int lineNo)
	{
		return null;
	}

	private int[] ConvBufferToSprite(int index, int[] sprite, bool flip)
	{
		return null;
	}

	public void Render(Graphics g, float x, float y, int frame)
	{
	}

	public void RenderLayer(Graphics g, float x, float y, int frame, int layer)
	{
	}

	public void Render(Graphics g, float x, float y, float depth, int frame)
	{
	}

	public void RenderLayer(Graphics g, float x, float y, float depth, int frame, int layer)
	{
	}

	public void Render(Graphics g, PointF pos, int frame)
	{
	}

	public void RenderLayer(Graphics g, PointF pos, int frame, int layer)
	{
	}

	public void Render(Graphics g, PointF pos, float depth, int frame)
	{
	}

	public void RenderLayer(Graphics g, PointF pos, float depth, int frame, int layer)
	{
	}

	public void Render(Graphics g, PointF pos, float depth, int frame, DepthInfo di)
	{
	}

	public void RenderAnchor(Graphics g, float x, float y, float depth, int anchor)
	{
	}

	public void RenderAnchor(Graphics g, PointF pos, float depth, int anchor)
	{
	}

	public void RenderAnchor(Graphics g, float x, float y, float depth, int frame, int anchor)
	{
	}

	public void RenderAnchor(Graphics g, PointF pos, float depth, int frame, int anchor)
	{
	}

	public void RenderAnchor(Graphics g, float x, float y, float depth, int frame, int layer, int anchor)
	{
	}

	public void RenderAnchor(Graphics g, PointF pos, float depth, int frame, int layer, int anchor)
	{
	}

	public void DrawFrame(Graphics g, float x, float y, Image[] img, int frame, int lineNo = -1)
	{
	}

	public void DrawFrame(Graphics g, float x, float y, Image[] img, Dictionary<int, Image> customImages, int frame, int lineNo = -1)
	{
	}

	public void Draw(Graphics g, float x, float y, Image[] img, int lineNo = -1)
	{
	}

	public void Draw(Graphics g, float x, float y, Image[] img, Dictionary<int, Image> customImages, int lineNo = -1)
	{
	}

	public void Draw(Graphics g, float x, float y)
	{
	}

	public void Draw(Graphics g, float x, float y, int frame, int layer = -1)
	{
	}

	public void DrawAnchor(Graphics g, float x, float y, int anchor)
	{
	}

	public void DrawAnchor(Graphics g, float x, float y, int frame, int anchor)
	{
	}

	public void DrawAnchor(Graphics g, float x, float y, int frame, int layer, int anchor)
	{
	}

	public void DrawRatio(Graphics g, float x, float y, float widthRatio, float heightRatio, int frame)
	{
	}

	public void DrawRatioLayer(Graphics g, float x, float y, float widthRatio, float heightRatio, int frame, int layer)
	{
	}

	public void DrawRepeat(Graphics g, float x, float y, int width, int height, int frame)
	{
	}

	public void DrawRepeatLayer(Graphics g, float x, float y, int width, int height, int frame, int layer)
	{
	}

	public void DrawRect(Graphics g, float x, float y, float width, float height, int frame, WrapModes horizontalWrap, WrapModes verticalWrap)
	{
	}

	public void DrawRectLayer(Graphics g, float x, float y, float width, float height, int frame, int layer, WrapModes horizontalWrap, WrapModes verticalWrap)
	{
	}

	public void DrawHorizontal(Graphics g, float x, float y, int width, int head = 0)
	{
	}

	public void DrawHorizontalRect(Graphics g, float x, float y, int width, int height, int head = 0)
	{
	}

	public void DrawHorizontalLayer(Graphics g, float x, float y, int width, int frame, int headLayer)
	{
	}

	public void DrawHorizontalRectLayer(Graphics g, float x, float y, int width, int height, int frame, int headLayer)
	{
	}

	public void DrawVertical(Graphics g, float x, float y, int height, int head = 0)
	{
	}

	public void DrawVerticalRect(Graphics g, float x, float y, int width, int height, int head = 0)
	{
	}

	public void DrawVerticalLayer(Graphics g, float x, float y, int height, int frame, int headLayer)
	{
	}

	public void DrawVerticalRectLayer(Graphics g, float x, float y, int width, int height, int frame, int headLayer)
	{
	}

	public void DrawRect(Graphics g, float x, float y, int width, int height, int head = 0)
	{
	}

	public void DrawRectLayer(Graphics g, float x, float y, int width, int height, int frame, int headLayer = 0)
	{
	}

	protected float[] GetAnchorPosition(float x, float y, int frame, int anchor)
	{
		return null;
	}

	protected float[] GetAnchorPositionF(float x, float y, int frame, int anchor)
	{
		return null;
	}

	private void _draw(Graphics g, float x, float y, Image[] img, int frame, int lineNo)
	{
	}

	private void _draw(Graphics g, float x, float y, Image[] img, Dictionary<int, Image> customImages, int frame, int lineNo)
	{
	}

	public void Draw(Graphics g, float x, float y, Image[] img, int[] sp)
	{
	}

	public void Draw(Graphics g, float x, float y, Image[] img, Dictionary<int, Image> customImages, int[] sp)
	{
	}

	public int GetLayersNum()
	{
		return 0;
	}

	public void SetName(string name)
	{
	}

	public string GetName()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public ResourceManager GetManager()
	{
		return null;
	}

	public void Reverse(bool u, bool v)
	{
	}

	public void SetCacheSize(int size)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool IsFlipHorizontal()
	{
		return false;
	}

	public bool IsFlipVertical()
	{
		return false;
	}

	public static void SetDefaultDepth(int depth)
	{
	}

	public DepthInfo[] GetDepthInfo(int frame, int scale)
	{
		return null;
	}

	public DepthInfo[] GetDepthInfo(int frame, int scale, int defaultDepth)
	{
		return null;
	}

	public DepthInfo[] GetDepthInfo(int frame, int scale, int defaultDepth, int ignoreDepth)
	{
		return null;
	}

	public void SetOffset(float x, float y)
	{
	}

	public void ClearOffset()
	{
	}

	public bool CheckEmpty(int frame)
	{
		return false;
	}

	public static bool IsFlipFrame(int frame)
	{
		return false;
	}

	public static int GetRemoveFlipFrame(int frame)
	{
		return 0;
	}

	public static int GetFlipFrame(int frame, bool flip)
	{
		return 0;
	}

	private bool PushThisFrameRender()
	{
		return false;
	}

	internal static void ResetThisFrameRender()
	{
	}

	internal static void ThisFrameRenderAnimation()
	{
	}

	public int GetPixel(int frame = 0, int layer = 0, int x = 0, int y = 0)
	{
		return 0;
	}

	private Image GetImage(Image[] imgs, int texId)
	{
		return null;
	}

	public int GetTextureColor(int frame, int layer = 0)
	{
		return 0;
	}
}

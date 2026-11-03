using System;
using System.Collections.Generic;
using UnityEngine;
using kairo.unity.graphics;
using kairo.unity.type;

namespace kairo.unity.ui;

public class Graphics
{
	private class GLText
	{
		public UnityEngine.Rect Position;

		public string Text;

		public UnityEngine.Font Font;

		public int Size;

		public FontStyle Style;

		public UnityEngine.Color Color;

		public Rectangle Clip;

		public bool IsClip;

		public bool Log;

		public void Init(UnityEngine.Rect pos, string text, GUIStyle style, Rectangle clip)
		{
		}
	}

	private class LocalCoordinate
	{
		public int begin_;

		public int index_;
	}

	public enum Depth
	{
		Front = 0,
		Back = 1
	}

	private class GravityPoint
	{
		public PointF Point;

		public PointF To;
	}

	private class StackState
	{
		public int Clip;

		public int Font;

		public int RenderMode;

		public int Matrix;

		public int BlendMode;

		public int ClipEnable;

		public int Origin;

		public int RenderQueue;

		public int ImageClip;

		public int Culling;

		public float ImageExpand;
	}

	public struct ARGB
	{
		public int A { get; set; }

		public int R { get; set; }

		public int G { get; set; }

		public int B { get; set; }
	}

	protected class RenderPass
	{
		private Graphics g_;

		private static Dictionary<int, UnityEngine.Color[]> ResultColors;

		private static UnityEngine.Color[] DefaultColors;

		private UnityEngine.Color[] OneColors;

		public int RenderOperator;

		public int RenderSrcRatio;

		public int RenderDstRatio;

		public UnityEngine.Color[] Colors;

		public kairo.unity.graphics.Material Material;

		public int opaqueTransOrder_;

		private bool pushBlendColor_;

		private int colorRatio_;

		private int alphaRatio_;

		private UnityEngine.Color[] resultColors_;

		public void Init(Graphics g, kairo.unity.graphics.Material material, UnityEngine.Color color)
		{
		}

		public void Init(Graphics g, kairo.unity.graphics.Material material, params UnityEngine.Color[] colors)
		{
		}

		public void Init(Graphics g, int renderOperator, int renderSrcRatio, int renderDstRatio, int colorRatio, int alphaRatio, UnityEngine.Color color)
		{
		}

		public void Init(Graphics g, int renderOperator, int renderSrcRatio, int renderDstRatio, int colorRatio, int alphaRatio, params UnityEngine.Color[] colors)
		{
		}

		public void Copy(RenderPass from)
		{
		}

		private void _begin()
		{
		}

		public UnityEngine.Color[] Begin()
		{
			return null;
		}

		public UnityEngine.Color[] BeginShape()
		{
			return null;
		}

		public void End()
		{
		}
	}

	private class RenderCache
	{
		public Image Image;

		public int AlphaType;

		public float[] Source;

		public RectangleF SourceRect;

		public bool Valid;

		public MeshBuilder[] Meshes;

		public UnityEngine.Color[] Colors;

		public int Count;

		public bool Empty;

		public void Reset()
		{
		}
	}

	private class FontTexture
	{
		public string Text;

		public Image Image;

		public UnityEngine.Color Color;

		public int Size;

		public int LastFrame;

		public bool Bold;

		public FontTexture(string text, Image image, UnityEngine.Color color, int size)
		{
		}

		public void Dispose()
		{
		}
	}

	private class GrayscaleImage
	{
		public Image Source;

		public Image Image;

		public int X;

		public int Y;

		public int Width;

		public int Height;
	}

	internal class StretchArea
	{
		public int x;

		public int width;

		public int widthMax;

		public float scale;

		public StretchArea(int x, int width, int widthMax)
		{
		}
	}

	public const int AQUA = -16711681;

	public const int BLACK = -16777216;

	public const int BLUE = -16776961;

	public const int FUCHSIA = -65281;

	public const int GRAY = -8355712;

	public const int GREEN = -16744448;

	public const int LIME = -16711936;

	public const int MAROON = -8388608;

	public const int NAVY = -16777088;

	public const int OLIVE = -8355840;

	public const int PURPLE = -8388480;

	public const int RED = -65536;

	public const int SILVER = -4144960;

	public const int TEAL = -16744320;

	public const int WHITE = -1;

	public const int YELLOW = -256;

	public const int FLIP_NONE = 0;

	public const int FLIP_HORIZONTAL = 1;

	public const int FLIP_VERTICAL = 2;

	public const int FLIP_ROTATE = 3;

	public const int FLIP_ROTATE_LEFT = 4;

	public const int FLIP_ROTATE_RIGHT = 5;

	public const int ANCHOR_LEFT = 1;

	public const int ANCHOR_CENTER = 2;

	public const int ANCHOR_RIGHT = 4;

	public const int ANCHOR_TOP = 16;

	public const int ANCHOR_MIDDLE = 32;

	public const int ANCHOR_BOTTOM = 64;

	public const int OP_REPL = 0;

	public const int OP_ADD = 1;

	public const int OP_SUB = 2;

	public const int BLEND_NONE = 0;

	public const int BLEND_COLOR = 1;

	public const int BLEND_LIGHT = 2;

	public const int BLEND_GRAYSCALE = 3;

	protected static GUIStyle defaultGuiStyle_;

	private Canvas canvas_;

	internal Image render_;

	internal Camera camera_;

	protected int[] renderRect_;

	protected int[] renderRectOrigin_;

	protected int width_;

	protected int height_;

	protected int flipmode_;

	protected bool linearFilter_;

	protected float[] drawString_buf;

	protected GUIStyle guiStyle_;

	protected int color_;

	protected float scale_;

	protected int transX_;

	protected int transY_;

	protected Matrix backupMatrix_;

	protected Matrix mtxTmp_;

	private bool isGUI_;

	private int meshId_;

	internal MeshManager[] meshManList_;

	internal Offscreen offscreen_;

	public bool glRender_;

	public int glRenderCount_;

	public Matrix4x4 glMatrix_;

	private Mesh clearMesh_;

	internal int cameraDepth_;

	private static bool imageClipWarning_;

	private float[] imageClip_;

	private int imageClipCount_;

	private List<float[]> imageClipStack_;

	private bool beginLineGraph_;

	private bool beginFill_;

	private int beginFillCount_;

	private bool callDrawBitmap_;

	private RectF culling_;

	private int cullingCount_;

	private List<RectF> cullingStack_;

	private int glTextCount_;

	private List<GLText> glTextList_;

	protected int renderModeCount_;

	protected List<int[]> renderModeStack_;

	internal int renderOperator_;

	internal int renderSrcRatio_;

	internal int renderDstRatio_;

	internal bool renderIsReplace_;

	protected int blendModeCount_;

	protected List<int[]> blendModeStack_;

	internal int blendMode_;

	internal int blendRgba_;

	internal UnityEngine.Color blendColor_;

	protected int clipCount_;

	protected float[] clipRect_;

	protected List<float[]> clipStack_;

	protected Rectangle clipRegion_;

	protected Rectangle clipRegionGL_;

	protected bool isClipRegionGL;

	protected int clipEnableCount_;

	protected List<bool> clipEnableStack_;

	internal bool clipEnable_;

	internal bool setFigureClip_;

	internal bool useFigureClip_;

	internal bool isFigureClipMask_;

	private static int clipWarning_;

	protected Font font_;

	protected Font backupFont_;

	protected int fontCount_;

	protected List<Font> fontStack_;

	protected bool fontKeep_;

	protected string localizedFormat_;

	protected static Rectangle guiGroupRect_;

	protected static bool isGuiGroupRect_;

	internal static bool guiBeginGroup_;

	protected Matrix worldMatrix_;

	protected Matrix[][] localMatrixStack_;

	protected int localMatrixIndex_;

	protected Matrix screenMatrix_;

	protected int backupWorldMatrixCount_;

	protected List<Matrix> backupWorldMatrix_;

	protected int renderMatrixEnableCount_;

	protected List<bool> renderMatrixEnable_;

	private List<LocalCoordinate> localCoordinates_;

	protected int localCoordinateCount_;

	public kairo.unity.graphics.Material renderForceMaterial_;

	private static MaterialManager mateMan_;

	private static bool autoTextLayout_;

	[ThreadStatic]
	private static List<bool> autoTextLayoutStack_;

	[ThreadStatic]
	private static int autoTextLayoutCount_;

	protected float originX_;

	protected float originY_;

	protected int originCount_;

	protected List<float[]> originStack_;

	protected float depthOffset_;

	protected int depthOffsetCount_;

	protected List<float> depthOffsetStack_;

	protected float depthScale_;

	protected int renderQueue_;

	protected int renderQueueCount_;

	protected List<int> renderQueueStack_;

	internal static int DepthBits;

	internal static Graphics current_;

	private static int[] addIndiciesBuffer_;

	private static readonly string[] NUMBERS;

	internal static float outlineWidth_;

	internal static int outlineQuality_;

	private static int lineSpacing_;

	private const float DefaultImageExpand = 0.24f;

	private static float imageExpand_;

	private int imageExpandCount_;

	private List<float> imageExpandStack_;

	private List<GravityPoint> gravityPoints_;

	private float[] lastLinePoints_;

	internal bool fontScaleOffsetEnable_;

	protected int useFontTextureCount_;

	protected List<bool> useFontTextureStack_;

	private List<StackState> stackState_;

	private int stackStateCount_;

	private RenderCache renderCache_;

	private static bool renderCacheEnable_;

	private static List<FontTexture> fontTextureList_;

	private List<GrayscaleImage> grayscaleImages_;

	private static RectangleF SetClip_tmp;

	private static RectangleF ClipRect_tmp;

	private int[] getClip_tmp;

	private static float[][] drawArcPoints;

	private static UnityEngine.Color[] DrawPolygon_ColorBuffer;

	private static Vector3[] DrawPolygon_VertexBuffer;

	private static Vector2[] DrawPolygon_TexCoordBuffer;

	private static float[] DrawPolygon_Pt;

	private static float[] DrawImageRepeat_Verticies;

	private static float[] DrawImageRepeat_TexCoords;

	private static int[] DrawImageRepeat_Indicies;

	private static float[][] DrawImageArc_Buffer;

	private static float[] DrawImageArc_Verticies;

	private static float[] DrawImageArc_TexCoords;

	private static int[] DrawImageArc_Indicies;

	private static float[] DrawImageArc_Pivot;

	private static RectangleF drawImageRect_;

	private static RectangleF _drawBitmap_rc1;

	private static RectangleF _drawBitmap_rc2;

	private static RectangleF _drawBitmap_rc3;

	private static RectangleF _drawBitmap_rc4;

	private static Vector3[] _drawBitmap_vertices;

	private static UnityEngine.Color[] _drawBitmap_colros;

	private static RectangleF _drawBitmapSharpnessRect;

	private static Matrix _drawBitmapMatrix;

	private static Font _drawBitmapFont;

	private static RectangleF _drawBitmapGravity_;

	private static Vector3[] DrawLine_Vertices;

	private static Vector3[] DrawRect_Vertices1;

	private static Vector3[] DrawRect_Vertices2;

	private Font DrawText_tmp;

	private static RectangleF DrawString_tmp;

	private static float[] DrawString_tmp2;

	private bool FontTextureBold_;

	private static float[][] fillArcPoints_;

	private static Vector3[] FillRect_Vertices;

	private static float[] FillTriangle_tmp1;

	private static float[] FillTriangle_tmp2;

	private static float[] FillTriangle_tmp3;

	private static int[] getAnchorPosition_tmp;

	private static float[] getAnchorPositionF_tmp;

	private Font fontBuf_;

	private float[] getRenderRect_tmp;

	private static int[] getSharpnessInfo_result;

	private static UnityEngine.Color[] GetRenderPass_tmp;

	private static UnityEngine.Color[] GetRenderPass_color;

	private static RenderPass[][] GetRenderPass_Buffer;

	private float setDepthValue_;

	private static StretchArea stretchArea_;

	private bool beginReduceFont_;

	public static bool DefaultUseFontTexture { get; private set; }

	static Graphics()
	{
	}

	public Graphics()
	{
	}

	public Graphics(Image img, Camera camera = null)
	{
	}

	public Graphics(Offscreen offscreen, bool dynamic = true)
	{
	}

	internal void Init(object g, Image img, Camera camera = null)
	{
	}

	public object GetGraphics()
	{
		return null;
	}

	private bool CheckClip()
	{
		return false;
	}

	private void _setClip(float x, float y, float w, float h)
	{
	}

	public void PushClip()
	{
	}

	public void PushClip(float x, float y, float w, float h)
	{
	}

	public void PopClip()
	{
	}

	public void SetClip(float x, float y, float w, float h)
	{
	}

	public void ClipRect(float x, float y, float width, float height, bool push = true)
	{
	}

	public void ClearClip()
	{
	}

	public void SetFigureClipBegin(bool clear = true)
	{
	}

	public void SetFigureClipEnd()
	{
	}

	public void SetFigureClipMode(bool clip)
	{
	}

	public void ClearFigureClip()
	{
	}

	public int[] GetClip()
	{
		return null;
	}

	public virtual void ClearRect(float x, float y, float width, float height)
	{
	}

	public void Dispose(bool keep = false)
	{
	}

	public void DrawArc(float x, float y, float width, float height, float startAngle, float arcAngle, float lineWidth = 1f)
	{
	}

	public void DrawArc2(float x, float y, float width, float height, float startAngle, float arcAngle)
	{
	}

	public void DrawChars(char[] data, float x, float y, int off, int len)
	{
	}

	public void DrawPolygons(Image image, float[] verticies, float[] texCoords, int[] colors, int[] indicies, float[] pivot = null)
	{
	}

	public void SetMaterial(kairo.unity.graphics.Material material)
	{
	}

	private void DrawImageRepeat(Image image, float x, float y, int sx, int sy, int width, int height)
	{
	}

	public void DrawImage(Image image, float x, float y)
	{
	}

	public void DrawImage(Image image, float dx, float dy, int sx, int sy, int width, int height)
	{
	}

	public void DrawScaledImage(Image image, float dx, float dy, float width, float height, int sx, int sy, int swidth, int sheight)
	{
	}

	public void DrawImageArc(Image image, float x, float y, float startAngle, float arcAngle)
	{
	}

	public void DrawImageArc(Image image, float x, float y, int sx, int sy, int width, int height, float startAngle, float arcAngle)
	{
	}

	protected void _drawImage(Image image, float dx, float dy, float width, float height, int sx, int sy, float swidth, float sheight)
	{
	}

	protected void _drawBitmap(Image image, float dx, float dy, float width, float height, float sx, float sy, float swidth, float sheight)
	{
	}

	protected void ImageCheckUse(Image image)
	{
	}

	public void DrawLine(float x1, float y1, float x2, float y2, float lineWidth, int color)
	{
	}

	public void DrawLine(float x1, float y1, float x2, float y2, float lineWidth = 1f)
	{
	}

	public void DrawRect(float x, float y, float width, float height, int color)
	{
	}

	public void DrawRect(float x, float y, float width, float height)
	{
	}

	public void DrawRect2(float x, float y, float width, float height, int color)
	{
	}

	public void DrawRect2(float x, float y, float width, float height)
	{
	}

	public void DrawRectPoint(float left, float top, float right, float bottom, int color)
	{
	}

	public void DrawRectPoint(float left, float top, float right, float bottom)
	{
	}

	public void DrawString(long v, float x, float y)
	{
	}

	public void DrawString(TextFormat lf, long v, float x, float y)
	{
	}

	public void DrawString(long v, float x, float y, int anchor)
	{
	}

	public void DrawString(TextFormat lf, long v, float x, float y, int anchor)
	{
	}

	public void DrawString(string str, float x, float y)
	{
	}

	public void DrawString(TextFormat lf, string str, float x, float y)
	{
	}

	public void DrawString(string str, float x, float y, int anchor, int color)
	{
	}

	public void DrawString(string str, float x, float y, int anchor)
	{
	}

	public void DrawString(TextFormat lf, string str, float x, float y, int anchor, int color)
	{
	}

	public float DrawText(string str, float x, float y, float width, int anchor = 0)
	{
		return 0f;
	}

	public float DrawTextBold(string str, float x, float y, float width, int color, int anchor = 0)
	{
		return 0f;
	}

	public float DrawTextBold(TextFormat lf, string str, float x, float y, float width, int color, int anchor = 0)
	{
		return 0f;
	}

	public float DrawTextShadow(string str, float x, float y, float width, int color, int anchor = 0)
	{
		return 0f;
	}

	public float DrawTextShadow(TextFormat lf, string str, float x, float y, float width, int color, int anchor = 0)
	{
		return 0f;
	}

	public float DrawText(TextFormat lf, string str, float x, float y, float width, int anchor = 0)
	{
		return 0f;
	}

	public float TextWidth(string str, float width)
	{
		return 0f;
	}

	public float TextWidth(TextFormat lf, string str, float width)
	{
		return 0f;
	}

	public void DrawString(TextFormat lf, string str, float x, float y, int anchor)
	{
	}

	private Image GetFontTexture(string text)
	{
		return null;
	}

	private Image GetFontTextureBold(string text)
	{
		return null;
	}

	public void PushFontTexture(bool use)
	{
	}

	public void PopFontTexture()
	{
	}

	internal static void RemoveExpiredFontTextures(object sender, EventArgs e)
	{
	}

	public void DrawString2(string str, float x, float y)
	{
	}

	public void DrawString2(TextFormat lf, string str, float x, float y)
	{
	}

	public void DrawString2(string str, float x, float y, int anchor, int color)
	{
	}

	public void DrawString2(string str, float x, float y, int anchor)
	{
	}

	public void DrawString2(TextFormat lf, string str, float x, float y, int anchor, int color)
	{
	}

	public void DrawString2(TextFormat lf, string str, float x, float y, int anchor)
	{
	}

	public void DrawStringBold(string str, float x, float y, int color)
	{
	}

	public void DrawStringBold(TextFormat lf, string str, float x, float y, int color)
	{
	}

	public void DrawStringBold(string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringBold(TextFormat lf, string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringBold2(string str, float x, float y, int color)
	{
	}

	public void DrawStringBold2(TextFormat lf, string str, float x, float y, int color)
	{
	}

	public void DrawStringBold2(string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringBold2(TextFormat lf, string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringShadow(string str, float x, float y, int color)
	{
	}

	public void DrawStringShadow(TextFormat lf, string str, float x, float y, int color)
	{
	}

	public void DrawStringShadow(string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringShadow(TextFormat lf, string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringShadow2(string str, float x, float y, int color)
	{
	}

	public void DrawStringShadow2(TextFormat lf, string str, float x, float y, int color)
	{
	}

	public void DrawStringShadow2(string str, float x, float y, int color, int anchor)
	{
	}

	public void DrawStringShadow2(TextFormat lf, string str, float x, float y, int color, int anchor)
	{
	}

	public void FillArc(float x, float y, float width, float height, float startAngle, float arcAngle, int color)
	{
	}

	public void FillArc(float x, float y, float width, float height, float startAngle, float arcAngle)
	{
	}

	public void FillRect(float x, float y, float width, float height, int color)
	{
	}

	public void FillRect(float x, float y, float width, float height)
	{
	}

	internal void FillClipRect(float x, float y, float width, float height)
	{
	}

	public void FillRectPoint(float left, float top, float right, float bottom, int color)
	{
	}

	public void FillRectPoint(float left, float top, float right, float bottom)
	{
	}

	public void FillRoundRect(float x, float y, float width, float height, float r, int color)
	{
	}

	public void FillRoundRect(float x, float y, float width, float height, float r)
	{
	}

	public void FillTriangle(int x1, int y1, int x2, int y2, int x3, int y3, int color)
	{
	}

	public void FillTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
	{
	}

	public void FillTriangle(float x1, float y1, float x2, float y2, float x3, float y3, int color)
	{
	}

	public void FillTriangle(float x1, float y1, float x2, float y2, float x3, float y3)
	{
	}

	public static int GetColorOfName(int name)
	{
		return 0;
	}

	public static int GetColorOfRGB(int r, int g, int b)
	{
		return 0;
	}

	public static int GetColorOfRGB(int r, int g, int b, int a)
	{
		return 0;
	}

	public static ARGB GetColorElements(int color)
	{
		return default;
	}

	public static int[] GetAnchorPosition(int x, int y, int width, int height, int anchor)
	{
		return null;
	}

	public static float[] GetAnchorPositionF(float x, float y, float width, float height, int anchor)
	{
		return null;
	}

	public void Lock()
	{
	}

	public void SetColor(int c)
	{
	}

	public void SetColor(int r, int g, int b)
	{
	}

	public void SetColor(int r, int g, int b, int a)
	{
	}

	public int GetColor()
	{
		return 0;
	}

	public void SetFlipMode(int flipmode)
	{
	}

	public void SetFont(Font f)
	{
	}

	public Font GetFont(Font copy = null)
	{
		return null;
	}

	public void PushFont()
	{
	}

	public void PushFont(Font f)
	{
	}

	public void PushFont(int fontSize)
	{
	}

	public void PopFont()
	{
	}

	public void SetOrigin(float x, float y)
	{
	}

	public int GetOriginX()
	{
		return 0;
	}

	public int GetOriginY()
	{
		return 0;
	}

	public float GetOriginFX()
	{
		return 0f;
	}

	public float GetOriginFY()
	{
		return 0f;
	}

	public void ResetRender()
	{
	}

	public void Init()
	{
	}

	public void Unlock(bool forced)
	{
	}

	public void CopyArea(int x, int y, int width, int height, int dx, int dy)
	{
	}

	public bool IsRenderModeEnable()
	{
		return false;
	}

	public void SetRenderMode()
	{
	}

	public void SetRenderMode(int op, int srcRatio)
	{
	}

	public void SetRenderMode(int op, int srcRatio, int dstRatio)
	{
	}

	public int GetRenderModeOperator()
	{
		return 0;
	}

	public int GetRenderModeSrcRatio()
	{
		return 0;
	}

	public int GetRenderModeDstRatio()
	{
		return 0;
	}

	public void PushRenderMode()
	{
	}

	public void PushRenderMode(int op, int srcRatio, int dstRatio)
	{
	}

	public void PopRenderMode()
	{
	}

	public static bool CheckAlphaRectEnable()
	{
		return false;
	}

	public static bool CheckTransparentImageEnable()
	{
		return false;
	}

	public void SetPictoColorEnabled(bool b)
	{
	}

	public void Scale(float scaleRatio)
	{
	}

	public float GetScale()
	{
		return 0f;
	}

	public void LinearFilter(bool enable)
	{
	}

	public bool IsLinearFilter()
	{
		return false;
	}

	public void SetRenderRect(int x, int y, int w, int h)
	{
	}

	public float[] GetRenderRect()
	{
		return null;
	}

	public void ClearRenderRect()
	{
	}

	public void Screen(int w, int h)
	{
	}

	public void SetMatrix(Matrix m)
	{
	}

	public Matrix GetMatrix(Matrix dst = null)
	{
		return null;
	}

	public void PushMatrix(Matrix matrix = null)
	{
	}

	public void PopMatrix()
	{
	}

	private void InsertMatrix(int index, Matrix matrix)
	{
	}

	private void RemoveMatrix(int index)
	{
	}

	public bool CheckLocalMatrix()
	{
		return false;
	}

	internal bool CheckLocalCoordinate()
	{
		return false;
	}

	public void ClearLocalMatrix()
	{
	}

	private void UpdateWorldMatrix()
	{
	}

	private void UpdateScreenMatrix()
	{
	}

	public Matrix GetLocalMatrix(Matrix dst = null)
	{
		return null;
	}

	public Matrix GetScreenMatrix(Matrix dst = null)
	{
		return null;
	}

	public void SetSharpnessEnable(bool enable)
	{
	}

	public void SetSharpnessEnable(bool enable, int quality, int limitedWidth, int limitedHeight)
	{
	}

	public int[] GetSharpnessInfo()
	{
		return null;
	}

	public static void disposeSharpnessBuffer()
	{
	}

	public void UpdateGUIGroup()
	{
	}

	internal static void InitGUIGroup()
	{
	}

	internal static void EndGUIGroup()
	{
	}

	internal RectangleF GetTransRect(RectangleF rect, RectangleF output = null)
	{
		return null;
	}

	internal RectangleF GetTransRectGUI(RectangleF rect, RectangleF output = null)
	{
		return null;
	}

	internal Vector3[] GetTransRectGL(RectangleF rect, Vector3[] output, RectangleF gravityPoints)
	{
		return null;
	}

	internal RectangleF GetTransRect(float x, float y, float width, float height, RectangleF dst = null)
	{
		return null;
	}

	internal RectangleF GetTransRectGUI(float x, float y, float width, float height, RectangleF dst = null)
	{
		return null;
	}

	internal Vector3[] GetTransRectGL(float x, float y, float width, float height, Vector3[] output = null, bool transform = true, RectangleF gravityPoints = null)
	{
		return null;
	}

	internal float[] GetTransPoint(float x, float y, float[] output = null)
	{
		return null;
	}

	internal float[] GetTransPointGUI(float x, float y, float[] output = null)
	{
		return null;
	}

	internal float[] GetTransPointGL(float x, float y, float[] output = null)
	{
		return null;
	}

	internal void GetTransPointGL(Vector3[] vertices)
	{
	}

	public void SetBlendMode(int mode, int color = 0)
	{
	}

	public void SetBlendMode(int mode, int r, int g, int b, int a = 255)
	{
	}

	public int GetBlendMode()
	{
		return 0;
	}

	public int GetBlendColor()
	{
		return 0;
	}

	public void PushBlendMode()
	{
	}

	public void PushBlendMode(int mode, int color = 0)
	{
	}

	public void PushBlendMode(int mode, int r, int g, int b, int a = 255)
	{
	}

	public void PopBlendMode()
	{
	}

	protected void UpdateGLClip()
	{
	}

	public static UnityEngine.Color ArgbToColor(int argb)
	{
		return default;
	}

	public static UnityEngine.Color RgbToColor(int rgb)
	{
		return default;
	}

	public static int ColorToArgb(UnityEngine.Color color)
	{
		return 0;
	}

	public static int ColorToRgb(UnityEngine.Color color)
	{
		return 0;
	}

	protected RenderPass[] GetRenderPass()
	{
		return null;
	}

	protected RenderPass[] GetRenderPass(Image image)
	{
		return null;
	}

	protected RenderPass[] GetRenderPass(UnityEngine.Color color)
	{
		return null;
	}

	protected RenderPass[] GetRenderPass(params UnityEngine.Color[] colors)
	{
		return null;
	}

	protected RenderPass[] GetRenderPass(Image image, UnityEngine.Color color)
	{
		return null;
	}

	protected RenderPass[] GetRenderPass(Image image, params UnityEngine.Color[] colors)
	{
		return null;
	}

	public bool IsGUI()
	{
		return false;
	}

	internal bool IsRenderGUIMode()
	{
		return false;
	}

	public MeshManager GetMeshManager()
	{
		return null;
	}

	public MeshManager GetMeshManager(int id)
	{
		return null;
	}

	public static void SetAutoTextLayout(bool enable)
	{
	}

	public static bool IsAutoTextLayout()
	{
		return false;
	}

	internal static void PushAutoTextLayout(bool enable)
	{
	}

	internal static bool PopAutoTextLayout()
	{
		return false;
	}

	internal static bool PeekAutoTextLayout()
	{
		return false;
	}

	public bool PushClipEnable(bool enable)
	{
		return false;
	}

	public void PushClipEnable()
	{
	}

	public void PopClipEnable()
	{
	}

	public bool SetClipEnable(bool enable)
	{
		return false;
	}

	public bool IsClipEnable()
	{
		return false;
	}

	public void PushOrigin()
	{
	}

	public void PushOrigin(float x, float y, bool concat = false)
	{
	}

	public void PopOrigin()
	{
	}

	private bool BeginRenderMatrix(ref float x, ref float y)
	{
		return false;
	}

	private void EndRenderMatrix()
	{
	}

	public void BeginLocalCoordination()
	{
	}

	public void BeginLocalCoordination(ref float x, ref float y)
	{
	}

	public void BeginLocalCoordination(ref float x)
	{
	}

	public void BeginLocalCoordination(ref int x, ref int y)
	{
	}

	public void BeginLocalCoordination(ref int x)
	{
	}

	private void BeginLocalCoordination(float x, float y)
	{
	}

	public void EndLocalCoordination()
	{
	}

	public int StringWidth(string text)
	{
		return 0;
	}

	public int StringWidth(TextFormat lf, string text)
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

	public bool IsStencil()
	{
		return false;
	}

	public int GetDepthBits()
	{
		return 0;
	}

	public static Graphics GetCurrent()
	{
		return null;
	}

	public void SetRenderQueue(int queue)
	{
	}

	public int GetRenderQueue()
	{
		return 0;
	}

	public void PushRenderQueue()
	{
	}

	public void PushRenderQueue(int queue)
	{
	}

	public void PopRenderQueue()
	{
	}

	public void SetCameraDepth(int depth)
	{
	}

	public void BeginGLRender(bool clipEnable = true)
	{
	}

	public void EndGLRender(bool force = false)
	{
	}

	public void FlushGLRender(bool meshOnly = false)
	{
	}

	public bool IsGLRender()
	{
		return false;
	}

	public void SetGLMatrix(Matrix4x4 matrix)
	{
	}

	public static void SetRenderCache(bool enable)
	{
	}

	public static bool IsRenderCache()
	{
		return false;
	}

	public void GLClear(bool clearDepth, bool clearColor, bool clearStencil, int color = -1)
	{
	}

	public void PushImageClip()
	{
	}

	public void PushImageClip(float x, float y, float width, float height)
	{
	}

	public void PopImageClip()
	{
	}

	public float[] GetImageClip()
	{
		return null;
	}

	public void SetImageClip(float x, float y, float width, float height)
	{
	}

	public void ClearImageClip()
	{
	}

	public void PushCulling()
	{
	}

	public void PushCulling(float x, float y, float width, float height)
	{
	}

	public void PopCulling()
	{
	}

	public RectF GetCulling()
	{
		return default;
	}

	public void SetCulling(float x, float y, float width, float height)
	{
	}

	public void ClearCulling()
	{
	}

	public static void SetOutlineWidth(float width)
	{
	}

	public static void SetOutlineQuality(int quality)
	{
	}

	public static float GetOutlineWidth()
	{
		return 0f;
	}

	public static int GetOutlineQuality()
	{
		return 0;
	}

	public void SetCurrentMeshManager(int id)
	{
	}

	public void BeginState()
	{
	}

	public void EndState()
	{
	}

	public static void SetLineSpace(int lineSpace)
	{
	}

	public static int GetLineSpace()
	{
		return 0;
	}

	public static void SetImageExpand(float expand = 0.24f)
	{
	}

	public float GetImageExpand()
	{
		return 0f;
	}

	public void PushImageExpand()
	{
	}

	public void PushImageExpand(float expand)
	{
	}

	public void PopImageExpand()
	{
	}

	public void BeginMeshRecord()
	{
	}

	public MeshRecord EndMeshRecord()
	{
		return null;
	}

	public void MaskBalloon(int x, int y, int width, int height)
	{
	}

	public float GetDepth()
	{
		return 0f;
	}

	public void SetDepth(float depth)
	{
	}

	public void SetDepthOffset(float offset)
	{
	}

	public float GetDepthOffset()
	{
		return 0f;
	}

	public void PushDepthOffset()
	{
	}

	public void PushDepthOffset(float offset)
	{
	}

	public void PopDepthOffset()
	{
	}

	public void SetDepthScale(float scale = 100f)
	{
	}

	private void ClearGravityPoints()
	{
	}

	private void AddGravityPoint(float x, float y, float toX, float toY)
	{
	}

	private GravityPoint GetGravityPoint(float x, float y)
	{
		return null;
	}

	public void BeginLineGraph()
	{
	}

	public void EndLineGraph()
	{
	}

	public void BeginFill()
	{
	}

	public void EndFill()
	{
	}

	public void BeginStretchArea(ref int x, ref int width, int widthMin = 240)
	{
	}

	public void EndStretchArea()
	{
	}

	public bool IsStretchArea()
	{
		return false;
	}

	internal static StretchArea GetStretchArea()
	{
		return null;
	}

	public int GetFontSize(int widthMax, params string[] strings)
	{
		return 0;
	}

	public int BeginReduceFont(int widthMax, params string[] strings)
	{
		return 0;
	}

	public void EndReduceFont()
	{
	}
}

using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using java.io;
using kairo.unity.graphics;
using kairo.unity.surface;
using kairo.unity.util;

namespace kairo.unity.ui;

public class Image
{
	public enum Format
	{
		Default = -1,
		ARGB32 = 5,
		ARGB4444 = 2,
		RGB24 = 3,
		RGB565 = 7
	}

	public enum Filter
	{
		Default = -1,
		Point = 0,
		Bilinear = 1,
		Trilinear = 2
	}

	public enum Result
	{
		Success = 0,
		Failure = 1,
		Over = 2
	}

	internal struct TextRenderTask(string text, float x, float y, int anchor, int color, Font font)
	{
		public string Text = null;

		public float X = 0f;

		public float Y = 0f;

		public int Anchor = 0;

		public int Color = 0;

		public Font Font = null;
	}

	internal struct BalloonRenderTask(Balloon balloon, float x, float y, Offscreen offscreen)
	{
		public Balloon Balloon = null;

		public float X = 0f;

		public float Y = 0f;

		public Offscreen Offscreen = null;
	}

	internal struct TouchTask(SurfaceBase surface, TouchComponent component)
	{
		public SurfaceBase Surface = null;

		public TouchComponent Component = null;
	}

	private delegate Image CreateAsyncMethod();

	private class ThreadData
	{
		public int start;

		public int end;

		public ThreadData(int s, int e)
		{
		}
	}

	private static List<Image> all_;

	private static ImageAtlasManager atlasMan_;

	internal Texture image_;

	protected string name_;

	protected int width_;

	protected int height_;

	internal Format format_;

	internal Filter filter_;

	internal Format requestFormat_;

	internal Filter requestFilter_;

	internal byte[] src_;

	internal byte[] optSrc_;

	internal string file_;

	internal string paletteFile_;

	internal int rsId_;

	internal int rcId_;

	internal bool useBin_;

	internal bool lockExpiration_;

	protected static FastVector sourceImageList_;

	protected static int sourceImagePixels_;

	protected static int sourceImageMaxCount_;

	protected static int sourceImageMaxPixels_;

	protected static int sourceImageValidateFrames_;

	protected int localSourceImageValidateFrames_;

	internal int standardWidth_;

	internal int standardHeight_;

	internal const int OPT_REF = 0;

	internal const int OPT_X = 1;

	internal const int OPT_Y = 2;

	internal const int OPT_SRCX = 3;

	internal const int OPT_SRCY = 4;

	internal const int OPT_SRCW = 5;

	internal const int OPT_SRCH = 6;

	internal const int OPT_END = 7;

	internal sbyte[] optimize_;

	internal short[] optimizeEx_;

	internal sbyte[] optimizeAccess_;

	internal short[] optimizeAccessL_;

	internal int optimizeWidthNum_;

	internal int optimizeHeightNum_;

	internal int optimizePass_;

	internal const int OPTSEB_U = 0;

	internal const int OPTSEB_V = 1;

	internal const int OPTSEB_W = 2;

	internal const int OPTSEB_H = 3;

	internal const int OPTSEB_END = 4;

	internal sbyte[] optimizeSeb_;

	internal short[] optimizeSebEx_;

	internal Image[] images_;

	internal short optimizeBlockWidth_;

	internal short optimizeBlockHeight_;

	internal int checkCount_;

	private static bool copeOutOfMemoryEnable_;

	protected int transparentColor_;

	protected bool isDisposed_;

	protected bool isCreateImage_;

	protected bool isForceExpiration_;

	protected int alpha_;

	public const int ALPHATYPE_OPAQUE = 0;

	public const int ALPHATYPE_ALPHATEST = 1;

	public const int ALPHATYPE_TRANSPARENT = 2;

	public const int ALPHATYPE_OPATRANS = 3;

	protected int alphaType_;

	internal int renderQueue_;

	internal int imageAtlasId_;

	internal ImageAtlas.AtlasRegion atlasRegion_;

	internal TextRenderTask[] textRenderTasks_;

	internal int textRenderTasksNum_;

	internal BalloonRenderTask[] balloonRenderTasks_;

	internal int balloonRenderTasksNum_;

	internal TouchTask[] touchTasks_;

	internal int touchTasksNum_;

	public static Format DEFAULT_FORMAT;

	public static Filter DEFAULT_FILTER;

	private static int[] getOptimize_result;

	private static int[] getOptimizeSeb_result;

	private static int[] getPaletteInfo_result;

	private static int[] getAreaSize_result;

	internal static long asyncImageTime_;

	private static object asyncImageLock_;

	private static Color[] texColors;

	private static Color[] newColors;

	private static int w;

	private static float ratioX;

	private static float ratioY;

	private static int w2;

	private static int finishCount;

	private static Mutex mutex;

	internal static List<Image> All => null;

	public ResourceManager Resource { get; internal set; }

	public bool IsDisposed => false;

	public int ImageAtlasId => 0;

	public bool IsRenderBalloon { get; set; }

	public int Height => 0;

	public int Width => 0;

	public int Alpha => 0;

	public int TransparentColor => 0;

	public bool HasOptimize => false;

	public Image()
	{
	}

	public Image(Texture image)
	{
	}

	public Image(int[] rgb, int width, int height, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
	}

	public Image(byte[] src, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
	}

	public Image(string file, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
	}

	public Image(string file, string paletteFile, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
	}

	public Image(int rsId, int rcId, string file, string paletteFile, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
	}

	public static Image CreateImage(int width, int height, Format format = Format.RGB24, Filter filterMode = Filter.Default)
	{
		return null;
	}

	public Texture GetImage()
	{
		return null;
	}

	public static Image Load(InputStream stream, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
		return null;
	}

	public static Image Load(byte[] data, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
		return null;
	}

	public static Image Load(string path, Format format = Format.Default, Filter filterMode = Filter.Default)
	{
		return null;
	}

	public void LoadOptimize(InputStream stream, Image[] images = null)
	{
	}

	public void LoadOptimize(byte[] data, Image[] images = null)
	{
	}

	public int[] GetOptimize(int bx, int by, int passIndex)
	{
		return null;
	}

	public int[] GetOptimize(sbyte access)
	{
		return null;
	}

	public int[] GetOptimize(short access)
	{
		return null;
	}

	public int[] GetOptimize(int type, int index)
	{
		return null;
	}

	public int[] GetOptimizeSeb(int index)
	{
		return null;
	}

	public void Use()
	{
	}

	public void Unuse()
	{
	}

	public Graphics GetGraphics()
	{
		return null;
	}

	public int GetHeight()
	{
		return 0;
	}

	public int GetWidth()
	{
		return 0;
	}

	public int GetAlpha()
	{
		return 0;
	}

	public int GetTransparentColor()
	{
		return 0;
	}

	public void SetAlpha(int alpha)
	{
	}

	public void SetTransparentColor(int color)
	{
	}

	public void SetTransparentEnabled(bool enabled)
	{
	}

	public void Dispose()
	{
	}

	internal void Release()
	{
	}

	public static void SetSourceImageMaxCount(int max)
	{
	}

	public static void SetSourceImageMaxPixels(int max)
	{
	}

	public static void SetSourceImageValidateFrames(int frames)
	{
	}

	public void SetName(string name)
	{
	}

	public string GetName()
	{
		return null;
	}

	public string GetFullName()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static void DisposeBrightnessImages()
	{
	}

	private static void CopeOutOfMemory(int tryCount, OutOfMemoryException error)
	{
	}

	public static void SetCopeOutOfMemoryEnable(bool enable)
	{
	}

	public void EraseColor(int color)
	{
	}

	public void EraseColor(int r, int g, int b, int a)
	{
	}

	public static byte[] OverwritePaletteData(byte[] image, byte[] palette)
	{
		return null;
	}

	public static byte[] OverwritePaletteData(byte[] image, byte[] palette, int imageOffset, int paletteOffset, int colors)
	{
		return null;
	}

	private static int[] GetPaletteInfo(byte[] data)
	{
		return null;
	}

	public static int[] GetAreaSize(byte[] data)
	{
		return null;
	}

	protected static Texture2D DecodeByteArray(byte[] data, Format format = Format.Default, Filter filter = Filter.Default)
	{
		return null;
	}

	protected static int GetAlphaType(byte[] data)
	{
		return 0;
	}

	public int GetAlphaType()
	{
		return 0;
	}

	private void _getAlphaType(Texture2D tex = null)
	{
	}

	internal void SetAlphaType(int alphaType)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static int GetPowerOf2Value(int value)
	{
		return 0;
	}

	public Color GetPixel(int x, int y)
	{
		return default;
	}

	public Color GetPixelBilinear(float x, float y)
	{
		return default;
	}

	public int GetRGBPixel(int x, int y)
	{
		return 0;
	}

	public int GetRGBPixelBilinear(float x, float y)
	{
		return 0;
	}

	public int GetARGBPixel(int x, int y)
	{
		return 0;
	}

	public int GetARGBPixelBilinear(float x, float y)
	{
		return 0;
	}

	public void SetPixel(int x, int y, Color color)
	{
	}

	public void SetRGBPixel(int x, int y, int color)
	{
	}

	public void SetARGBPixel(int x, int y, int color)
	{
	}

	public Color[] GetPixels(int x, int y, int width, int height, Color[] pixels = null, int off = 0)
	{
		return null;
	}

	internal Color[] GetNativePixels(int x, int y, int width, int height)
	{
		return null;
	}

	internal void SetNativePixels(int x, int y, int width, int height, Color[] pixels)
	{
	}

	internal void Apply()
	{
	}

	public int[] GetARGBPixels(int x, int y, int width, int height, int[] pixels = null, int off = 0)
	{
		return null;
	}

	public int[] GetRGBPixels(int x, int y, int width, int height, int[] pixels = null, int off = 0)
	{
		return null;
	}

	public void SetPixels(int x, int y, int width, int height, Color[] pixels, int off = 0)
	{
	}

	public void SetARGBPixels(int x, int y, int width, int height, int[] pixels, int off = 0)
	{
	}

	public void SetRGBPixels(int x, int y, int width, int height, int[] pixels, int off = 0)
	{
	}

	internal Texture2D GetTexture2D()
	{
		return null;
	}

	internal static RenderTextureFormat GetRenderTextureFormat(Format format)
	{
		return RenderTextureFormat.ARGB32;
	}

	internal static bool IsAlphaFormat(Format format)
	{
		return false;
	}

	private static string GetFileFormat(byte[] data)
	{
		return null;
	}

	public void Resize(float scaleRatio)
	{
	}

	public void Resize(int width, int height)
	{
	}

	public void Resize(int width, int height, int srcX, int srcY, int srcWidth, int srcHeight)
	{
	}

	public void SetFilterMode(Filter filterMode)
	{
	}

	public void SetWrapMode(bool repeat)
	{
	}

	public static void UnuseExpirationImages()
	{
	}

	public void Clear(int color)
	{
	}

	public void Clear(int x, int y, int width, int height, int color)
	{
	}

	public Result SetImageAtlasId(int id)
	{
		return Result.Success;
	}

	public void SetExpiration(bool yes, int validateFrames = -1)
	{
	}

	public bool IsExpiration()
	{
		return false;
	}

	public void SetStandardResolution(int width, int height)
	{
	}

	private static Image CreateAsyncImage(CreateAsyncMethod method)
	{
		return null;
	}

	private void createAsyncImage(CreateAsyncMethod method)
	{
	}

	internal void CheckUse()
	{
	}

	public static string GetOptionFile(string file)
	{
		return null;
	}

	public static void Resize(Texture2D tex, int newWidth, int newHeight, FilterMode filter = FilterMode.Bilinear)
	{
	}

	private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear)
	{
	}

	private static void BilinearScale(object obj)
	{
	}

	private static void PointScale(object obj)
	{
	}

	private static Color ColorLerpUnclamped(Color c1, Color c2, float value)
	{
		return default;
	}

	internal void AddTextRenderTask(TextRenderTask add)
	{
	}

	internal void AddBalloonRenderTask(BalloonRenderTask add)
	{
	}

	internal void AddTouchTask(TouchTask add)
	{
	}
}

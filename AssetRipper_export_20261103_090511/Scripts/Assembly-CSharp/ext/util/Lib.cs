using System;
using java.io;
using java.util;
using kairo.unity.ui;
using kairo.unity.util;
using main;

namespace ext.util;

public class Lib
{
	public static sbyte NO;

	public static sbyte YES;

	public static int ANCHOR_WIDTH_CENTER;

	public static int ANCHOR_HEIGHT_CENTER;

	public static int BLACK;

	public static int WHITE;

	public static SecureString host_;

	private static AppData apdat_;

	private static int frame_;

	public static bool AUTO_UPDATE_ADMOB;

	private static JRandom random_;

	private static string[] ROOT_HIDE_APPLICATION_LIST;

	private static int[] clipAreaTmp_;

	public static Vector<Image[]> lifeImg_;

	public static int COUNT_STATE_FULL;

	public static int COUNT_STATE_KAIRO_SERVICE;

	public static int COUNT_STATE_ANALYTICS;

	public static int GAUGE_FLAG_BORDER;

	public static void Setup(AppData apdat)
	{
	}

	public static void SetOffsetPos(Graphics g, int x, int y)
	{
	}

	public static void DrawString2(Graphics g, string str, int x, int y, int anchor, int lineSpace)
	{
	}

	public static void DrawString2(Graphics g, string str, int x, int y, int w, int h, int anchor)
	{
	}

	public static void DrawString2(Graphics g, string str, int x, int y, int w, int h, int anchor, int lineSpace)
	{
	}

	public static void FillRectAlpha(Graphics g, int x, int y, int w, int h)
	{
	}

	public static void FillRectAlpha(Graphics g, int x, int y, int w, int h, int color)
	{
	}

	public static void FillRectAlpha(Graphics g, int x, int y, int w, int h, int color, int alpha)
	{
	}

	public static void DrawSebLine(Graphics g, ResourceManager res, int x, int y, int seb, int lineNo)
	{
	}

	public static void DrawSebLine(Graphics g, ResourceManager res, int x, int y, int seb, int frame, int lineNo)
	{
	}

	public static int GetRatio(double now, double max)
	{
		return 0;
	}

	public static int GetRatio(long now, long max)
	{
		return 0;
	}

	public static int GetRatio(double now, double max, int range)
	{
		return 0;
	}

	public static int GetRatio(long now, long max, int range)
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

	public static void SetAlpha(Graphics g, int alpha)
	{
	}

	public static void SetHalfDarkAlpha(Graphics g)
	{
	}

	public static void ClearAlpha(Graphics g)
	{
	}

	public static void SetFontSize(Graphics g, Font f, int size)
	{
	}

	public static void FillAlpha(Graphics g, bool force, int color, int x, int y, int w, int h, int alpha)
	{
	}

	public static void FillAlpha(Graphics g, int color, int x, int y, int w, int h)
	{
	}

	public static void FillAlpha(Graphics g, int color, int x, int y, int w, int h, int alpha)
	{
	}

	public static void FillAlpha(Graphics g, bool force, int color, int x, int y, int w, int h)
	{
	}

	public static void FillGradationRectV(Graphics g, int x, int y, int w, int h, int startColor, int endColor, int step)
	{
	}

	public static void SetCenterOrigin(Graphics g)
	{
	}

	public static int[] ClipArea(Graphics g, int x, int y, int w, int h)
	{
		return null;
	}

	public static int[] ClipArea(int clipX, int clipY, int clipW, int clipH, int x, int y, int w, int h)
	{
		return null;
	}

	public static void SetHost(string host)
	{
	}

	public static byte[] ConnectPHP(string cgi)
	{
		return null;
	}

	public static void Log(string str)
	{
	}

	public static int Random()
	{
		return 0;
	}

	public static int Random(int n)
	{
		return 0;
	}

	public static int Random(int min, int max)
	{
		return 0;
	}

	public static int Random(int[] range)
	{
		return 0;
	}

	public static void ArrayChange(int[] list, int index1, int index2)
	{
	}

	public static int GetNumImageWidth(string value, int seb)
	{
		return 0;
	}

	public static int GetNumImageWidth(string value, int seb, int padding)
	{
		return 0;
	}

	public static void DrawRepeatSebW(Graphics g, Seb seb, int x, int y, int width)
	{
	}

	public static void DrawRepeatSebW(Graphics g, Seb seb, int x, int y, int width, int sy)
	{
	}

	public static void DrawRepeatImageW(Graphics g, Image img, int x, int y, int width)
	{
	}

	public static void DrawRepeatImageW(Graphics g, Image img, int x, int y, int width, int sy)
	{
	}

	public static void DrawRepeatImageW(Graphics g, Image img, int x, int y, int width, int sy, int maxHeight)
	{
	}

	public static void DrawRepeatSeb(Graphics g, Seb seb, int x, int y, int width, int height)
	{
	}

	public static void DrawRepeatImage(Graphics g, Image img, int x, int y, int width, int height)
	{
	}

	public static void DrawStringBold(Graphics g, Font f, string text, float x, float y, int color)
	{
	}

	public static void DrawGradationBox(Graphics g, int x, int y, int w, int h, int borderColor1, int borderColor2, int startColor, int endColor, int step)
	{
	}

	public static int SinCurve(int max, int length, int frame)
	{
		return 0;
	}

	public static void FillGradationRect2(Graphics g, int x, int y, int w, int h, int color1, int startColor, int endColor)
	{
	}

	public static void FillGradationRect3(Graphics g, int x, int y, int w, int h, int color1, int color2, int startColor, int endColor)
	{
	}

	public static void DrawShadowRect2(Graphics g, int x, int y, int w, int h, int borderColor, int shadowColor)
	{
	}

	public static int Easing2(int v0, int v1, int length, int frame, int edging)
	{
		return 0;
	}

	public static float Easing2(float v0, float v1, float length, float frame, float edging)
	{
		return 0f;
	}

	public static int[] ArrayCopy(int[] list)
	{
		return null;
	}

	public static void ArrayInit(int[] list, int value)
	{
	}

	public static void ArrayInit(bool[] list, bool value)
	{
	}

	public static void FillBox(Graphics g, int x, int y, int w, int h, int bgColor)
	{
	}

	public static void FillBox2(Graphics g, int x, int y, int w, int h, int borderColor, int bgColor)
	{
	}

	public static void FillBox3(Graphics g, int x, int y, int w, int h, int borderColor1, int borderColor2, int bgColor)
	{
	}

	public static void FillBox(Graphics g, int x, int y, int w, int h, params int[] colors)
	{
	}

	public static void DrawTextBox(Graphics g, string text, int color, int x, int y, int w, int h, params int[] colors)
	{
	}

	public static void DrawTextBox2(Graphics g, string text, int color, int x, int y, int w, int h, params int[] colors)
	{
	}

	public static void DrawLRArrow(Graphics g, int x, int y, int space)
	{
	}

	public static void DrawLRArrow(Graphics g, int x, int y, int space, int bottomMargin)
	{
	}

	public static void DrawLRArrow(Graphics g, int x, int y, int space, bool addTouch)
	{
	}

	public static void DrawLRArrow(Graphics g, int x, int y, int space, bool addTouch, int bottomMargin)
	{
	}

	public static void Frame()
	{
	}

	public static void AddOriginY(Graphics g, int offset)
	{
	}

	public static bool CheckLength(FastVector ary, int index)
	{
		return false;
	}

	public static bool CheckLength<T>(Vector<T> vector, int index)
	{
		return false;
	}

	public static void DrawWide(Graphics g, ResourceManager res, int seb, int x, int y, int width)
	{
	}

	public static void DrawWide(Graphics g, ResourceManager res, int seb, int x, int y, int width, int anchor)
	{
	}

	public static string ConvertToPointNumberStr(long value)
	{
		return null;
	}

	public static int GetStringLength(string s)
	{
		return 0;
	}

	private static bool IsSimpleChara(char c)
	{
		return false;
	}

	public static void Gc()
	{
	}

	public static void AddLifeImage(ResourceManager res)
	{
	}

	public static void AllUnuseImage()
	{
	}

	public static bool CheckLength<T>(T[] ary, int index)
	{
		return false;
	}

	public static bool CheckLength<T>(T[][] ary, int index1, int index2)
	{
		return false;
	}

	public static bool CheckSize<T>(Vector<T> v, int index)
	{
		return false;
	}

	public static void CheckSizeAssert<T>(Vector<T> v, int index)
	{
	}

	public static T[] CreateArray<T>(int length, T defaultValue = default(T))
	{
		return null;
	}

	public static T[] CreateArray<T>(int length, Func<T> predicate)
	{
		return null;
	}

	public static T[][] CreateDoubleArray<T>(int length1, int length2, T defaultValue = default(T))
	{
		return null;
	}

	public static T[] CopyArray<T>(T[] src)
	{
		return null;
	}

	public static void InitArray<T>(T[] ary, T value = default(T))
	{
	}

	public static int[] CreateIntArray(int length, int defaultValue = 0)
	{
		return null;
	}

	public static int[][] CreateIntDoubleArray(int length1, int length2, int defaultValue = 0)
	{
		return null;
	}

	public static long[][][] CreateLongTripleArray(int length1, int length2, int length3, long defaultValue = 0L)
	{
		return null;
	}

	public static void SerializeIntArray(OutputStream stream, int[] ary)
	{
	}

	public static int[] DeserializeIntArray(InputStream stream)
	{
		return null;
	}

	public static void SerializeIntDoubleArray(OutputStream stream, int[][] ary)
	{
	}

	public static int[][] DeserializeIntDoubleArray(InputStream stream)
	{
		return null;
	}

	public static int MaxValueIn(int[] values)
	{
		return 0;
	}

	public static Vector[] CreateVectorArray(int length)
	{
		return null;
	}

	public static Vector<T>[] CreateVectorArray<T>(int length)
	{
		return null;
	}

	public static int AddColor(int color, int addR, int addG, int addB)
	{
		return 0;
	}

	public static int ConvertYearToHour(int year)
	{
		return 0;
	}

	public static int ConvertMonthToHour(int month)
	{
		return 0;
	}

	public static int ConvertMonthToTime(int month)
	{
		return 0;
	}

	public static int ConvertHourToTime(int hour)
	{
		return 0;
	}

	public static int ConvertHourToMillis(int hour)
	{
		return 0;
	}

	public static int ConvertMinuteToTime(int minute)
	{
		return 0;
	}

	public static int ConvertTimeToHour(int time)
	{
		return 0;
	}

	public static int ConvertTimeToMinute(int time)
	{
		return 0;
	}

	public static int ConvertFrameToTime(int frame)
	{
		return 0;
	}

	public static T Choose<T>(int rate, T hit, T miss)
	{
		return default;
	}

	public static bool Hits(int rate)
	{
		return false;
	}

	public static T Choose<T>(bool yes, T hit, T miss)
	{
		return default;
	}

	public static int Search<T>(T[] ary, T value)
	{
		return 0;
	}

	public static int Count<T>(T[] ary, T value, int start = 0, int end = -1)
	{
		return 0;
	}

	public static int MeasureNumImageWidth(long value, int sebId)
	{
		return 0;
	}

	public static int MeasureNumImageWidth(string value, int sebId)
	{
		return 0;
	}

	public static int GetNumImageWidth(char c, int sebId)
	{
		return 0;
	}

	public static int Sum(int[] ary)
	{
		return 0;
	}

	public static void Where<T>(T[][] src, Vector<T> dst, Func<T, bool> predicate)
	{
	}

	public static T RandomElement<T>(T[] array)
	{
		return default;
	}

	public static T RandomElement<T>(Vector<T> v) where T : class
	{
		return null;
	}

	public static int Min(int a, int b)
	{
		return 0;
	}

	public static int Max(int a, int b)
	{
		return 0;
	}

	public static int SumIntDoubleArray(int[][] ary)
	{
		return 0;
	}

	public static void DrawGauge(Graphics g, int x, int y, int width, int height, int ratio, int barColor1, int barColor2)
	{
	}

	public static void DrawGauge(Graphics g, int x, int y, int width, int height, int ratio, int barColor1, int barColor2, int flag)
	{
	}

	public static void DrawGauge(Graphics g, int x, int y, int width, int height, int ratio, int color)
	{
	}

	public static int StringWidth(Graphics g, string str)
	{
		return 0;
	}

	public static void OpenGooglePlayBrowser(string destPackageName, string srcPackageName, string referrerName)
	{
	}

	public static bool CompareIntArrays(int[] a, int[] b)
	{
		return false;
	}

	public static FastVector<T> Shuffle<T>(Vector<T> source, FastVector<T> v = null)
	{
		return null;
	}

	public static Vector<T> CloneVector<T>(Vector<T> source)
	{
		return null;
	}

	public static byte[] IntArrayToByteArray(int[] array)
	{
		return null;
	}

	public static int[] ByteArrayToIntArray(byte[] array)
	{
		return null;
	}

	public static T[] VectorToArray<T>(Vector v)
	{
		return null;
	}

	public static void GC()
	{
	}

	public static void UnloadUnusedAssets()
	{
	}
}

using System;
using System.Collections.Generic;
using kairo.unity.m3d4.util3d;
using kairo.unity.type;

namespace kairo.unity.math;

public class KairoMath
{
	public const float PI = (float)Math.PI;

	private static int[] checkHitLine_tmp;

	private static float[] checkHitLineF_tmp;

	private static PointF[][][] IsContainPoint_buf;

	private static float[] transPoint_tmp1;

	private static Vector3D transPoint_tmp2;

	private static Vector3D transPoint_tmp3;

	private static Vector3D[] getNormalVector_tmp;

	private static float[] getNormalVector2D_tmp;

	private KairoMath()
	{
	}

	public static bool CheckHitPointRect(int x, int y, int rcx, int rcy, int rcw, int rch)
	{
		return false;
	}

	public static bool CheckHitPointRect(Point p, Rect rc)
	{
		return false;
	}

	public static bool CheckHitPointRect(float x, float y, float rcx, float rcy, float rcw, float rch)
	{
		return false;
	}

	public static bool CheckHitPointRect(PointF p, RectF rc)
	{
		return false;
	}

	public static bool CheckHitPointCircle(Vector3D pos1, Vector3D pos2, float r)
	{
		return false;
	}

	public static bool CheckHitPointCircle(PointF p, CircleF circle)
	{
		return false;
	}

	public static bool CheckHitCircle(Vector3D pos1, float rad1, Vector3D pos2, float rad2)
	{
		return false;
	}

	public static bool CheckHitCircle(CircleF c1, CircleF c2)
	{
		return false;
	}

	public static bool CheckHitPointBox(Vector3D point, Vector3D min, Vector3D max)
	{
		return false;
	}

	public static bool CheckHitPointBox(PointF point, PointF min, PointF max)
	{
		return false;
	}

	public static bool CheckHitPointTriangle(Vector3D p, Vector3D v1, Vector3D v2, Vector3D v3)
	{
		return false;
	}

	public static bool CheckHitPointTriangle(PointF p, PointF v1, PointF v2, PointF v3)
	{
		return false;
	}

	public static bool CheckHitRect(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
	{
		return false;
	}

	public static bool CheckHitRect(float x1, float y1, float w1, float h1, float x2, float y2, float w2, float h2)
	{
		return false;
	}

	public static bool CheckHitRect(int[] rect1, int[] rect2)
	{
		return false;
	}

	public static bool CheckHitRect(RectF rect1, RectF rect2)
	{
		return false;
	}

	public static bool CheckHitLineCircle(Vector3D pos1, Vector3D vec1, Vector3D pos2, float r, Vector3D cross)
	{
		return false;
	}

	public static Hit CheckHitLineCircle(PointF p1, PointF p2, CircleF circle)
	{
		return default;
	}

	public static bool CheckHitLine(int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy, int[] cross)
	{
		return false;
	}

	public static bool CheckHitLine(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy, float[] cross)
	{
		return false;
	}

	public static Hit CheckHitLine(PointF a, PointF b, PointF c, PointF d)
	{
		return default;
	}

	public static bool CheckHitLineRect(Vector3D p1, Vector3D p2, float rcx, float rcy, float rcw, float rch)
	{
		return false;
	}

	public static bool CheckHitLineRect(PointF p1, PointF p2, float rcx, float rcy, float rcw, float rch)
	{
		return false;
	}

	private static bool CheckLineCrossRough(PointF a1, PointF a2, PointF b1, PointF b2)
	{
		return false;
	}

	private static bool CheckLineCrossLeftRight(PointF a1, PointF a2, PointF b1, PointF b2)
	{
		return false;
	}

	private static bool CheckLineCrossRough(float a1x, float a1y, float a2x, float a2y, float b1x, float b1y, float b2x, float b2y)
	{
		return false;
	}

	private static bool CheckLineCrossLeftRight(float a1x, float a1y, float a2x, float a2y, float b1x, float b1y, float b2x, float b2y)
	{
		return false;
	}

	public static bool CheckHitLinePlane(Vector3D a1, Vector3D a2, Vector3D b1, Vector3D b2)
	{
		return false;
	}

	public static bool CheckHitLinePlane(PointF a1, PointF a2, PointF b1, PointF b2)
	{
		return false;
	}

	public static bool CheckHitLinePlane(float a1x, float a1y, float a2x, float a2y, float b1x, float b1y, float b2x, float b2y)
	{
		return false;
	}

	public static Vector3D GetCrossPlane(Vector3D a1, Vector3D a2, Vector3D p)
	{
		return null;
	}

	public static Hit GetCrossPlane(PointF a1, PointF a2, PointF p)
	{
		return default;
	}

	public static Vector3D GetCrossLine(Vector3D v1, Vector3D v2, Vector3D v3, Vector3D v4)
	{
		return null;
	}

	public static Vector3D GetCrossLine(float v1x, float v1y, float v2x, float v2y, float v3x, float v3y, float v4x, float v4y)
	{
		return null;
	}

	public static PointF GetCrossLine(PointF v1, PointF v2, PointF v3, PointF v4)
	{
		return default;
	}

	public static void GetCrossLine(float v1x, float v1y, float v2x, float v2y, float v3x, float v3y, float v4x, float v4y, out float cx, out float cy)
	{
		cx = default;
		cy = default;
	}

	public static bool IsContainPoint(Vector3D[] v, float x, float z)
	{
		return false;
	}

	public static bool IsContainPoint(PointF[] v, float x, float z)
	{
		return false;
	}

	public static float VecToAngle(float x, float z)
	{
		return 0f;
	}

	public static float VecToAngle(float v1x, float v1y, float v2x, float v2y)
	{
		return 0f;
	}

	public static float[] TransPoint(float x, float y, float z, Transform viewMatrix, int viewAngle)
	{
		return null;
	}

	public static int DotProduct(int ax, int ay, int bx, int by, int cx, int cy, int dx, int dy)
	{
		return 0;
	}

	public static int DotProduct(int ax, int ay, int bx, int by, int cx, int cy)
	{
		return 0;
	}

	public static float DotProduct(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy)
	{
		return 0f;
	}

	public static float DotProduct(float ax, float ay, float bx, float by, float cx, float cy)
	{
		return 0f;
	}

	public static float DotProduct(float v1x, float v1y, float v2x, float v2y)
	{
		return 0f;
	}

	public static int Pow(int x, int y)
	{
		return 0;
	}

	public static long Sqrt(long c)
	{
		return 0L;
	}

	public static float Cbrt(float c)
	{
		return 0f;
	}

	public static void Sort(int[] list)
	{
	}

	public static int[][] QSort(int[][] data, int target, bool upOrDown)
	{
		return null;
	}

	private static int Pivot(int[][] a, int i, int j, int target)
	{
		return 0;
	}

	private static int Partition(int[][] a, int i, int j, int x, int target)
	{
		return 0;
	}

	private static void QuickSort(int[][] a, int i, int j, int target)
	{
	}

	public static float[] GetInscribedCircle(float ax, float ay, float bx, float by, float cx, float cy)
	{
		return null;
	}

	public static float[] GetInscribedCircle(float ax, float ay, float bx, float by, float cx, float cy, float[] vout)
	{
		return null;
	}

	public static float[] GetCircumscribedCircle(float ax, float ay, float bx, float by, float cx, float cy)
	{
		return null;
	}

	public static float[] GetCircumscribedCircle(float ax, float ay, float bx, float by, float cx, float cy, float[] vout)
	{
		return null;
	}

	public static float[] GetEscribedCircle(float ax, float ay, float bx, float by, float cx, float cy)
	{
		return null;
	}

	public static float[] GetEscribedCircle(float ax, float ay, float bx, float by, float cx, float cy, float[] vout)
	{
		return null;
	}

	public static float[] GetEscribedCircle(float ax, float ay, float bx, float by, float cx, float cy, int side)
	{
		return null;
	}

	public static float[] GetEscribedCircle(float ax, float ay, float bx, float by, float cx, float cy, int side, float[] vout)
	{
		return null;
	}

	public static float GetTriangleArea(float ax, float ay, float bx, float by, float cx, float cy)
	{
		return 0f;
	}

	public static int GetLineSide(float px, float py, float x1, float y1, float x2, float y2)
	{
		return 0;
	}

	public static float GetDifferenceAngle(float angle1, float angle2)
	{
		return 0f;
	}

	public static Vector3D GetNormalVector(Vector3D p1, Vector3D p2, Vector3D p3)
	{
		return null;
	}

	public static float[] GetNormalVector2D(float x1, float y1, float x2, float y2)
	{
		return null;
	}

	public static PointF GetNormalVector2D(PointF v1, PointF v2)
	{
		return default;
	}

	public static float GetArrivalAngle(float speed, float gravity, float distance)
	{
		return 0f;
	}

	public static float GetArrivalDistance(float speed, float gravity, float angle)
	{
		return 0f;
	}

	public static float GetArrivalSpeed(float gravity, float angle, float distance)
	{
		return 0f;
	}

	public static float GetDistance(float x1, float y1, float x2, float y2)
	{
		return 0f;
	}

	public static float GetDistanceSq(float x1, float y1, float x2, float y2)
	{
		return 0f;
	}

	public static List<Point> GetLine(int x1, int y1, int x2, int y2)
	{
		return null;
	}

	public static List<Point> GetLine(int x1, int y1, int x2, int y2, out bool isXInc)
	{
		isXInc = default;
		return null;
	}
}

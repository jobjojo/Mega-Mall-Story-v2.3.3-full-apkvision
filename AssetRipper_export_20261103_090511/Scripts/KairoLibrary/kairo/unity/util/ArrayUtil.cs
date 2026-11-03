using System;
using System.Collections;
using System.Collections.Generic;
using java.util;
using kairo.unity.type;

namespace kairo.unity.util;

public class ArrayUtil
{
	public delegate long CompareMethod<T>(T x, T y);

	public delegate bool EqualsMethod<TVal, TKey>(TVal x, TKey y);

	public delegate void ChangeMethod(int x, int y);

	public delegate bool CheckTrimMethod(int xi, int yi);

	private static object lock_;

	private static int quickBufferSize_;

	private static List<int[]> quickBuffer_;

	private ArrayUtil()
	{
	}

	public static void Sort<T>(IList<T> ary, CompareMethod<T> compare = null, ChangeMethod change = null)
	{
	}

	public static void Sort<T>(IList<T> ary, int index, int length = -1, CompareMethod<T> compare = null, ChangeMethod change = null)
	{
	}

	public static void QuickSort<T>(IList<T> ary, CompareMethod<T> compare = null, ChangeMethod change = null)
	{
	}

	public static void QuickSort<T>(IList<T> ary, int index, int length = -1, CompareMethod<T> compare = null, ChangeMethod change = null)
	{
	}

	private static void PushQuickBuffer(int v1, int v2)
	{
	}

	private static CompareMethod<T> GetCompareMethod<T>(IList<T> ary)
	{
		return null;
	}

	public static T MakeArray<T>(params int[] counts)
	{
		return default;
	}

	public static int Search<T>(IList<T> ary, T key, CompareMethod<T> compare = null)
	{
		return 0;
	}

	public static int Search<T>(IList<T> ary, T key, int index, int length, CompareMethod<T> compare = null)
	{
		return 0;
	}

	public static int Search<TAry, TKey>(IList<TAry> ary, TKey key, EqualsMethod<TAry, TKey> equals)
	{
		return 0;
	}

	public static int Search<TAry, TKey>(IList<TAry> ary, TKey key, int index, int length, EqualsMethod<TAry, TKey> equals)
	{
		return 0;
	}

	public static void Change(Vector list, int index1, int index2)
	{
	}

	public static void Change(FastVector list, int index1, int index2)
	{
	}

	public static void Change(IList list, int index1, int index2)
	{
	}

	public static T[] Expand<T>(T[] ary, int newLength)
	{
		return null;
	}

	public static void Init<T>(IList<T> ary, T value = default(T))
	{
	}

	public static void Init<T>(T[] ary, T value = default(T))
	{
	}

	public static T[] Copy<T>(T[] ary)
	{
		return null;
	}

	public static bool Equals<T>(T[] a, T[] b) where T : IComparable
	{
		return false;
	}

	public static T[] Remove<T>(T[] ary, int index)
	{
		return null;
	}

	public static T[] Insert<T>(T[] ary, int index, T item)
	{
		return null;
	}

	public static T[] Add<T>(T[] ary, T item)
	{
		return null;
	}

	public static void Shuffle<T>(IList<T> ary)
	{
	}

	public static int GetHigh(int[] ary)
	{
		return 0;
	}

	public static int GetLow(int[] ary)
	{
		return 0;
	}

	public static int GetHighIndex(int[] ary)
	{
		return 0;
	}

	public static int GetLowIndex(int[] ary)
	{
		return 0;
	}

	public static int[] GetHighIndices(int[] ary)
	{
		return null;
	}

	public static int[] GetLowIndices(int[] ary)
	{
		return null;
	}

	public static Rect GetTrimArea(int width, int height, CheckTrimMethod method)
	{
		return default;
	}
}

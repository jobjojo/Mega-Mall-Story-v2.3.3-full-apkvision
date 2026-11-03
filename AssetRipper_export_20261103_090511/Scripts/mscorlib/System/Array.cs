using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System;

[Serializable]
public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
{
	private sealed class ArrayEnumerator : IEnumerator, ICloneable
	{
		private Array _array;

		private int _index;

		private int _endIndex;

		public object Current => null;

		internal ArrayEnumerator(Array array)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public object Clone()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0)]
	private class RawData
	{
		public IntPtr Bounds;

		public IntPtr Count;

		public byte Data;
	}

	internal struct InternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Array array = null;

		private int idx = 0;

		public T Current => default;

		object IEnumerator.Current => null;

		internal InternalEnumerator(Array array)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	internal class EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
	{
		public static readonly EmptyInternalEnumerator<T> Value;

		public T Current => default;

		object IEnumerator.Current => null;

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	private struct SorterObjectArray
	{
		private object[] keys = null;

		private object[] items = null;

		private IComparer comparer = null;

		internal SorterObjectArray(object[] keys, object[] items, IComparer comparer)
		{
		}

		internal void SwapIfGreaterWithItems(int a, int b)
		{
		}

		private void Swap(int i, int j)
		{
		}

		internal void Sort(int left, int length)
		{
		}

		private void IntrospectiveSort(int left, int length)
		{
		}

		private void IntroSort(int lo, int hi, int depthLimit)
		{
		}

		private int PickPivotAndPartition(int lo, int hi)
		{
			return 0;
		}

		private void Heapsort(int lo, int hi)
		{
		}

		private void DownHeap(int i, int n, int lo)
		{
		}

		private void InsertionSort(int lo, int hi)
		{
		}
	}

	private struct SorterGenericArray
	{
		private Array keys = null;

		private Array items = null;

		private IComparer comparer = null;

		internal SorterGenericArray(Array keys, Array items, IComparer comparer)
		{
		}

		internal void SwapIfGreaterWithItems(int a, int b)
		{
		}

		private void Swap(int i, int j)
		{
		}

		internal void Sort(int left, int length)
		{
		}

		private void IntrospectiveSort(int left, int length)
		{
		}

		private void IntroSort(int lo, int hi, int depthLimit)
		{
		}

		private int PickPivotAndPartition(int lo, int hi)
		{
			return 0;
		}

		private void Heapsort(int lo, int hi)
		{
		}

		private void DownHeap(int i, int n, int lo)
		{
		}

		private void InsertionSort(int lo, int hi)
		{
		}
	}

	int ICollection.Count => 0;

	bool IList.IsReadOnly => false;

	object IList.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long LongLength => 0L;

	public bool IsFixedSize => false;

	public bool IsReadOnly => false;

	public bool IsSynchronized => false;

	public object SyncRoot => null;

	public int Length
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	public int Rank
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	public static Array CreateInstance(Type elementType, params long[] lengths)
	{
		return null;
	}

	public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
	{
		return null;
	}

	public static void Resize<T>(ref T[] array, int newSize)
	{
	}

	int IList.Add(object value)
	{
		return 0;
	}

	bool IList.Contains(object value)
	{
		return false;
	}

	void IList.Clear()
	{
	}

	int IList.IndexOf(object value)
	{
		return 0;
	}

	void IList.Insert(int index, object value)
	{
	}

	void IList.Remove(object value)
	{
	}

	void IList.RemoveAt(int index)
	{
	}

	public void CopyTo(Array array, int index)
	{
	}

	public object Clone()
	{
		return null;
	}

	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	internal static int CombineHashCodes(int h1, int h2)
	{
		return 0;
	}

	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	public static int BinarySearch(Array array, object value)
	{
		return 0;
	}

	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
	{
		return null;
	}

	public static void Copy(Array sourceArray, Array destinationArray, long length)
	{
	}

	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
	{
	}

	public void CopyTo(Array array, long index)
	{
	}

	public static void ForEach<T>(T[] array, Action<T> action)
	{
	}

	public long GetLongLength(int dimension)
	{
		return 0L;
	}

	public object GetValue(long index)
	{
		return null;
	}

	public object GetValue(long index1, long index2)
	{
		return null;
	}

	public object GetValue(long index1, long index2, long index3)
	{
		return null;
	}

	public object GetValue(params long[] indices)
	{
		return null;
	}

	public static int BinarySearch(Array array, int index, int length, object value)
	{
		return 0;
	}

	public static int BinarySearch(Array array, object value, IComparer comparer)
	{
		return 0;
	}

	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer)
	{
		return 0;
	}

	private static int GetMedian(int low, int hi)
	{
		return 0;
	}

	public static int BinarySearch<T>(T[] array, T value)
	{
		return 0;
	}

	public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
	{
		return 0;
	}

	public static int BinarySearch<T>(T[] array, int index, int length, T value)
	{
		return 0;
	}

	public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
	{
		return 0;
	}

	public static int IndexOf(Array array, object value)
	{
		return 0;
	}

	public static int IndexOf(Array array, object value, int startIndex)
	{
		return 0;
	}

	public static int IndexOf(Array array, object value, int startIndex, int count)
	{
		return 0;
	}

	public static int IndexOf<T>(T[] array, T value)
	{
		return 0;
	}

	public static int IndexOf<T>(T[] array, T value, int startIndex)
	{
		return 0;
	}

	public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	public static int LastIndexOf(Array array, object value)
	{
		return 0;
	}

	public static int LastIndexOf(Array array, object value, int startIndex)
	{
		return 0;
	}

	public static int LastIndexOf(Array array, object value, int startIndex, int count)
	{
		return 0;
	}

	public static int LastIndexOf<T>(T[] array, T value)
	{
		return 0;
	}

	public static int LastIndexOf<T>(T[] array, T value, int startIndex)
	{
		return 0;
	}

	public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	public static void Reverse(Array array)
	{
	}

	public static void Reverse(Array array, int index, int length)
	{
	}

	public static void Reverse<T>(T[] array)
	{
	}

	public static void Reverse<T>(T[] array, int index, int length)
	{
	}

	public void SetValue(object value, long index)
	{
	}

	public void SetValue(object value, long index1, long index2)
	{
	}

	public void SetValue(object value, long index1, long index2, long index3)
	{
	}

	public void SetValue(object value, params long[] indices)
	{
	}

	public static void Sort(Array array)
	{
	}

	public static void Sort(Array array, int index, int length)
	{
	}

	public static void Sort(Array array, IComparer comparer)
	{
	}

	public static void Sort(Array array, int index, int length, IComparer comparer)
	{
	}

	public static void Sort(Array keys, Array items)
	{
	}

	public static void Sort(Array keys, Array items, IComparer comparer)
	{
	}

	public static void Sort(Array keys, Array items, int index, int length)
	{
	}

	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
	{
	}

	public static void Sort<T>(T[] array)
	{
	}

	public static void Sort<T>(T[] array, int index, int length)
	{
	}

	public static void Sort<T>(T[] array, IComparer<T> comparer)
	{
	}

	public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer)
	{
	}

	public static void Sort<T>(T[] array, Comparison<T> comparison)
	{
	}

	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
	{
	}

	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
	{
	}

	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
	{
	}

	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer)
	{
	}

	public static bool Exists<T>(T[] array, Predicate<T> match)
	{
		return false;
	}

	public static void Fill<T>(T[] array, T value)
	{
	}

	public static void Fill<T>(T[] array, T value, int startIndex, int count)
	{
	}

	public static T Find<T>(T[] array, Predicate<T> match)
	{
		return default;
	}

	public static T[] FindAll<T>(T[] array, Predicate<T> match)
	{
		return null;
	}

	public static int FindIndex<T>(T[] array, Predicate<T> match)
	{
		return 0;
	}

	public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match)
	{
		return 0;
	}

	public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
	{
		return 0;
	}

	public static T FindLast<T>(T[] array, Predicate<T> match)
	{
		return default;
	}

	public static int FindLastIndex<T>(T[] array, Predicate<T> match)
	{
		return 0;
	}

	public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match)
	{
		return 0;
	}

	public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
	{
		return 0;
	}

	public static bool TrueForAll<T>(T[] array, Predicate<T> match)
	{
		return false;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	private Array()
	{
	}

	internal int InternalArray__ICollection_get_Count()
	{
		return 0;
	}

	internal bool InternalArray__ICollection_get_IsReadOnly()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref byte GetRawSzArrayData()
	{
		throw null;
	}

	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
	{
		return null;
	}

	internal void InternalArray__ICollection_Clear()
	{
	}

	internal void InternalArray__ICollection_Add<T>(T item)
	{
	}

	internal bool InternalArray__ICollection_Remove<T>(T item)
	{
		return false;
	}

	internal bool InternalArray__ICollection_Contains<T>(T item)
	{
		return false;
	}

	internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
	{
	}

	internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
	{
		return default;
	}

	internal int InternalArray__IReadOnlyCollection_get_Count()
	{
		return 0;
	}

	internal void InternalArray__Insert<T>(int index, T item)
	{
	}

	internal void InternalArray__RemoveAt(int index)
	{
	}

	internal int InternalArray__IndexOf<T>(T item)
	{
		return 0;
	}

	internal T InternalArray__get_Item<T>(int index)
	{
		return default;
	}

	internal void InternalArray__set_Item<T>(int index, T item)
	{
	}

	internal void GetGenericValueImpl<T>(int pos, out T value)
	{
		value = default;
	}

	internal void SetGenericValueImpl<T>(int pos, ref T value)
	{
	}

	private int GetRank()
	{
		return 0;
	}

	public int GetLength(int dimension)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public int GetLowerBound(int dimension)
	{
		return 0;
	}

	public object GetValue(params int[] indices)
	{
		return null;
	}

	public void SetValue(object value, params int[] indices)
	{
	}

	internal object GetValueImpl(int pos)
	{
		return null;
	}

	internal void SetValueImpl(object value, int pos)
	{
	}

	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length)
	{
		return false;
	}

	internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds)
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public int GetUpperBound(int dimension)
	{
		return 0;
	}

	public object GetValue(int index)
	{
		return null;
	}

	public object GetValue(int index1, int index2)
	{
		return null;
	}

	public object GetValue(int index1, int index2, int index3)
	{
		return null;
	}

	public void SetValue(object value, int index)
	{
	}

	public void SetValue(object value, int index1, int index2)
	{
	}

	public void SetValue(object value, int index1, int index2, int index3)
	{
	}

	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
	{
		return null;
	}

	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2)
	{
		return null;
	}

	internal static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
	{
		return null;
	}

	public static Array CreateInstance(Type elementType, int length)
	{
		return null;
	}

	public static Array CreateInstance(Type elementType, int length1, int length2)
	{
		return null;
	}

	public static Array CreateInstance(Type elementType, int length1, int length2, int length3)
	{
		return null;
	}

	public static Array CreateInstance(Type elementType, params int[] lengths)
	{
		return null;
	}

	public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void Clear(Array array, int index, int length)
	{
	}

	private static void ClearInternal(Array a, int index, int count)
	{
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static void Copy(Array sourceArray, Array destinationArray, int length)
	{
	}

	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
	{
	}

	private static ArrayTypeMismatchException CreateArrayTypeMismatchException()
	{
		return null;
	}

	private static bool CanAssignArrayElement(Type source, Type target)
	{
		return false;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
	{
	}

	public static T[] Empty<T>()
	{
		return null;
	}

	public void Initialize()
	{
	}

	private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
	{
	}

	internal static T UnsafeLoad<T>(T[] array, int index)
	{
		return default;
	}

	internal static void UnsafeStore<T>(T[] array, int index, T value)
	{
	}

	internal static R UnsafeMov<S, R>(S instance)
	{
		return default;
	}
}

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

[DebuggerTypeProxy(typeof(SpanDebugView<>))]
[DebuggerDisplay("{ToString(),raw}")]
[NonVersionable]
public readonly ref struct Span<T>
{
	internal readonly ByReference<T> _pointer = default;

	private readonly int _length = 0;

	public ref T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Intrinsic]
		[NonVersionable]
		get
		{
			throw null;
		}
	}

	public int Length
	{
		[NonVersionable]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span(T[] array)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span(T[] array, int start, int length)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public unsafe Span(void* pointer, int length)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Span(ref T ptr, int length)
	{
	}

	public ref T GetPinnableReference()
	{
		throw null;
	}

	public void CopyTo(Span<T> destination)
	{
	}

	public bool TryCopyTo(Span<T> destination)
	{
		return false;
	}

	public static implicit operator ReadOnlySpan<T>(Span<T> span)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<T> Slice(int start)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<T> Slice(int start, int length)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T[] ToArray()
	{
		return null;
	}

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	public override int GetHashCode()
	{
		return 0;
	}

	public static implicit operator Span<T>(T[] array)
	{
		return default;
	}
}

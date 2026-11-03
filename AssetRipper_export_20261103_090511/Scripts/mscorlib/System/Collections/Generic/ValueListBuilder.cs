using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[DefaultMember("Item")]
internal ref struct ValueListBuilder<T>(Span<T> initialSpan)
{
	private Span<T> _span = default;

	private T[] _arrayFromPool = null;

	private int _pos = 0;

	public int Length => 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Append(T item)
	{
	}

	public ReadOnlySpan<T> AsSpan()
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Dispose()
	{
	}

	private void Grow()
	{
	}
}

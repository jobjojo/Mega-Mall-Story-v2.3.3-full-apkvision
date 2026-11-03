using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
[StructLayout((LayoutKind)0)]
public sealed class StringBuilder : ISerializable
{
	internal char[] m_ChunkChars;

	internal StringBuilder m_ChunkPrevious;

	internal int m_ChunkLength;

	internal int m_ChunkOffset;

	internal int m_MaxCapacity;

	internal const int DefaultCapacity = 16;

	private const string CapacityField = "Capacity";

	private const string MaxCapacityField = "m_MaxCapacity";

	private const string StringValueField = "m_StringValue";

	private const string ThreadIDField = "m_currentThread";

	internal const int MaxChunkSize = 8000;

	private const int IndexLimit = 1000000;

	private const int WidthLimit = 1000000;

	public int Capacity => 0;

	public int MaxCapacity => 0;

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[IndexerName("Chars")]
	public char this[int index]
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	private Span<char> RemainingCurrentChunk
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public StringBuilder()
	{
	}

	public StringBuilder(int capacity)
	{
	}

	public StringBuilder(string value)
	{
	}

	public StringBuilder(string value, int capacity)
	{
	}

	public StringBuilder(string value, int startIndex, int length, int capacity)
	{
	}

	public StringBuilder(int capacity, int maxCapacity)
	{
	}

	private StringBuilder(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(int startIndex, int length)
	{
		return null;
	}

	public StringBuilder Clear()
	{
		return null;
	}

	public StringBuilder Append(char value, int repeatCount)
	{
		return null;
	}

	public StringBuilder Append(char[] value, int startIndex, int charCount)
	{
		return null;
	}

	public StringBuilder Append(string value)
	{
		return null;
	}

	private void AppendHelper(string value)
	{
	}

	public StringBuilder Append(string value, int startIndex, int count)
	{
		return null;
	}

	public StringBuilder Append(StringBuilder value)
	{
		return null;
	}

	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
	{
		return null;
	}

	public StringBuilder AppendLine()
	{
		return null;
	}

	public void CopyTo(int sourceIndex, Span<char> destination, int count)
	{
	}

	public StringBuilder Remove(int startIndex, int length)
	{
		return null;
	}

	public StringBuilder Append(char value)
	{
		return null;
	}

	public StringBuilder Append(int value)
	{
		return null;
	}

	public StringBuilder Append(long value)
	{
		return null;
	}

	[CLSCompliant(false)]
	public StringBuilder Append(uint value)
	{
		return null;
	}

	private StringBuilder AppendSpanFormattable<T>(T value) where T : IFormattable
	{
		return null;
	}

	public StringBuilder Append(object value)
	{
		return null;
	}

	public StringBuilder Append(ReadOnlySpan<char> value)
	{
		return null;
	}

	public StringBuilder Insert(int index, string value)
	{
		return null;
	}

	public StringBuilder Insert(int index, char value)
	{
		return null;
	}

	public StringBuilder AppendFormat(string format, object arg0)
	{
		return null;
	}

	public StringBuilder AppendFormat(string format, object arg0, object arg1)
	{
		return null;
	}

	public StringBuilder AppendFormat(string format, params object[] args)
	{
		return null;
	}

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
	{
		return null;
	}

	private static void FormatError()
	{
	}

	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		return null;
	}

	[CLSCompliant(false)]
	public unsafe StringBuilder Append(char* value, int valueCount)
	{
		return null;
	}

	private unsafe void Insert(int index, char* value, int valueCount)
	{
	}

	private unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
	{
	}

	private unsafe static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count)
	{
	}

	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count)
	{
	}

	private StringBuilder FindChunkForIndex(int index)
	{
		return null;
	}

	private StringBuilder Next(StringBuilder chunk)
	{
		return null;
	}

	private void ExpandByABlock(int minBlockCharCount)
	{
	}

	private StringBuilder(StringBuilder from)
	{
	}

	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars)
	{
		chunk = null;
		indexInChunk = default;
	}

	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
	{
	}

	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
	{
		chunk = null;
		indexInChunk = default;
	}
}

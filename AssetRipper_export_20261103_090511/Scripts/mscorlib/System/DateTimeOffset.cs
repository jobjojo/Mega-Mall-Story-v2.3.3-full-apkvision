using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[StructLayout((LayoutKind)3)]
public readonly struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	public static readonly DateTimeOffset MinValue;

	public static readonly DateTimeOffset MaxValue;

	public static readonly DateTimeOffset UnixEpoch;

	private readonly DateTime _dateTime = default;

	private readonly short _offsetMinutes = 0;

	public DateTime UtcDateTime => default;

	private DateTime ClockDateTime => default;

	public TimeSpan Offset => default;

	public DateTimeOffset(long ticks, TimeSpan offset)
	{
	}

	public DateTimeOffset(DateTime dateTime)
	{
	}

	public DateTimeOffset(DateTime dateTime, TimeSpan offset)
	{
	}

	public DateTimeOffset AddTicks(long ticks)
	{
		return default;
	}

	int IComparable.CompareTo(object obj)
	{
		return 0;
	}

	public int CompareTo(DateTimeOffset other)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(DateTimeOffset other)
	{
		return false;
	}

	public static DateTimeOffset FromFileTime(long fileTime)
	{
		return default;
	}

	public static DateTimeOffset FromUnixTimeSeconds(long seconds)
	{
		return default;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private DateTimeOffset(SerializationInfo info, StreamingContext context)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public DateTimeOffset ToLocalTime()
	{
		return default;
	}

	internal DateTimeOffset ToLocalTime(bool throwOnOverflow)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
	{
		charsWritten = default;
		return false;
	}

	private static short ValidateOffset(TimeSpan offset)
	{
		return 0;
	}

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
	{
		return default;
	}
}

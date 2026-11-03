using System.Text;

namespace System;

[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
{
	private readonly int _Major;

	private readonly int _Minor;

	private readonly int _Build;

	private readonly int _Revision;

	public int Major => 0;

	public int Minor => 0;

	public int Build => 0;

	public int Revision => 0;

	private int DefaultFormatFieldCount => 0;

	public Version(int major, int minor, int build, int revision)
	{
	}

	public Version(int major, int minor, int build)
	{
	}

	public Version(int major, int minor)
	{
	}

	public Version(string version)
	{
	}

	public Version()
	{
	}

	private Version(Version version)
	{
	}

	public object Clone()
	{
		return null;
	}

	public int CompareTo(object version)
	{
		return 0;
	}

	public int CompareTo(Version value)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Version obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(int fieldCount)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten)
	{
		charsWritten = default;
		return false;
	}

	public bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten)
	{
		charsWritten = default;
		return false;
	}

	bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		charsWritten = default;
		return false;
	}

	private StringBuilder ToCachedStringBuilder(int fieldCount)
	{
		return null;
	}

	public static Version Parse(string input)
	{
		return null;
	}

	private static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure)
	{
		return null;
	}

	private static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent)
	{
		parsedComponent = default;
		return false;
	}

	public static bool operator ==(Version v1, Version v2)
	{
		return false;
	}

	public static bool operator !=(Version v1, Version v2)
	{
		return false;
	}
}

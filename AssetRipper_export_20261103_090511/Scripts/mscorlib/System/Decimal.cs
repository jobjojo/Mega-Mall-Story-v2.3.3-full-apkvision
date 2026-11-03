using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[StructLayout((LayoutKind)2)]
public readonly struct Decimal : IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>, IDeserializationCallback, ISpanFormattable
{
	[StructLayout((LayoutKind)2)]
	private struct DecCalc
	{
		internal enum RoundingMode
		{
			ToEven = 0,
			AwayFromZero = 1,
			Truncate = 2,
			Floor = 3,
			Ceiling = 4
		}

		private struct PowerOvfl(uint hi, uint mid, uint lo)
		{
			public readonly uint Hi = 0u;

			public readonly ulong MidLo = 0uL;
		}

		[FieldOffset(0)]
		private uint uflags;

		[FieldOffset(4)]
		private uint uhi;

		[FieldOffset(8)]
		private uint ulo;

		[FieldOffset(12)]
		private uint umid;

		[FieldOffset(8)]
		private ulong ulomidLE;

		private static readonly uint[] s_powers10;

		private static readonly ulong[] s_ulongPowers10;

		private static readonly double[] s_doublePowers10;

		private static readonly PowerOvfl[] PowerOvflValues;

		private uint High
		{
			set
			{
			}
		}

		private uint Low
		{
			set
			{
			}
		}

		private uint Mid
		{
			set
			{
			}
		}

		private bool IsNegative => false;

		private ulong Low64
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		private static uint GetExponent(float f)
		{
			return 0u;
		}

		private static uint GetExponent(double d)
		{
			return 0u;
		}

		private static ulong UInt32x32To64(uint a, uint b)
		{
			return 0uL;
		}

		private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Unscale(ref uint low, ref ulong high64, ref int scale)
		{
		}

		internal static int VarDecCmp(in decimal d1, in decimal d2)
		{
			return 0;
		}

		private static int VarDecCmpSub(in decimal d1, in decimal d2)
		{
			return 0;
		}

		internal static void VarDecFromR4(float input, out DecCalc result)
		{
			result = default;
		}

		internal static void VarDecFromR8(double input, out DecCalc result)
		{
			result = default;
		}

		internal static float VarR4FromDec(in decimal value)
		{
			return 0f;
		}

		internal static double VarR8FromDec(in decimal value)
		{
			return 0.0;
		}

		internal static int GetHashCode(in decimal d)
		{
			return 0;
		}

		internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode)
		{
		}

		internal static uint DecDivMod1E9(ref DecCalc value)
		{
			return 0u;
		}
	}

	public const decimal Zero = 0m;

	public const decimal One = 1m;

	public const decimal MinusOne = -1m;

	public const decimal MaxValue = 79228162514264337593543950335m;

	public const decimal MinValue = -79228162514264337593543950335m;

	[FieldOffset(0)]
	private readonly int flags = 0;

	[FieldOffset(4)]
	private readonly int hi = 0;

	[FieldOffset(8)]
	private readonly int lo = 0;

	[FieldOffset(12)]
	private readonly int mid = 0;

	[FieldOffset(8)]
	[NonSerialized]
	private readonly ulong ulomidLE = 0uL;

	internal uint High => 0u;

	internal uint Low => 0u;

	internal uint Mid => 0u;

	internal bool IsNegative => false;

	internal int Scale => 0;

	private ulong Low64 => 0uL;

	private static ref DecCalc AsMutable(ref decimal d)
	{
		throw null;
	}

	internal static uint DecDivMod1E9(ref decimal value)
	{
		return 0u;
	}

	public Decimal(int value)
	{
	}

	[CLSCompliant(false)]
	public Decimal(uint value)
	{
	}

	public Decimal(long value)
	{
	}

	[CLSCompliant(false)]
	public Decimal(ulong value)
	{
	}

	public Decimal(float value)
	{
	}

	public Decimal(double value)
	{
	}

	private static bool IsValid(int flags)
	{
		return false;
	}

	public Decimal(int[] bits)
	{
	}

	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
	{
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	public int CompareTo(object value)
	{
		return 0;
	}

	public int CompareTo(decimal value)
	{
		return 0;
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public bool Equals(decimal value)
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

	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default;
		return false;
	}

	public static decimal Parse(string s, IFormatProvider provider)
	{
		return 0m;
	}

	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		return 0m;
	}

	public static bool TryParse(string s, out decimal result)
	{
		result = 0m;
		return false;
	}

	public static decimal Round(decimal d, int decimals)
	{
		return 0m;
	}

	private static decimal Round(ref decimal d, int decimals, MidpointRounding mode)
	{
		return 0m;
	}

	public static byte ToByte(decimal value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(decimal value)
	{
		return 0;
	}

	public static short ToInt16(decimal value)
	{
		return 0;
	}

	public static double ToDouble(decimal d)
	{
		return 0.0;
	}

	public static int ToInt32(decimal d)
	{
		return 0;
	}

	public static long ToInt64(decimal d)
	{
		return 0L;
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(decimal value)
	{
		return 0;
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(decimal d)
	{
		return 0u;
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(decimal d)
	{
		return 0uL;
	}

	public static float ToSingle(decimal d)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void Truncate(ref decimal d)
	{
	}

	public static implicit operator decimal(byte value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static implicit operator decimal(sbyte value)
	{
		return 0m;
	}

	public static implicit operator decimal(short value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static implicit operator decimal(ushort value)
	{
		return 0m;
	}

	public static implicit operator decimal(int value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static implicit operator decimal(uint value)
	{
		return 0m;
	}

	public static implicit operator decimal(long value)
	{
		return 0m;
	}

	[CLSCompliant(false)]
	public static implicit operator decimal(ulong value)
	{
		return 0m;
	}

	public static explicit operator decimal(float value)
	{
		return 0m;
	}

	public static explicit operator decimal(double value)
	{
		return 0m;
	}

	public static explicit operator float(decimal value)
	{
		return 0f;
	}

	public static explicit operator double(decimal value)
	{
		return 0.0;
	}

	public static bool operator !=(decimal d1, decimal d2)
	{
		return false;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Empty;
	}

	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return 0m;
	}

	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default;
	}

	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}
}

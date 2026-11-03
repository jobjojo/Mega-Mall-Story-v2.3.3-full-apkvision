using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ComVisible(true)]
public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible
{
	private enum ParseFailureKind
	{
		None = 0,
		Argument = 1,
		ArgumentNull = 2,
		ArgumentWithParameter = 3,
		UnhandledException = 4
	}

	private struct EnumResult
	{
		internal object parsedEnum;

		internal bool canThrow;

		internal ParseFailureKind m_failure;

		internal string m_failureMessageID;

		internal string m_failureParameter;

		internal object m_failureMessageFormatArgument;

		internal Exception m_innerException;

		internal void Init(bool canMethodThrow)
		{
		}

		internal void SetFailure(Exception unhandledException)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureParameter)
		{
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
		}

		internal Exception GetEnumParseException()
		{
			return null;
		}
	}

	private class ValuesAndNames
	{
		public ulong[] Values;

		public string[] Names;

		public ValuesAndNames(ulong[] values, string[] names)
		{
		}
	}

	private static readonly char[] enumSeperatorCharArray;

	private const string enumSeperator = ", ";

	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
	{
		return null;
	}

	private static string InternalFormattedHexString(object value)
	{
		return null;
	}

	private static string InternalFormat(RuntimeType eT, object value)
	{
		return null;
	}

	private static string InternalFlagsFormat(RuntimeType eT, object value)
	{
		return null;
	}

	internal static ulong ToUInt64(object value)
	{
		return 0uL;
	}

	private static int InternalCompareTo(object o1, object o2)
	{
		return 0;
	}

	internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType)
	{
		return null;
	}

	private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names)
	{
		values = null;
		names = null;
		return false;
	}

	private static object InternalBoxEnum(RuntimeType enumType, long value)
	{
		return null;
	}

	[ComVisible(true)]
	public static object Parse(Type enumType, string value)
	{
		return null;
	}

	[ComVisible(true)]
	public static object Parse(Type enumType, string value, bool ignoreCase)
	{
		return null;
	}

	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult)
	{
		return false;
	}

	[ComVisible(true)]
	public static Type GetUnderlyingType(Type enumType)
	{
		return null;
	}

	[ComVisible(true)]
	public static Array GetValues(Type enumType)
	{
		return null;
	}

	internal static ulong[] InternalGetValues(RuntimeType enumType)
	{
		return null;
	}

	[ComVisible(true)]
	public static string GetName(Type enumType, object value)
	{
		return null;
	}

	internal static string[] InternalGetNames(RuntimeType enumType)
	{
		return null;
	}

	[ComVisible(true)]
	public static object ToObject(Type enumType, object value)
	{
		return null;
	}

	[ComVisible(true)]
	public static bool IsDefined(Type enumType, object value)
	{
		return false;
	}

	private object get_value()
	{
		return null;
	}

	internal object GetValue()
	{
		return null;
	}

	private bool InternalHasFlag(Enum flags)
	{
		return false;
	}

	private int get_hashcode()
	{
		return 0;
	}

	public override bool Equals(object obj)
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

	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public int CompareTo(object target)
	{
		return 0;
	}

	public string ToString(string format)
	{
		return null;
	}

	[Obsolete("The provider argument is not used. Please use ToString().")]
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	public bool HasFlag(Enum flag)
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

	[ComVisible(true)]
	[CLSCompliant(false)]
	public static object ToObject(Type enumType, sbyte value)
	{
		return null;
	}

	[ComVisible(true)]
	public static object ToObject(Type enumType, short value)
	{
		return null;
	}

	[ComVisible(true)]
	public static object ToObject(Type enumType, int value)
	{
		return null;
	}

	[ComVisible(true)]
	public static object ToObject(Type enumType, byte value)
	{
		return null;
	}

	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, ushort value)
	{
		return null;
	}

	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, uint value)
	{
		return null;
	}

	[ComVisible(true)]
	public static object ToObject(Type enumType, long value)
	{
		return null;
	}

	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, ulong value)
	{
		return null;
	}

	private static object ToObject(Type enumType, char value)
	{
		return null;
	}

	private static object ToObject(Type enumType, bool value)
	{
		return null;
	}
}

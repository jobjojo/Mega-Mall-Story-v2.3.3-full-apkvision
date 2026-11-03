using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization;

public class FormatterConverter : IFormatterConverter
{
	public object Convert(object value, Type type)
	{
		return null;
	}

	public bool ToBoolean(object value)
	{
		return false;
	}

	public int ToInt32(object value)
	{
		return 0;
	}

	public long ToInt64(object value)
	{
		return 0L;
	}

	public float ToSingle(object value)
	{
		return 0f;
	}

	public string ToString(object value)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowValueNullException()
	{
	}
}

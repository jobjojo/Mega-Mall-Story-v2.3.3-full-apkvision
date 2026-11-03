namespace System.ComponentModel;

public class ReferenceConverter : TypeConverter
{
	private static readonly string s_none;

	private Type _type;

	public ReferenceConverter(Type type)
	{
	}
}

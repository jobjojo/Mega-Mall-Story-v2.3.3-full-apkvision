namespace System.ComponentModel;

public class EnumConverter : TypeConverter
{
	private StandardValuesCollection values;

	private Type type;

	public EnumConverter(Type type)
	{
	}
}

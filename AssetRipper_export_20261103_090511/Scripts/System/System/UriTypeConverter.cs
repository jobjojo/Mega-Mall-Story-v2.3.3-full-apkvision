using System.ComponentModel;

namespace System;

public class UriTypeConverter : TypeConverter
{
	private bool CanConvert(Type type)
	{
		return false;
	}
}

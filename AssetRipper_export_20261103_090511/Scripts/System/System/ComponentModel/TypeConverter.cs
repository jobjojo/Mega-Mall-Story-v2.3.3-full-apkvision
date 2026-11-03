using System.Reflection;
using System.Runtime.InteropServices;

namespace System.ComponentModel;

[ComVisible(true)]
public class TypeConverter
{
	[DefaultMember("Item")]
	public class StandardValuesCollection
	{
	}

	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

	private static bool useCompatibleTypeConversion;
}

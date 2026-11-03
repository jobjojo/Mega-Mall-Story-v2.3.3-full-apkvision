namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class TypeConverterAttribute : Attribute
{
	public static readonly TypeConverterAttribute Default;

	public string ConverterTypeName { get; }

	public TypeConverterAttribute()
	{
	}

	public TypeConverterAttribute(Type type)
	{
	}

	public TypeConverterAttribute(string typeName)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

namespace System.Runtime.Serialization;

public readonly struct SerializationEntry
{
	private readonly string _name = null;

	private readonly object _value = null;

	private readonly Type _type = null;

	public object Value => null;

	public string Name => null;

	internal SerializationEntry(string entryName, object entryValue, Type entryType)
	{
	}
}

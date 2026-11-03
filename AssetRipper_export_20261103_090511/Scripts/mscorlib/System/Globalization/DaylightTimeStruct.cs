namespace System.Globalization;

internal readonly struct DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
{
	public readonly DateTime Start = default;

	public readonly DateTime End = default;

	public readonly TimeSpan Delta = default;
}

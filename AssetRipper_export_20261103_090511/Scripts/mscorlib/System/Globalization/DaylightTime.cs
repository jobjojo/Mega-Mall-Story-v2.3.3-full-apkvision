namespace System.Globalization;

[Serializable]
public class DaylightTime
{
	private readonly DateTime _start;

	private readonly DateTime _end;

	private readonly TimeSpan _delta;

	public DateTime Start => default;

	public DateTime End => default;

	public TimeSpan Delta => default;

	public DaylightTime(DateTime start, DateTime end, TimeSpan delta)
	{
	}
}

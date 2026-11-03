namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets.Method)]
public sealed class EventAttribute : Attribute
{
	private int EventId { set; }

	public EventLevel Level { set; }

	public EventAttribute(int eventId)
	{
	}
}

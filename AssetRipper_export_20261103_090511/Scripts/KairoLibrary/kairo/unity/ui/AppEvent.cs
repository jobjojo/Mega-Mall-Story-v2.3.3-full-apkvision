namespace kairo.unity.ui;

public class AppEvent
{
	public AppEventType Type;

	public object[] Args;

	internal AppEvent(AppEventType type, params object[] args)
	{
	}
}

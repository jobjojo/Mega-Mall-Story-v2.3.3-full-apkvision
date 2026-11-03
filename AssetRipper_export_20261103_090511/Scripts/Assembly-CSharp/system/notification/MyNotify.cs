using kairo.unity.system.notification.ui;

namespace system.notification;

public class MyNotify : NotifyManager
{
	private MyNotify()
	{
	}

	public new static MyNotify GetInstance()
	{
		return null;
	}

	public override void OnNotify()
	{
	}

	public override void OnReceiveValue()
	{
	}
}

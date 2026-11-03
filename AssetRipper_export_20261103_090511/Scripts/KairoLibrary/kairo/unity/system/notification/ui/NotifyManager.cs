using System.Collections.Generic;

namespace kairo.unity.system.notification.ui;

public class NotifyManager
{
	public enum FilterLevel
	{
		None = 0,
		Important = 1,
		Middle = 2,
		All = 3
	}

	protected static NotifyManager instance_;

	protected List<string> values_;

	protected bool pushEnable_;

	private FilterLevel filterLevel_;

	private const string NOTIFY_DATA_PREFS = "_notification_data";

	protected NotifyManager()
	{
	}

	public static NotifyManager GetInstance()
	{
		return null;
	}

	public void SendString(long delay, string text, string customField = "")
	{
	}

	public void SendString(int id, long delay, string text, string customField = "")
	{
	}

	public void SendText(long delay, string text, string customField = "")
	{
	}

	public void SendText(int id, long delay, string text, string customField = "")
	{
	}

	public void SendPushString(string friendId, string text, string customField = "")
	{
	}

	public void SendPushString(int id, string friendId, string text, string customField = "")
	{
	}

	public void SendPushText(string friendId, string text, string customField = "")
	{
	}

	public void SendPushText(int id, string friendId, string text, string customField = "")
	{
	}

	internal void DoNotify()
	{
	}

	public virtual void OnNotify()
	{
	}

	public virtual void OnReceiveValue()
	{
	}

	internal void DoCancel()
	{
	}

	public int GetValuesNum()
	{
		return 0;
	}

	public string GetValue(int index)
	{
		return null;
	}

	public void RemoveValues(params int[] indicies)
	{
	}

	public void ClearValues()
	{
	}

	internal void UpdateValues()
	{
	}

	internal void SaveValues()
	{
	}

	public FilterLevel GetFilterLevel()
	{
		return FilterLevel.None;
	}

	public void SetFilterLevel(FilterLevel level)
	{
	}

	public void SetPushEnable(bool enable)
	{
	}

	public bool IsPushEnable()
	{
		return false;
	}

	public static void RegistFcmToken()
	{
	}
}

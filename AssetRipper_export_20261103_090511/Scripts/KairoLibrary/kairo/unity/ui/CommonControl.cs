using System.Collections.Generic;

namespace kairo.unity.ui;

public class CommonControl
{
	public static Id EVT_HIDDEN;

	public static Id EVT_SLEEP;

	public static Id EVT_BROWSER;

	public static Id EVT_EXIT;

	public static Id EVT_RESUME;

	private static int makeId_;

	protected static Id RegistId()
	{
		return null;
	}

	public static void DoEvent(Id evtId, int value, string key1 = null, object value1 = null, string key2 = null, object value2 = null, string key3 = null, object value3 = null)
	{
	}

	public static void DoEvent(Id evtId, int value, Dictionary<string, object> param)
	{
	}

	protected virtual void OnEvent(Id evtId, int value, Dictionary<string, object> param)
	{
	}

	public virtual int ToId<T>(T obj)
	{
		return 0;
	}

	public virtual T FromId<T>(int id)
	{
		return default;
	}
}

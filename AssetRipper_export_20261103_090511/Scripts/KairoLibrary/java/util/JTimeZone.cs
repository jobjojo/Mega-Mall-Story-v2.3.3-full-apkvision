using System;

namespace java.util;

public class JTimeZone
{
	private string id_;

	private long utcOffset_;

	private TimeZoneInfo timezone_;

	public long UtcOffset => 0L;

	private JTimeZone(string id)
	{
	}

	public static JTimeZone GetDefault()
	{
		return null;
	}

	public string GetID()
	{
		return null;
	}

	public static JTimeZone GetTimeZone(string ID)
	{
		return null;
	}

	public JTimeZone Clone()
	{
		return null;
	}

	public TimeZoneInfo GetTimeZoneInfo()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}

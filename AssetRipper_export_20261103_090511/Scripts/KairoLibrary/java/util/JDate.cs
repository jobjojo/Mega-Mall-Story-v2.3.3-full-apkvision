using System;

namespace java.util;

public class JDate
{
	public static DateTime UNIX_TIME;

	protected DateTime date_;

	public JDate()
	{
	}

	public JDate(long date)
	{
	}

	public JDate(DateTime date)
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

	public long GetTime()
	{
		return 0L;
	}

	public void SetTime(long time)
	{
	}

	public void SetTime(DateTime date)
	{
	}

	public DateTime GetDateTime()
	{
		return default;
	}

	public JDate Clone()
	{
		return null;
	}
}

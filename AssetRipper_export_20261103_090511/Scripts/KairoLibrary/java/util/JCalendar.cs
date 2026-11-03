namespace java.util;

public class JCalendar
{
	public const int YEAR = 1;

	public const int MONTH = 2;

	public const int DATE = 5;

	public const int DAY_OF_MONTH = 5;

	public const int DAY_OF_YEAR = 6;

	public const int DAY_OF_WEEK = 7;

	public const int AM_PM = 9;

	public const int HOUR = 10;

	public const int HOUR_OF_DAY = 11;

	public const int MINUTE = 12;

	public const int SECOND = 13;

	public const int MILLISECOND = 14;

	public const int SUNDAY = 1;

	public const int MONDAY = 2;

	public const int TUESDAY = 3;

	public const int WEDNESDAY = 4;

	public const int THURSDAY = 5;

	public const int FRIDAY = 6;

	public const int SATURDAY = 7;

	public const int JANUARY = 0;

	public const int FEBRUARY = 1;

	public const int MARCH = 2;

	public const int APRIL = 3;

	public const int MAY = 4;

	public const int JUNE = 5;

	public const int JULY = 6;

	public const int AUGUST = 7;

	public const int SEPTEMBER = 8;

	public const int OCTOBER = 9;

	public const int NOVEMBER = 10;

	public const int DECEMBER = 11;

	public const int AM = 0;

	public const int PM = 1;

	protected JDate date_;

	protected JTimeZone timezone_;

	protected JCalendar()
	{
	}

	protected JCalendar(JTimeZone zone)
	{
	}

	public static JCalendar GetInstance()
	{
		return null;
	}

	public static JCalendar GetInstance(JTimeZone zone)
	{
		return null;
	}

	public bool After(object when)
	{
		return false;
	}

	public bool Before(object when)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void Add(int field, int value)
	{
	}

	public int Get(int field)
	{
		return 0;
	}

	public void Set(int field, int value)
	{
	}

	public void Set(int year, int month, int date)
	{
	}

	public void Set(int year, int month, int date, int hourOfDay, int minute)
	{
	}

	public void Set(int year, int month, int date, int hourOfDay, int minute, int second)
	{
	}

	public void Clear()
	{
	}

	public JDate GetTime()
	{
		return null;
	}

	public void SetTime(JDate date)
	{
	}

	public JTimeZone GetTimeZone()
	{
		return null;
	}

	public void SetTimeZone(JTimeZone value)
	{
	}

	public void SetTimeInMillis(long millis)
	{
	}

	public long GetTimeInMillis()
	{
		return 0L;
	}

	public string GetString(string format)
	{
		return null;
	}
}

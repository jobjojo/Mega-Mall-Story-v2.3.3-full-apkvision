namespace data_kasa;

public class EventData : BaseData
{
	public const int TYPE_SYSTEM = 0;

	public const int TERM_NG = 0;

	public const int TERM_MONEY = 1;

	public const int TERM_EVENT = 2;

	public const int TERM_YEAR = 3;

	public const int TERM_MONTH = 4;

	public const int TERM_WEEK = 5;

	public const int TERM_HOUR = 6;

	public const int TERM_FIND_ITEM = 7;

	public const int TERM_FIND_CHIP = 8;

	public const int TERM_COVER_POWER = 9;

	public const int TERM_ESTIMATION_ROOM = 10;

	public const int TERM_ESTIMATION_DISH = 11;

	public const int TERM_ESTIMATION_SPRING = 12;

	public const int TERM_ESTIMATION_FACILITY = 13;

	public const int TERM_ESTIMATION_TOTAL = 14;

	public const int TERM_LOCATION_LEVEL = 15;

	public const int TERM_SPECIAL = 16;

	public const int SCR_MONEY = 0;

	public const int SCR_EVENT = 1;

	public const int SCR_TALK = 2;

	public const int SCR_NEWS = 3;

	public const int SCR_EVTMSG = 4;

	public const int SCR_DELAY = 5;

	public const int SCR_FIND_ITEM = 6;

	public const int SCR_RESEARCH_ITEM = 7;

	public const int SCR_FIND_CHIP = 8;

	public const int SCR_WAIT = 9;

	public const int SCR_FLAG_ON = 10;

	public const int SCR_FLAG_OFF = 11;

	public const int SCR_CUSTOEMR = 12;

	public const int SCR_SPECIAL = 13;

	public const int SCR_HEART = 14;

	public const int SCR_POPULAR = 15;

	public string name_;

	public int type_;

	public int[][] termsScript_;

	public int[][] execsScript_;

	public EventData()
	{
	}

	public EventData(string src)
	{
	}

	public void Load(string src)
	{
	}

	public static int[][] ReadScript(string source)
	{
		return null;
	}

	public static bool CheckScript(int[][] script, int scrId)
	{
		return false;
	}

	public static int Search(EventData[] events, int id)
	{
		return 0;
	}
}

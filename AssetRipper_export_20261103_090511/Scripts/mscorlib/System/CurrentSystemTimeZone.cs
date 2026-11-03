using System.Collections;

namespace System;

[Serializable]
[Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
internal class CurrentSystemTimeZone : TimeZone
{
	private long m_ticksOffset;

	private string m_standardName;

	private string m_daylightName;

	private readonly Hashtable m_CachedDaylightChanges;

	internal CurrentSystemTimeZone()
	{
	}

	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted)
	{
		data = null;
		names = null;
		daylight_inverted = default;
		return false;
	}
}

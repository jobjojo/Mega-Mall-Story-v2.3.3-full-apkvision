using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	private struct TZifType(byte[] data, int index)
	{
		public readonly TimeSpan UtcOffset = default;

		public readonly bool IsDst = false;

		public readonly byte AbbreviationIndex = 0;
	}

	private struct TZifHead(byte[] data, int index)
	{
		public readonly uint Magic = 0u;

		public readonly TZVersion Version = TZVersion.V1;

		public readonly uint IsGmtCount = 0u;

		public readonly uint IsStdCount = 0u;

		public readonly uint LeapCount = 0u;

		public readonly uint TimeCount = 0u;

		public readonly uint TypeCount = 0u;

		public readonly uint CharCount = 0u;
	}

	private enum TZVersion : byte
	{
		V1 = 0,
		V2 = 1,
		V3 = 2
	}

	[Serializable]
	public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _dateStart;

		private readonly DateTime _dateEnd;

		private readonly TimeSpan _daylightDelta;

		private readonly TransitionTime _daylightTransitionStart;

		private readonly TransitionTime _daylightTransitionEnd;

		private readonly TimeSpan _baseUtcOffsetDelta;

		private readonly bool _noDaylightTransitions;

		public DateTime DateStart => default;

		public DateTime DateEnd => default;

		public TimeSpan DaylightDelta => default;

		public TransitionTime DaylightTransitionStart => default;

		public TransitionTime DaylightTransitionEnd => default;

		internal TimeSpan BaseUtcOffsetDelta => default;

		internal bool NoDaylightTransitions => false;

		internal bool HasDaylightSaving => false;

		public bool Equals(AdjustmentRule other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
		}

		public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd)
		{
			return null;
		}

		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
			return null;
		}

		internal bool IsStartDateMarkerForBeginningOfYear()
		{
			return false;
		}

		internal bool IsEndDateMarkerForEndOfYear()
		{
			return false;
		}

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private AdjustmentRule(SerializationInfo info, StreamingContext context)
		{
		}

		internal AdjustmentRule()
		{
		}
	}

	[Serializable]
	public readonly struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _timeOfDay = default;

		private readonly byte _month = 0;

		private readonly byte _week = 0;

		private readonly byte _day = 0;

		private readonly DayOfWeek _dayOfWeek = DayOfWeek.Sunday;

		private readonly bool _isFixedDateRule = false;

		public DateTime TimeOfDay => default;

		public int Month => 0;

		public int Week => 0;

		public int Day => 0;

		public DayOfWeek DayOfWeek => DayOfWeek.Sunday;

		public bool IsFixedDateRule => false;

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator !=(TransitionTime t1, TransitionTime t2)
		{
			return false;
		}

		public bool Equals(TransitionTime other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
		{
		}

		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
		{
			return default;
		}

		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
		{
			return default;
		}

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private TransitionTime(SerializationInfo info, StreamingContext context)
		{
		}
	}

	private sealed class CachedData
	{
		private TimeZoneInfo _localTimeZone;

		public TimeZoneInfo Local => null;

		private TimeZoneInfo CreateLocal()
		{
			return null;
		}

		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
		{
			return DateTimeKind.Unspecified;
		}
	}

	private readonly string _id;

	private readonly string _displayName;

	private readonly string _standardDisplayName;

	private readonly string _daylightDisplayName;

	private readonly TimeSpan _baseUtcOffset;

	private readonly bool _supportsDaylightSavingTime;

	private readonly AdjustmentRule[] _adjustmentRules;

	private static readonly TimeZoneInfo s_utcTimeZone;

	private static CachedData s_cachedData;

	private static readonly DateTime s_maxDateOnly;

	private static readonly DateTime s_minDateOnly;

	private static readonly TimeSpan MaxOffset;

	private static readonly TimeSpan MinOffset;

	public string Id => null;

	public string DisplayName => null;

	public string StandardName => null;

	public string DaylightName => null;

	public TimeSpan BaseUtcOffset => default;

	public static TimeZoneInfo Local => null;

	public static TimeZoneInfo Utc => null;

	private TimeZoneInfo(byte[] data, string id, bool dstDisabled)
	{
	}

	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData)
	{
		return null;
	}

	private static bool TryGetLocalTzFile(out byte[] rawData, out string id)
	{
		rawData = null;
		id = null;
		return false;
	}

	private static string GetTzEnvironmentVariable()
	{
		return null;
	}

	private static bool TryLoadTzFile(string tzFilePath, ref byte[] rawData, ref string id)
	{
		return false;
	}

	private static string FindTimeZoneIdUsingReadLink(string tzFilePath)
	{
		return null;
	}

	private static string GetDirectoryEntryFullPath(ref Interop.Sys.DirectoryEntry dirent, string currentPath)
	{
		return null;
	}

	private static void EnumerateFilesRecursively(string path, Predicate<string> condition)
	{
	}

	private static string FindTimeZoneId(byte[] rawData)
	{
		return null;
	}

	private static bool CompareTimeZoneFile(string filePath, byte[] buffer, byte[] rawData)
	{
		return false;
	}

	private static TimeZoneInfo GetLocalTimeZoneFromTzFile()
	{
		return null;
	}

	private static TimeZoneInfo GetTimeZoneFromTzData(byte[] rawData, string id)
	{
		return null;
	}

	private static string GetTimeZoneDirectory()
	{
		return null;
	}

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
	{
		isAmbiguousLocalDst = default;
		return default;
	}

	private static void TZif_GenerateAdjustmentRules(out AdjustmentRule[] rules, TimeSpan baseUtcOffset, DateTime[] dts, byte[] typeOfLocalTime, TZifType[] transitionType, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat)
	{
		rules = null;
	}

	private static void TZif_GenerateAdjustmentRule(ref int index, TimeSpan timeZoneBaseUtcOffset, List<AdjustmentRule> rulesList, DateTime[] dts, byte[] typeOfLocalTime, TZifType[] transitionTypes, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat)
	{
	}

	private static TimeSpan TZif_CalculateTransitionOffsetFromBase(TimeSpan transitionOffset, TimeSpan timeZoneBaseUtcOffset)
	{
		return default;
	}

	private static TZifType TZif_GetEarlyDateTransitionType(TZifType[] transitionTypes)
	{
		return default;
	}

	private static AdjustmentRule TZif_CreateAdjustmentRuleForPosixFormat(string posixFormat, DateTime startTransitionDate, TimeSpan timeZoneBaseUtcOffset)
	{
		return null;
	}

	private static TimeSpan? TZif_ParseOffsetString(string offset)
	{
		return null;
	}

	private static DateTime ParseTimeOfDay(string time)
	{
		return default;
	}

	private static TransitionTime? TZif_CreateTransitionTimeFromPosixRule(string date, string time)
	{
		return null;
	}

	private static void TZif_ParseJulianDay(string date, out int month, out int day)
	{
		month = default;
		day = default;
	}

	private static bool TZif_ParseMDateRule(string dateRule, out int month, out int week, out DayOfWeek dayOfWeek)
	{
		month = default;
		week = default;
		dayOfWeek = default;
		return false;
	}

	private static bool TZif_ParsePosixFormat(string posixFormat, out string standardName, out string standardOffset, out string daylightSavingsName, out string daylightSavingsOffset, out string start, out string startTime, out string end, out string endTime)
	{
		standardName = null;
		standardOffset = null;
		daylightSavingsName = null;
		daylightSavingsOffset = null;
		start = null;
		startTime = null;
		end = null;
		endTime = null;
		return false;
	}

	private static string TZif_ParsePosixName(string posixFormat, ref int index)
	{
		return null;
	}

	private static string TZif_ParsePosixOffset(string posixFormat, ref int index)
	{
		return null;
	}

	private static void TZif_ParsePosixDateTime(string posixFormat, ref int index, out string date, out string time)
	{
		date = null;
		time = null;
	}

	private static string TZif_ParsePosixDate(string posixFormat, ref int index)
	{
		return null;
	}

	private static string TZif_ParsePosixTime(string posixFormat, ref int index)
	{
		return null;
	}

	private static string TZif_ParsePosixString(string posixFormat, ref int index, Func<char, bool> breakCondition)
	{
		return null;
	}

	private static string TZif_GetZoneAbbreviation(string zoneAbbreviations, int index)
	{
		return null;
	}

	private static int TZif_ToInt32(byte[] value, int startIndex)
	{
		return 0;
	}

	private static long TZif_ToInt64(byte[] value, int startIndex)
	{
		return 0L;
	}

	private static long TZif_ToUnixTime(byte[] value, int startIndex, TZVersion version)
	{
		return 0L;
	}

	private static DateTime TZif_UnixTimeToDateTime(long unixTime)
	{
		return default;
	}

	private static void TZif_ParseRaw(byte[] data, out TZifHead t, out DateTime[] dts, out byte[] typeOfLocalTime, out TZifType[] transitionType, out string zoneAbbreviations, out bool[] StandardTime, out bool[] GmtTime, out string futureTransitionsPosixFormat)
	{
		t = default;
		dts = null;
		typeOfLocalTime = null;
		transitionType = null;
		zoneAbbreviations = null;
		StandardTime = null;
		GmtTime = null;
		futureTransitionsPosixFormat = null;
	}

	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, int? ruleIndex)
	{
		return null;
	}

	public TimeSpan GetUtcOffset(DateTime dateTime)
	{
		return default;
	}

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default;
	}

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default;
	}

	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return default;
	}

	public static void ClearCachedData()
	{
	}

	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
	{
		return default;
	}

	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return default;
	}

	public static DateTime ConvertTimeToUtc(DateTime dateTime)
	{
		return default;
	}

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default;
	}

	public bool Equals(TimeZoneInfo other)
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

	public bool HasSameRules(TimeZoneInfo other)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
	{
		return null;
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
		return null;
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private TimeZoneInfo(SerializationInfo info, StreamingContext context)
	{
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out int? ruleIndex)
	{
		ruleIndex = null;
		return null;
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex)
	{
		ruleIndex = null;
		return null;
	}

	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
	{
		return 0;
	}

	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		return default;
	}

	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		return default;
	}

	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
	{
		return default;
	}

	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
	{
		isAmbiguousLocalDst = default;
		return default;
	}

	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, int? ruleIndex)
	{
		return default;
	}

	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
	{
		return false;
	}

	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, int? ruleIndex)
	{
		return default;
	}

	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule)
	{
		return default;
	}

	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
	{
		isAmbiguousLocalDst = default;
		return false;
	}

	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule)
	{
		return false;
	}

	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		return false;
	}

	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		return false;
	}

	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
	{
		return default;
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
	{
		return default;
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
	{
		isDaylightSavings = default;
		return default;
	}

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
	{
		isDaylightSavings = default;
		isAmbiguousLocalDst = default;
		return default;
	}

	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime)
	{
		return default;
	}

	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
	{
		adjustmentRulesSupportDst = default;
	}

	internal static bool UtcOffsetOutOfRange(TimeSpan offset)
	{
		return false;
	}

	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		return default;
	}

	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		return false;
	}

	private static void NormalizeAdjustmentRuleOffset(TimeSpan baseUtcOffset, ref AdjustmentRule adjustmentRule)
	{
	}

	private static string GetTimeZoneDirectoryUnity()
	{
		return null;
	}

	private static List<AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names)
	{
		data = null;
		names = null;
		return null;
	}

	private static TimeZoneInfo CreateLocalUnity()
	{
		return null;
	}

	internal TimeZoneInfo()
	{
	}
}

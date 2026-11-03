using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions;

public class Regex : ISerializable
{
	internal readonly struct CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern) : IEquatable<CachedCodeEntryKey>
	{
		private readonly RegexOptions _options = RegexOptions.None;

		private readonly string _cultureKey = null;

		private readonly string _pattern = null;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(CachedCodeEntryKey other)
		{
			return false;
		}

		public static bool operator ==(CachedCodeEntryKey left, CachedCodeEntryKey right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	internal sealed class CachedCodeEntry
	{
		public CachedCodeEntry Next;

		public CachedCodeEntry Previous;

		public readonly CachedCodeEntryKey Key;

		public RegexCode Code;

		public readonly Hashtable Caps;

		public readonly Hashtable Capnames;

		public readonly string[] Capslist;

		public readonly int Capsize;

		public readonly ExclusiveReference Runnerref;

		public readonly WeakReference<RegexReplacement> ReplRef;

		public CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
		{
		}
	}

	private static int s_cacheSize;

	private static readonly Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache;

	private static int s_cacheCount;

	private static CachedCodeEntry s_cacheFirst;

	private static CachedCodeEntry s_cacheLast;

	private static readonly TimeSpan s_maximumMatchTimeout;

	internal static readonly TimeSpan s_defaultMatchTimeout;

	public static readonly TimeSpan InfiniteMatchTimeout;

	protected internal TimeSpan internalMatchTimeout;

	protected internal string pattern;

	protected internal RegexOptions roptions;

	protected internal RegexRunnerFactory factory;

	protected internal Hashtable caps;

	protected internal Hashtable capnames;

	protected internal string[] capslist;

	protected internal int capsize;

	internal ExclusiveReference _runnerref;

	internal WeakReference<RegexReplacement> _replref;

	internal RegexCode _code;

	internal bool _refsInitialized;

	public bool RightToLeft => false;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd)
	{
		return null;
	}

	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd)
	{
		return null;
	}

	private void FillCacheDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry)
	{
		entry = null;
		return false;
	}

	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry)
	{
		entry = null;
		return false;
	}

	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key)
	{
		return null;
	}

	public static bool IsMatch(string input, string pattern)
	{
		return false;
	}

	public static bool IsMatch(string input, string pattern, RegexOptions options)
	{
		return false;
	}

	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return false;
	}

	public bool IsMatch(string input)
	{
		return false;
	}

	public bool IsMatch(string input, int startat)
	{
		return false;
	}

	public static Match Match(string input, string pattern)
	{
		return null;
	}

	public static Match Match(string input, string pattern, RegexOptions options)
	{
		return null;
	}

	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return null;
	}

	public Match Match(string input)
	{
		return null;
	}

	public Match Match(string input, int startat)
	{
		return null;
	}

	public static MatchCollection Matches(string input, string pattern)
	{
		return null;
	}

	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
	{
		return null;
	}

	public MatchCollection Matches(string input)
	{
		return null;
	}

	public MatchCollection Matches(string input, int startat)
	{
		return null;
	}

	public static string Replace(string input, string pattern, string replacement)
	{
		return null;
	}

	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
	{
		return null;
	}

	public string Replace(string input, string replacement)
	{
		return null;
	}

	public string Replace(string input, string replacement, int count, int startat)
	{
		return null;
	}

	static Regex()
	{
	}

	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
	{
	}

	private static TimeSpan InitDefaultMatchTimeout()
	{
		return default;
	}

	public Regex(string pattern)
	{
	}

	public Regex(string pattern, RegexOptions options)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
	{
	}

	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string GroupNameFromNumber(int i)
	{
		return null;
	}

	protected void InitializeReferences()
	{
	}

	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
	{
		return null;
	}

	protected internal bool UseOptionR()
	{
		return false;
	}

	internal bool UseOptionInvariant()
	{
		return false;
	}
}

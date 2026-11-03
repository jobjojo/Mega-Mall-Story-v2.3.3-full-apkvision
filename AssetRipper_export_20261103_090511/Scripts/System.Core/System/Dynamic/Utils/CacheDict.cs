using System.Reflection;

namespace System.Dynamic.Utils;

[DefaultMember("Item")]
internal sealed class CacheDict<TKey, TValue>
{
	private sealed class Entry
	{
	}

	private readonly int _mask;

	private readonly Entry[] _entries;

	internal CacheDict(int size)
	{
	}

	private static int AlignSize(int size)
	{
		return 0;
	}
}

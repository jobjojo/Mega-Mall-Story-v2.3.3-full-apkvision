using System.Collections;
using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal sealed class RegexCode
{
	public readonly int[] Codes;

	public readonly string[] Strings;

	public readonly int TrackCount;

	public readonly Hashtable Caps;

	public readonly int CapSize;

	public readonly RegexPrefix? FCPrefix;

	public readonly RegexBoyerMoore BMPrefix;

	public readonly int Anchors;

	public readonly bool RightToLeft;

	public RegexCode(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix? fcPrefix, int anchors, bool rightToLeft)
	{
	}

	public static bool OpcodeBacktracks(int Op)
	{
		return false;
	}
}

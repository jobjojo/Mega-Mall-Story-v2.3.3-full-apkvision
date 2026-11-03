using System.Collections;
using System.Collections.Generic;

namespace System;

[Serializable]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
{
	private static readonly CultureAwareComparer s_invariantCulture;

	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase;

	private static readonly OrdinalCaseSensitiveComparer s_ordinal;

	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase;

	public static StringComparer InvariantCultureIgnoreCase => null;

	public static StringComparer CurrentCultureIgnoreCase => null;

	public static StringComparer Ordinal => null;

	public static StringComparer OrdinalIgnoreCase => null;

	public int Compare(object x, object y)
	{
		return 0;
	}

	public new bool Equals(object x, object y)
	{
		return false;
	}

	public int GetHashCode(object obj)
	{
		return 0;
	}

	public abstract int Compare(string x, string y);

	public abstract bool Equals(string x, string y);

	public abstract int GetHashCode(string obj);
}

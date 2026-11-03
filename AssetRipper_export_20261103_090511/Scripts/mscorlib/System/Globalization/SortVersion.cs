namespace System.Globalization;

[Serializable]
public sealed class SortVersion : IEquatable<SortVersion>
{
	private int m_NlsVersion;

	private Guid m_SortId;

	public int FullVersion => 0;

	public Guid SortId => default;

	public SortVersion(int fullVersion, Guid sortId)
	{
	}

	internal SortVersion(int nlsVersion, int effectiveId, Guid customVersion)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(SortVersion other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(SortVersion left, SortVersion right)
	{
		return false;
	}

	public static bool operator !=(SortVersion left, SortVersion right)
	{
		return false;
	}
}

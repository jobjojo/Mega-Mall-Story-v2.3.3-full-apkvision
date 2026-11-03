namespace System.Text;

[Serializable]
public sealed class EncodingInfo
{
	private int iCodePage;

	private string strEncodingName;

	private string strDisplayName;

	public int CodePage => 0;

	internal EncodingInfo(int codePage, string name, string displayName)
	{
	}

	public override bool Equals(object value)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal EncodingInfo()
	{
	}
}

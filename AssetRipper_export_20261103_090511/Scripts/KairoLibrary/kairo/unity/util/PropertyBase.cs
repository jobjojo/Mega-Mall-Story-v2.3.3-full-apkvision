namespace kairo.unity.util;

public abstract class PropertyBase
{
	public const int TYPE_PRO = 0;

	public const int TYPE_INT = 1;

	public const int TYPE_LNG = 2;

	public const int TYPE_STR = 3;

	public const int TYPE_BIN = 4;

	private const int TYPE_END = 5;

	public byte[][] bins;

	public int GetTypeNum()
	{
		return 0;
	}

	public string GetTypeTag(int type)
	{
		return null;
	}

	public abstract byte[] ToByteArray();

	public abstract Property ToProperty();
}

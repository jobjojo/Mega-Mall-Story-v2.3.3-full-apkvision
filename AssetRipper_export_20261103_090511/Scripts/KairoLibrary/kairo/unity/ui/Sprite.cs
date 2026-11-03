namespace kairo.unity.ui;

public struct Sprite
{
	private int[] value_ = null;

	public int FrameNo => 0;

	public int TexId => 0;

	public int U => 0;

	public int V => 0;

	public int W => 0;

	public int H => 0;

	public int X => 0;

	public int Y => 0;

	public int TransX => 0;

	public int TransY => 0;

	public int ReverseU => 0;

	public int ReverseV => 0;

	public int Blend => 0;

	public int Color => 0;

	public bool IsEmpty => false;

	public int this[int index]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal Sprite(int[] sp)
	{
	}

	public static implicit operator int[](Sprite sprite)
	{
		return null;
	}

	public static implicit operator Sprite(int[] sprite)
	{
		return default;
	}

	public static bool operator ==(Sprite z, object w)
	{
		return false;
	}

	public static bool operator !=(Sprite z, object w)
	{
		return false;
	}

	public static bool operator true(Sprite x)
	{
		return false;
	}

	public static bool operator false(Sprite x)
	{
		return false;
	}
}

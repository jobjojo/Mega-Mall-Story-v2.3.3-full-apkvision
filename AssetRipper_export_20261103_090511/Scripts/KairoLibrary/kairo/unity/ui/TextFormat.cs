namespace kairo.unity.ui;

public class TextFormat
{
	protected static TextFormat textFormat_;

	protected int font_;

	protected int[] x_;

	protected int[] y_;

	protected int anchor_;

	public TextFormat()
	{
	}

	public TextFormat(string format)
	{
	}

	public static TextFormat Create(string format)
	{
		return null;
	}

	private void Init(string format)
	{
	}

	public int GetFont()
	{
		return 0;
	}

	public float GetX(float x)
	{
		return 0f;
	}

	public float GetY(float y)
	{
		return 0f;
	}

	private float GetXY(float basis, int[] elem)
	{
		return 0f;
	}

	public int GetAnchor(int anchor)
	{
		return 0;
	}
}

namespace kairo.unity.panel;

public class TextBox : Component
{
	public const int DISPLAY_ANY = 0;

	public const int DISPLAY_PASSWORD = 0;

	public const int NUMBER = 0;

	public const int ALPHA = 1;

	public const int KANA = 2;

	public string text_;

	public int columns_;

	public int mode_;

	public int maxLength_;

	public TextBox(string text, int columns, int rows, int mode)
	{
	}

	public int GetWidth()
	{
		return 0;
	}

	public int GetHeight()
	{
		return 0;
	}

	public void SetLocation(int x, int y)
	{
	}

	public void SetInputMode(int mode)
	{
	}

	public void SetMaxLength(int length)
	{
	}

	public string GetText()
	{
		return null;
	}
}

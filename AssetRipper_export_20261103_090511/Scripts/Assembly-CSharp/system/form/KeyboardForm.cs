using form;
using kairo.unity.ui;

namespace system.form;

public class KeyboardForm : MyFormBase
{
	public static int FORMID_KEYBOARD;

	public int frame_;

	public int inputID_;

	private string title_;

	private string text_;

	private int maxLength_;

	public string resultText_;

	public bool isChange_;

	public override string ToString()
	{
		return null;
	}

	public static KeyboardForm MakeKeyboardForm(int inputID, string title, string text, int maxLength)
	{
		return null;
	}

	public KeyboardForm()
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override bool Update()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public override bool Resume()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class ReviewForm : LibraryFormBase
{
	private const int FRAME_MAX = 20;

	private int frame_;

	internal int fadeFrame_;

	private const int SELECT_YES = 0;

	private const int SELECT_NO = 1;

	private int viewW_;

	private int viewH_;

	public const int RESLUT_NONE = -1;

	public const int RESLUT_CANCEL = 0;

	public const int RESLUT_REVIEW = 1;

	public int result_;

	private string titleMessage_;

	private string fukidashiMessage_;

	private string thanksMessage_;

	private string writeMessage_;

	private string endMessage_;

	private int titleColor_;

	private int fukidashiColor_;

	private int selectColor_;

	private int writeColor_;

	private int touchDlgCmd_;

	private int fukidashiOffsetX_;

	private int fukidashiOffsetY_;

	private bool fukidashiVisible_;

	private ReviewForm()
		: base(0)
	{
	}

	public ReviewForm(int viewW, int viewH, int touchDlgCmd = 2)
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

	public void SetFukidashiText(string text)
	{
	}

	public void SetFukidashiOffset(int offsetX, int offsetY)
	{
	}

	public void SetFukidashiVisible(bool visible)
	{
	}

	public void SetFukidashiColor(int color)
	{
	}

	public void SetFukidashiColor(int red, int green, int blue, int alpha = 255)
	{
	}

	public void SetTitleText(string text)
	{
	}

	public void SetTitleColor(int color)
	{
	}

	public void SetTitleColor(int red, int green, int blue, int alpha = 255)
	{
	}

	public void SetSelectColor(int color)
	{
	}

	public void SetSelectColor(int red, int green, int blue, int alpha = 255)
	{
	}

	public void SetWriteText(string text)
	{
	}

	public void SetWriteColor(int color)
	{
	}

	public void SetWriteColor(int red, int green, int blue, int alpha = 255)
	{
	}

	public void SetThankyouText(string text)
	{
	}

	public void SetEndText(string text)
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

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public override bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}
}

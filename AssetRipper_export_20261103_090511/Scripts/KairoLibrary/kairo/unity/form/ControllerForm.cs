using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class ControllerForm : LibraryFormBase
{
	private static bool disp;

	private const int FRAME_MAX = 24;

	private int frame_;

	public static void Start()
	{
	}

	public ControllerForm()
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

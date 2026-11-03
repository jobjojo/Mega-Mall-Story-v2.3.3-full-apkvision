using kairo.unity.ui;

namespace kairo.unity.form;

public class GameoverForm : LibraryFormBase
{
	private const int FRAME_MAX = 24;

	private int frame_;

	public GameoverForm()
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
}

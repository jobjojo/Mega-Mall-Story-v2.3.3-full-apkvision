using form;
using kairo.unity.ui;

namespace system.form;

public class ConnectForm : MyFormBase
{
	public static int FORMID_CONNECT;

	public static int frame_;

	public static bool close_;

	private static ConnectForm form_;

	internal static ResourceManager resConnect_;

	public override string ToString()
	{
		return null;
	}

	public ConnectForm()
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

	private void _draw(Graphics g)
	{
	}

	public static void DrawConnect(Graphics g)
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

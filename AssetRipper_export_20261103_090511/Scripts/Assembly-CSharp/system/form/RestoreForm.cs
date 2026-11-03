using form;
using kairo.unity.form;
using kairo.unity.ui;

namespace system.form;

public class RestoreForm : MyFormBase
{
	public const int FORMID_RESTORE = 906;

	private FormBase next_;

	private string message_;

	public override string ToString()
	{
		return null;
	}

	public RestoreForm(FormBase next = null)
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public override bool Update()
	{
		return false;
	}

	public override bool CheckMainWindow()
	{
		return false;
	}
}

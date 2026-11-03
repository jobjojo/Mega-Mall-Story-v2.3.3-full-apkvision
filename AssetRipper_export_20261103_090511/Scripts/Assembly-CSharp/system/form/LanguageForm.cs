using System.Threading;
using form;
using kairo.unity.surface;
using kairo.unity.ui;

namespace system.form;

public class LanguageForm : MyFormBase
{
	public const int FORMID_LANGUAGE = 908;

	private static ThreadStart callback_;

	private string[][] languages_;

	private string langPackFile_;

	private bool langPackJapanese_;

	private static string langDownloadUrl_;

	private byte[] langDownloadData_;

	private bool start_;

	private int mode_;

	private static bool warningTextLayout_;

	public override string ToString()
	{
		return null;
	}

	public LanguageForm()
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

	public override bool Finish()
	{
		return false;
	}

	public override bool CheckMainWindow()
	{
		return false;
	}

	public static void DrawButton(Graphics g, ThreadStart callback, int anchor = 20)
	{
	}

	public static void DrawButton(Graphics g, int x, int y, ThreadStart callback)
	{
	}

	public new static bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}
}

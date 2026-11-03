using form;
using java.lang;
using kairo.unity.ui;
using kairo.unity.util;

namespace system.form;

public class InstallForm : MyFormBase, JRunnable
{
	public const int FORMID_INSTALL_BONUS = 905;

	public const int TYPE_INSTALL_BONUS = 0;

	public const int TYPE_NO_INSTALL = 1;

	public const int TYPE_BOOT_WAIT = 2;

	public const int TYPE_WEB_VIEW = 3;

	public int type_;

	private static readonly int[][] configData_;

	public bool untilActiveHide_;

	private int x_;

	private int y_;

	private int loopCounter_;

	private int frame_;

	private int processStep_;

	public int dialogId_;

	public new int result_;

	private const int THTYPE_INSTALL_BONUS = 0;

	private const int THTYPE_INSTALL_RECIEVE = 1;

	private int threadType_;

	private const int THSTATE_NONE = 0;

	private const int THSTATE_RUN = 1;

	private const int THSTATE_SUCCESS = 2;

	private const int THSTATE_FAILURE = 3;

	private int threadState_;

	private int threadFrame_;

	private string error_;

	private JThread th_;

	public static bool close_;

	internal WebBox web_;

	internal string url_;

	private SecureString postData_;

	private string arg_;

	private const int WEB_VIEW_STEP_SAVE = 0;

	private const int WEB_VIEW_STEP_SHOW = 1;

	private const int WEB_VIEW_STEP_CLOSE = 2;

	public override string ToString()
	{
		return null;
	}

	public InstallForm()
		: base(0)
	{
	}

	public InstallForm(int type)
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

	private bool _update()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	private void _draw(Graphics g)
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

	public void SetSoftlabel()
	{
	}

	public void ThreadStart(int type)
	{
	}

	public void Run()
	{
	}

	private void InitInstallBonus()
	{
	}

	private bool UpdateInstallBonus()
	{
		return false;
	}

	private void DrawInstallBonus(Graphics g)
	{
	}

	private void InitNoInstall()
	{
	}

	private bool UpdateNoInstall()
	{
		return false;
	}

	private void DrawNoInstall(Graphics g)
	{
	}

	public static InstallForm MakeInstallBootWait(string arg)
	{
		return null;
	}

	private void InitBootWait()
	{
	}

	private bool UpdateBootWait()
	{
		return false;
	}

	public static InstallForm CreateWeb(string url, string postData)
	{
		return null;
	}

	private void InitWeb()
	{
	}

	private bool UpdateWeb()
	{
		return false;
	}

	private void DrawWeb(Graphics g)
	{
	}

	private void DrawBootWait(Graphics g)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

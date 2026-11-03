using java.lang;
using kairo.unity.ui;

namespace kairo.unity.form;

public class SplashForm : LibraryFormBase, JRunnable
{
	public enum KAIRO_PS4_RATING
	{
		NORMAL = 0,
		vsMONSTER = 1,
		vsHUMAN = 2,
		vsWARS = 3,
		NORMAL_GAMBLE = 4
	}

	private int frame_;

	private const int FADE_MAX = 8;

	private const int STATE_SPLASHWAIT = 0;

	private const int STATE_FADEIN = 1;

	private const int STATE_CHECKBROKEN = 2;

	private const int STATE_TROPHYINIT = 3;

	private const int STATE_CHECKSPACE = 4;

	private const int STATE_CHECKSPACE_C = 5;

	private const int STATE_RESTART = 6;

	private const int STATE_RESTORE = 7;

	private const int STATE_AUTOSAVE = 8;

	private const int STATE_READY = 9;

	private const int STATE_EXITGAME = 10;

	private const int STATE_ARCADESPLASH = 11;

	private const int STATE_CLOUDLOAD = 12;

	private const int STATE_CLOUDWAIT = 13;

	public const int STATE_RESUMECHECK = 14;

	private int state_;

	private int subState_;

	private const string SOFTLABEL_CANCEL = "ｷｬﾝｾﾙ";

	public int colorBG_;

	public int colorFont_;

	public int colorBold_;

	public FormBase nextForm_;

	private DialogForm dialogForm_;

	private bool trophySkip_;

	private bool tagChange_;

	private JThread th_;

	private const string ICLOUD_UPDATE_MESSAGE = "別の端末でiCloudのセーブデータが更新されました。<br>iCloudから受信すると現在のこの端末のデータに上書きされます。<br><br>このまま続けてプレイした後にセーブをすると、現在のデータがサーバーに上書きされます。";

	private const string ICLOUD_YES_RECEIVE = "データを受信してこの端末に上書きする";

	private const string ICLOUD_NO_CONTINUE = "このまま続けてプレイする";

	private bool saveAutoTextLayout_;

	private bool isInit_;

	public override string ToString()
	{
		return null;
	}

	public SplashForm()
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

	public void Run()
	{
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

	private void ChangeState(int state)
	{
	}

	public void SetState(int state)
	{
	}

	public void SetTrophyData(int trophyMax)
	{
	}

	public void SetKairoRating(KAIRO_PS4_RATING pattern)
	{
	}

	public void SetReserveSaveSize(int reserveSize)
	{
	}
}

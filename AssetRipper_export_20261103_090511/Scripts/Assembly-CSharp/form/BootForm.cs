using System;
using java.lang;
using kairo.unity.ui;
using main;

namespace form;

public class BootForm : MyFormBase, JRunnable
{
	public static int errcode;

	public static string errMessage;

	internal new AppData apdat_;

	internal new Canvas canvas_;

	internal new FormManager formMan_;

	private const int WAIT = 4;

	private int frame_wait;

	private int frame_main;

	private int loadMax_;

	private int loadCnt_;

	private byte[] regist_;

	private new SubForm dialog_;

	private string error_;

	private JThread th_;

	private Exception e_;

	private const int RESLOAD_SEB_LOAD = 0;

	private ResourceManager resLoad_;

	private const int STATE_BOOT = 0;

	private const int STATE_DOWNLOAD = 1;

	private const int STATE_LOAD = 2;

	private const int STATE_REGIST = 3;

	private const int STATE_ERROR = 4;

	private const int STATE_FINISH = 5;

	private const int STATE_VERSIONUP = 6;

	private int state_;

	private static readonly int[][] softLabels_;

	public override string ToString()
	{
		return null;
	}

	public BootForm()
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	private void Init2()
	{
	}

	public override bool Update()
	{
		return false;
	}

	public void SmartBeginPaint(Graphics g)
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

	public void LoadBox(Graphics g, string str, int cnt, int num)
	{
	}

	private void ChangeState(int state)
	{
	}

	private void InitApp()
	{
	}

	public void Run()
	{
	}

	public void Download()
	{
	}

	public void Load()
	{
	}

	public void UpdateScoreFromNetwork()
	{
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

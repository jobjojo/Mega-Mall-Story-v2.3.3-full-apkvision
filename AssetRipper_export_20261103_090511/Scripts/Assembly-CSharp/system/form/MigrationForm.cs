using System;
using form;
using java.lang;
using kairo.unity.surface;
using kairo.unity.ui;
using system.migration;

namespace system.form;

public class MigrationForm : MyFormBase, JRunnable
{
	public const int FORMID_MIGRATION = 915;

	private int frame_;

	private int page_;

	private string text_;

	private string date_;

	private bool succeed_;

	private int errorCode_;

	private string errorText_;

	internal static MyMigration mig_;

	private const int STATE_MIGRATION = 0;

	private int state_;

	private static int[][] softLabels_;

	private int migrationSelect_;

	private static bool migrationReboot_;

	public const int THMODE_START = 1;

	public const int THMODE_MIG_START = 2;

	public const int THMODE_MIG_READ = 3;

	public const int THMODE_MIG_CANCEL = 4;

	public const int THMODE_MIG_STATE = 5;

	public const int THMODE_MIG_ACCOUNTT = 6;

	public const int THSTATE_NONE = -1;

	public const int THSTATE_RUN = 0;

	public const int THSTATE_SUCCEED = 1;

	public const int THSTATE_FAILURE = 2;

	private JThread thread_;

	private int thMode_;

	private int thState_;

	private object thArguments_;

	private object thResult_;

	private Exception thException_;

	private string thError_;

	private int thExeOrderMode_;

	private object thExeOrderArg_;

	private string kaUserId_;

	private string kaUserCode_;

	private long kaTimeStamp_;

	private const int DLGID_MIG_START = 901;

	public const int KEY_VALUE_MIGRATION_SELECT = 8192000;

	private static int[] ancPos_;

	public override string ToString()
	{
		return null;
	}

	public static MigrationForm CreateMigration()
	{
		return null;
	}

	public static MigrationForm CreateMigrationThread(int thMode, object arg = null)
	{
		return null;
	}

	private MigrationForm()
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

	public bool IsMigrationStart()
	{
		return false;
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

	private void SetSoftLabel()
	{
	}

	public void ThreadStart(int thMode, object arg = null)
	{
	}

	public void ThreadInterrupt()
	{
	}

	public void Run()
	{
	}

	public static bool GetMigrationReboot()
	{
		return false;
	}

	public new static bool OnTouchEvent(TouchEvent e)
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

	public override int GetHashCode()
	{
		return 0;
	}

	public static void FillArcRect(Graphics g, int x, int y, int w, int h, int r)
	{
	}

	public static int[] GetAnchorPos(int object_w, int object_h)
	{
		return null;
	}

	public static int[] GetAnchorPos(int object_w, int object_h, int offSet_x, int offSet_y, int drawArea_w, int drawArea_h, int anchor)
	{
		return null;
	}

	public static void FillBox(Graphics g, int x, int y, int w, int h, params int[] colors)
	{
	}

	public void SetSoftLabel(int left, int right, int soft3 = -1, int soft4 = -1)
	{
	}
}

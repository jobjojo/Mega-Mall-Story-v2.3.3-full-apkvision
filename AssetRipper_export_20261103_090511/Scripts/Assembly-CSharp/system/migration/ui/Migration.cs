using form;
using kairo.unity.form;
using kairo.unity.surface;
using kairo.unity.ui;
using kairo.unity.util;
using main;

namespace system.migration.ui;

public class Migration
{
	internal static Migration instance_;

	internal static IApplication app_;

	internal static FormManager fm_;

	internal static AppData apdat_;

	internal SubForm dialog_;

	private long migrationCheckTime_;

	internal int CANCEL_SOFT_KEY;

	private const int DLGID_MIG_CANCEL = 900;

	public SecureProperty migSave_;

	public static int MIGSAVEP_END;

	public static SecureProperty[] defMigSaveP_;

	public static int MIGSAVEI_MIGRATION_VER;

	public static int MIGSAVEI_MIGRATION_STATE;

	public static int MIGSAVEI_FORCE_MIGRATION;

	public static int MIGSAVEI_END;

	public static int[] defMigSaveI_;

	public static int MIGSAVEL_END;

	public static long[] defMigSaveL_;

	public static int MIGSAVES_MIGRATION_CODE;

	public static int MIGSAVES_END;

	public static string[] defMigSaveS_;

	public static int MIGSAVEB_END;

	public static byte[][] defMigSaveB_;

	public static bool migrationReboot_ => false;

	public virtual void Init()
	{
	}

	public static Migration GetInstance()
	{
		return null;
	}

	public bool Update(FormBase form)
	{
		return false;
	}

	public bool Draw(Graphics g)
	{
		return false;
	}

	public static bool IsMigrationStarted()
	{
		return false;
	}

	public static void DrawButton(Graphics g, int x, int y, int scale = 50)
	{
	}

	public virtual byte[] Write()
	{
		return null;
	}

	public virtual void Load(byte[] data)
	{
	}

	public static bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

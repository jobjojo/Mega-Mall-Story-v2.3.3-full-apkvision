using java.io;
using java.lang;
using kairo.unity.system;
using main;
using system.billing;
using system.friend;
using system.lineup;
using system.migration;

namespace system;

public class KairoService : KairoBase
{
	private static AppData apdat_;

	private static MyBilling billing_;

	private static MyFriend friend_;

	private static MyLineup lineup_;

	private static MyMigration migration_;

	private JThread provideThread_;

	private bool autoProvision_;

	private int lastFormId_;

	public const int FLAG_BILLING_LIST_ERR = 65536;

	public const int FLAG_BILLING_IN = 131072;

	public const int FLAG_BILLING_OUT = 262144;

	public const int FLAG_BILLING_NOTES = 524288;

	public const int FLAG_BILLING_CONFIRM = 1048576;

	public const int FLAG_INSTALL_BONUS_GAME_SAVE_DATA = 2097152;

	public const int FLAG_INSTALL_BONUS_SYSTEM_SAVE_DATA = 1;

	public const int FLAG_MIGRATION_SYSTEM_SAVE_DATA = 2;

	private KairoService()
	{
	}

	public new static KairoService GetInstance()
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	public override void OnStart()
	{
	}

	protected override void Connected(string cgi, byte[] send, bool split)
	{
	}

	public override void Update()
	{
	}

	public override void Finish()
	{
	}

	protected override void OnLoad(InputStream stream)
	{
	}

	protected override void OnWrite(OutputStream os)
	{
	}

	protected override void OnNewGame(bool take)
	{
	}

	protected override void OnLoadGame(InputStream stream)
	{
	}

	protected override void OnWriteGame(OutputStream os)
	{
	}

	public override void Save()
	{
	}

	public override void SaveAll()
	{
	}
}

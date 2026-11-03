using system.install.ui;

namespace system.install;

public class MyInstall : InstallManager
{
	private MyInstall()
	{
	}

	internal override int[][] GetBonusItemRateTable()
	{
		return null;
	}

	public new static MyInstall GetInstance()
	{
		return null;
	}

	public static void Dispose()
	{
	}

	public override void Init()
	{
	}

	public override bool ExecuteApplyBonus(BonusItem item)
	{
		return false;
	}

	public override void Provisioning(BonusItem item)
	{
	}
}

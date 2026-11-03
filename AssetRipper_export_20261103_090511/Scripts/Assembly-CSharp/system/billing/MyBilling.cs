using form;
using kairo.unity.ui;
using main;
using system.billing.ui;

namespace system.billing;

public class MyBilling : BillingManager
{
	internal static IApplication app_;

	internal static FormManager fm_;

	internal static AppData apdat_;

	public const int ITEM_AD_OFF = 0;

	public const int TICKET_MAX = 999;

	public const string TICKET_PRODUCT = "ticket";

	public const int SHOP_OWNER = 4;

	private string[][] GetBillingTable()
	{
		return null;
	}

	private MyBilling()
	{
	}

	public new static MyBilling GetInstance()
	{
		return null;
	}

	public void Init()
	{
	}

	public override bool ExecuteApplyTask(ApplyTask task)
	{
		return false;
	}

	public override void Provisioning(ApplyTask task)
	{
	}

	public override void Cancel(ApplyTask task)
	{
	}

	public override bool CheckPlayingGame()
	{
		return false;
	}
}

using java.util;
using kairo.unity.util;
using system.billing.util;

namespace system.billing.ui;

public abstract class BillingManager : StoreBase
{
	internal static BillingManager instance_;

	internal static SecureString BASE64_PUBLIC_KEY;

	private BillingItem consumeItem_;

	private bool consumeResult_;

	private BillingItem[] items_;

	private Vector itemList_;

	private BillingItem[][] itemGroup_;

	private bool confirm_;

	private bool prepareGame_;

	private Vector applyTaskList_;

	private Vector purchaseLog_;

	private bool recoveryCheck_;

	private bool bootCheckRestore_;

	private object RegistApplyTask_lock;

	private object UpdateApplyTask_lock;

	internal BillingManager()
	{
	}

	public static BillingManager GetInstance()
	{
		return null;
	}

	public void Init(string[][] data)
	{
	}

	public void Init<T>(string[][] data) where T : BillingItem, new()
	{
	}

	public override void Init(string[][] data, string paymentProduct, params string[] subscription)
	{
	}

	public virtual void Init<T>(string[][] data, string paymentProduct, params string[] subscription) where T : BillingItem, new()
	{
	}

	public virtual void Load(byte[] data)
	{
	}

	public virtual void Load<T>(byte[] data, bool baseLoad) where T : BillingItem, new()
	{
	}

	public virtual byte[] Write()
	{
		return null;
	}

	public virtual void NewGame(bool take)
	{
	}

	public virtual void TakePurchaseItem(BillingItem item, bool take)
	{
	}

	public virtual void LoadGame(byte[] data)
	{
	}

	public virtual byte[] WriteGame()
	{
		return null;
	}

	public virtual void UpdateBillingItems(bool detail)
	{
	}

	public virtual void UpdateBillingItems(bool detail, bool marketPHP)
	{
	}

	public void Finish()
	{
	}

	public override BillingItem[] GetItems()
	{
		return null;
	}

	public BillingItem GetItem(int id)
	{
		return null;
	}

	public BillingItem GetItem(string productId)
	{
		return null;
	}

	public BillingItem[] GetSales()
	{
		return null;
	}

	public bool LaunchPurchaseFlow(BillingItem item)
	{
		return false;
	}

	internal void Purchase(BillingItem item)
	{
	}

	private bool Consume(BillingItem item)
	{
		return false;
	}

	private bool CheckRegistApply(BillingItem item, int type)
	{
		return false;
	}

	public bool CheckNextConsume()
	{
		return false;
	}

	public bool RegistApplyTask(bool notice)
	{
		return false;
	}

	public void UpdateApplyTask(bool notice)
	{
	}

	public virtual bool ExecuteApplyTask(ApplyTask task)
	{
		return false;
	}

	public virtual void Provisioning(ApplyTask task)
	{
	}

	public virtual void Cancel(ApplyTask task)
	{
	}

	public Vector GetPurchaseLog()
	{
		return null;
	}

	public void ClearPurchaseLog()
	{
	}

	public virtual bool CheckPlayingGame()
	{
		return false;
	}

	public void AddPurchaseLog(string productId, int state, Purchase purchase)
	{
	}

	public void ConnectRegistMarketPurchase()
	{
	}

	public string[][] ConnectGetMarketPurchase()
	{
		return null;
	}

	public virtual string GetMarketPurchaseFooterParam()
	{
		return null;
	}

	public bool AddApplyTask(ApplyTask task, bool force = false)
	{
		return false;
	}

	internal int SearchApplyTask(BillingItem item, int type)
	{
		return 0;
	}

	internal int SearchApplyTask(ApplyTask task)
	{
		return 0;
	}

	internal bool RemoveApplyTask(BillingItem item, int type)
	{
		return false;
	}

	internal bool RemoveApplyTask(ApplyTask task)
	{
		return false;
	}

	internal Vector GetApplyTaskList(bool game)
	{
		return null;
	}

	internal Vector GetItemList(bool game)
	{
		return null;
	}

	internal Vector GetItemListAll()
	{
		return null;
	}

	public BillingItem[][] GetItemGroup()
	{
		return null;
	}
}

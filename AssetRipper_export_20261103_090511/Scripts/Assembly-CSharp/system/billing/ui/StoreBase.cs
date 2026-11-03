using System.Collections.Generic;
using UnityEngine.Purchasing;
using java.io;
using system.billing.util;

namespace system.billing.ui;

public abstract class StoreBase : IStoreListener
{
	public enum RestoreResult
	{
		Complete = 0,
		Faild = 1
	}

	public const int VERSION = 103;

	private static KairoService ks_;

	private IStoreController storeController_;

	private IExtensionProvider storeExtensionProvider_;

	private List<Receipt> receipts_;

	private List<Receipt> illegalReceipts_;

	internal static string[] PAYMENT_PRODUCTS;

	private static bool isPurchaseProcessed_;

	private static Purchase processPurchaseResult_;

	private RestoreResult restoreResult_;

	private bool isRestoreProcessed_;

	private const string RESTORE_KEY = "_restore_transactions";

	protected const int TYPE_CONSUMABLE = 0;

	protected const int TYPE_NON_CONSUMABLE = 1;

	protected const int TYPE_SUBSCRIPTION = 2;

	public List<Receipt> GetReceipts()
	{
		return null;
	}

	public virtual void Init(string[][] data, string paymentProduct, params string[] subscription)
	{
	}

	private void InitializePurchasing(string[][] data, string paymentProduct, string[] subscriptions)
	{
	}

	public virtual bool CheckPaymentProduct_NonConsumable(int productType, string productID, string paymentProduct)
	{
		return false;
	}

	public bool IsInitialized()
	{
		return false;
	}

	protected void WaitForInitialized()
	{
	}

	public Purchase LaunchPurchaseFlow(string productId)
	{
		return null;
	}

	public RestoreResult Restore()
	{
		return RestoreResult.Complete;
	}

	public Inventory QueryInventory(bool querySkuDetails, List<string> moreItemSkus, bool checkSubscription = false)
	{
		return null;
	}

	public static string GetRealTimeStr(long timeMillis)
	{
		return null;
	}

	public bool ConsumeItem(Purchase purchase)
	{
		return false;
	}

	public Receipt SearchReceipt(string json)
	{
		return null;
	}

	public ProductType GetProductType(string productID)
	{
		return ProductType.Consumable;
	}

	public List<Receipt> GetIncompletePayments()
	{
		return null;
	}

	public bool HasIncompletePayments()
	{
		return false;
	}

	protected Purchase CompletePayment(Purchase purchase)
	{
		return null;
	}

	protected void IllegalPayment(Purchase purchase)
	{
	}

	public bool IsCompletePayment(Purchase purchase)
	{
		return false;
	}

	public void ProcessIncompletePayment(BillingItem item, Purchase purchase)
	{
	}

	protected void ProcessIncompletePayments()
	{
	}

	private Purchase SetTime(Receipt receipt)
	{
		return null;
	}

	private string GetUnityJson(string json, string orderId, string key)
	{
		return null;
	}

	public static long[] GetSubscriptionTime(string json, string productID)
	{
		return null;
	}

	private static List<string> GetSplitReceipt(string json, string key)
	{
		return null;
	}

	public bool CheckPaymentMaintenance()
	{
		return false;
	}

	public void Save(OutputStream stream)
	{
	}

	public void Load(InputStream stream)
	{
	}

	protected static int GetRestoreRequest()
	{
		return 0;
	}

	protected static void SetRestoreRequest(int request)
	{
	}

	public abstract BillingItem[] GetItems();

	public bool CallRestoreFlow(out string message)
	{
		message = null;
		return false;
	}

	internal static bool IsPaymentProduct(string productId)
	{
		return false;
	}
}

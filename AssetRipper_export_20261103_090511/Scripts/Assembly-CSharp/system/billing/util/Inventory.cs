using System.Collections.Generic;

namespace system.billing.util;

public class Inventory
{
	internal Dictionary<string, SkuDetails> mSkuMap;

	internal Dictionary<string, Purchase> mPurchaseMap;

	internal Inventory()
	{
	}

	public SkuDetails GetSkuDetails(string sku)
	{
		return null;
	}

	public Purchase GetPurchase(string sku)
	{
		return null;
	}

	public bool HasPurchase(string sku)
	{
		return false;
	}

	public bool HasDetails(string sku)
	{
		return false;
	}

	public void ErasePurchase(string sku)
	{
	}

	internal List<string> GetAllOwnedSkus()
	{
		return null;
	}

	internal List<string> GetAllOwnedSkus(string itemType)
	{
		return null;
	}

	internal List<Purchase> GetAllPurchases()
	{
		return null;
	}

	internal void AddSkuDetails(SkuDetails d)
	{
	}

	internal void AddPurchase(Purchase p)
	{
	}
}

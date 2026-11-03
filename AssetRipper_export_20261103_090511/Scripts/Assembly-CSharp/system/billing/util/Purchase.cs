namespace system.billing.util;

public class Purchase
{
	internal string mItemType;

	internal string mOrderId;

	internal string mPackageName;

	internal string mSku;

	internal long mPurchaseTime;

	internal int mPurchaseState;

	internal string mDeveloperPayload;

	internal string mToken;

	internal string mOriginalJson;

	internal string mSignature;

	public string GetItemType()
	{
		return null;
	}

	public string GetOrderId()
	{
		return null;
	}

	public string GetPackageName()
	{
		return null;
	}

	public string GetSku()
	{
		return null;
	}

	public long GetPurchaseTime()
	{
		return 0L;
	}

	public void SetPurchaseTime(long purchaseTime)
	{
	}

	public int GetPurchaseState()
	{
		return 0;
	}

	public string GetDeveloperPayload()
	{
		return null;
	}

	public string GetToken()
	{
		return null;
	}

	public string GetOriginalJson()
	{
		return null;
	}

	public string GetSignature()
	{
		return null;
	}

	public Purchase()
	{
	}

	public Purchase(string itemType, string jsonPurchaseInfo, string signature)
	{
	}

	private static string ReadJSon(string json, string key)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

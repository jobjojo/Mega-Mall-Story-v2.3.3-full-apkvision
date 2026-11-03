using java.io;
using kairo.unity.util;
using system.billing.util;

namespace system.billing.ui;

public class BillingItem
{
	public const int TYPE_INAPP = 0;

	public const int TYPE_SUBSCRIPTION = 1;

	internal int id_;

	internal SecureString productId_;

	internal string name_;

	internal int type_;

	internal string price_;

	internal string explain_;

	internal SecureInt flag_;

	internal SecureInt state_;

	internal bool provision_;

	internal Purchase purchase_;

	internal bool purchaseNow_;

	internal SecureString provisionType_;

	internal SecureString provisionValueS_;

	internal SecureInt provisionValueI_;

	internal bool testProduct_;

	internal bool consuming_;

	internal bool recovery_;

	internal SecureString seriesName_;

	internal SecureInt seriesNumber_;

	public const int STATE_SALE = 0;

	public const int STATE_PURCHASED = 1;

	public const int FLAG_CONSUME = 1;

	public const int FLAG_GAMEONLY = 2;

	public const int FLAG_NOTSALE = 4;

	public const int FLAG_NEW = 8;

	public virtual void Init(int id, int flag, string productId, string name, string price, int type, string explain)
	{
	}

	public int GetId()
	{
		return 0;
	}

	public string GetProductId()
	{
		return null;
	}

	public string GetName()
	{
		return null;
	}

	public int GetItemType()
	{
		return 0;
	}

	public string GetPrice()
	{
		return null;
	}

	public string GetExplain()
	{
		return null;
	}

	public int GetState()
	{
		return 0;
	}

	internal void ChangeState(int state)
	{
	}

	public string GetProvisionType()
	{
		return null;
	}

	public int GetProvisionValue()
	{
		return 0;
	}

	public string GetProvisionValueText()
	{
		return null;
	}

	public string GetSeriesName()
	{
		return null;
	}

	public int GetSeriesNumber()
	{
		return 0;
	}

	public bool CheckTestProduct()
	{
		return false;
	}

	public bool CheckProvision(bool force = false)
	{
		return false;
	}

	public void SetProvision(bool provision)
	{
	}

	public Purchase GetPurchase()
	{
		return null;
	}

	public void SetPurchase(Purchase purchase)
	{
	}

	public bool Check(int bit)
	{
		return false;
	}

	public void On(int bit)
	{
	}

	public void Off(int bit)
	{
	}

	public virtual void Serialize(OutputStream os)
	{
	}

	public virtual void Deserialize(InputStream stream)
	{
	}

	public static string GetPlatformProductID(string productID)
	{
		return null;
	}
}

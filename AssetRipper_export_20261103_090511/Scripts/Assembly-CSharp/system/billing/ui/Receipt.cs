using UnityEngine.Purchasing;
using java.io;
using kairo.unity.util;
using system.billing.util;

namespace system.billing.ui;

public class Receipt
{
	private enum State
	{
		None = 0,
		Consume = 1
	}

	private SecureString productID_;

	private SecureString receipt_;

	private SecureInt state_;

	private ProductType productType_;

	internal bool paymentComplete_;

	internal SecureLong purchaseTime_;

	private static byte[] PASSKEY;

	private int IsTicketProductTmp_;

	private string verificationResultTmp_;

	private string verificationJsonTmp_;

	private Receipt()
	{
	}

	public Receipt(Product p, string receipt = null)
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void Copy(Receipt r)
	{
	}

	public Purchase GetPurchase()
	{
		return null;
	}

	public void Consume()
	{
	}

	public bool IsConsume()
	{
		return false;
	}

	public string GetJson()
	{
		return null;
	}

	public string GetJsonParam(string tag)
	{
		return null;
	}

	public string GetReceipt()
	{
		return null;
	}

	public string GetProductID()
	{
		return null;
	}

	public ProductType GetProductType()
	{
		return ProductType.Consumable;
	}

	public string GetOrderId()
	{
		return null;
	}

	public bool IsTicketProduct()
	{
		return false;
	}

	public string VerificationReceipt(bool sub = true)
	{
		return null;
	}

	public void Save(OutputStream stream)
	{
	}

	public static Receipt Load(InputStream stream)
	{
		return null;
	}

	public static string GetItemType(Product p)
	{
		return null;
	}

	public static string GetItemType(ProductType type)
	{
		return null;
	}

	public static string PasswordEncode(byte[] src)
	{
		return null;
	}

	public static string PasswordEncode(string src)
	{
		return null;
	}

	public static byte[] PasswordDecodeToBytes(string src)
	{
		return null;
	}

	public static string PasswordDecodeToString(string src)
	{
		return null;
	}
}

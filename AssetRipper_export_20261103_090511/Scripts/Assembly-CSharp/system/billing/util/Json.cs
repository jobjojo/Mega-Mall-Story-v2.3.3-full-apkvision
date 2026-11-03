using UnityEngine.Purchasing;

namespace system.billing.util;

internal class Json
{
	internal static class JsonParam
	{
		public const string ORDER_ID = "orderId";

		public const string PACKAGE_NAME = "packageName";

		public const string PRODUCT_ID = "productId";

		public const string PURCHASE_TIME = "purchaseTime";

		public const string PURCHASE_STATE = "purchaseState";

		public const string DEVELOPER_PAYLOAD = "developerPayload";

		public const string TOKEN = "token";

		public const string PURCHASE_TOKEN = "purchaseToken";

		public const string SIGNATURE = "signature";
	}

	public static string ReadJSon(string json, string key)
	{
		return null;
	}

	public static string GetDetailJson(Product p)
	{
		return null;
	}

	private static string Record(string type, string value, string tag = "")
	{
		return null;
	}

	private static string MakeJson(string[] records)
	{
		return null;
	}

	public static string AdjustJson(Product p)
	{
		return null;
	}

	public static string AdjustJson(string receipt, string productID, string iOSPurchaseTime = "0")
	{
		return null;
	}

	public static string[] GetSendTapJoy(string receipt, Product[] products)
	{
		return null;
	}
}

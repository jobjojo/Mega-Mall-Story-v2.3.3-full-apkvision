using java.io;
using kairo.unity.util;

namespace kairo.unity.system.payment;

public class PaymentDataRecord : ISerializable
{
	internal string productId_;

	internal string orderId_;

	internal string purchaseToken_;

	internal long timestamp_;

	internal bool send_;

	internal int amount_;

	internal int actCode_;

	public const int ACT_NONE = 0;

	public const int ACT_NORMAL_BUY = 1;

	public const int ACT_NORMAL_USE = 2;

	public PaymentDataRecord()
	{
	}

	public PaymentDataRecord(string productId, string orderId, int amount, int actCode)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public string GetProductId()
	{
		return null;
	}

	public string GetOrderId()
	{
		return null;
	}

	public int GetAmount()
	{
		return 0;
	}

	public int GetActionCode()
	{
		return 0;
	}

	public void SetTimeStamp(long time)
	{
	}

	public void SetSendFlags(bool send)
	{
	}

	public void SetPurchaseToken(string token)
	{
	}

	public string GetTimeStamp(bool dayling = false)
	{
		return null;
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}

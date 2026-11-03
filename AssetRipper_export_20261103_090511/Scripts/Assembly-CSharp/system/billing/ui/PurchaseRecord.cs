using java.io;
using system.billing.util;

namespace system.billing.ui;

public class PurchaseRecord
{
	internal string productId_;

	internal string orderId_;

	internal int[] timestamp_;

	internal int state_;

	internal bool send_;

	public const int NONE = -1;

	public const int PURCHASE = 0;

	public const int CONSUME = 1;

	public const int PROVISION = 2;

	public PurchaseRecord()
	{
	}

	public PurchaseRecord(string productId, string orderId)
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

	public string GetTimeStamp(int state)
	{
		return null;
	}

	public string GetTimeStampNengappi(int state)
	{
		return null;
	}

	public int GetState()
	{
		return 0;
	}

	public void ChangeState(int state, Purchase purchase)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

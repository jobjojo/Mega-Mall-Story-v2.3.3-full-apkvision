using java.io;
using kairo.unity.util;

namespace system.billing.ui;

public class ApplyTask
{
	public const int TYPE_PROVISION = 0;

	public const int TYPE_CANCEL = 1;

	public BillingItem item_;

	public SecureString gift_;

	public bool notice_;

	public bool lock_;

	public int type_;

	public SecureString name_;

	public SecureString productId_;

	public SecureString provisionType_;

	public SecureString provisionValueS_;

	public SecureInt provisionValueI_;

	public int talkCharaId_;

	public SecureString talkText_;

	public ApplyTask()
	{
	}

	public ApplyTask(BillingItem item, int type, bool notice)
	{
	}

	public ApplyTask(string gift)
	{
	}

	private void Init(BillingItem item, string gift, int type, bool notice)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public bool Enable()
	{
		return false;
	}

	public bool IsItem()
	{
		return false;
	}

	public bool IsGift()
	{
		return false;
	}

	public bool IsGiftScript()
	{
		return false;
	}

	public bool IsGameApply()
	{
		return false;
	}

	public bool Equals(ApplyTask obj)
	{
		return false;
	}
}

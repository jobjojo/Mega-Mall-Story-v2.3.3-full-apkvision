using system.tapjoy.ui;

namespace system.tapjoy;

public class MyTapjoy : Tapjoy
{
	private const string SDK_KEY = "";

	private const string OFFEREALL_NAME = "GetFreeTicket";

	public MyTapjoy()
		: base(null, null, log: false)
	{
	}

	public new static MyTapjoy GetInstance()
	{
		return null;
	}
}

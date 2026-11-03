namespace System.Threading;

public struct SpinWait
{
	internal static readonly int SpinCountforSpinBeforeWait;

	private int _count;

	public int Count => 0;

	public bool NextSpinWillYield => false;

	public void SpinOnce()
	{
	}

	public void SpinOnce(int sleep1Threshold)
	{
	}

	private void SpinOnceCore(int sleep1Threshold)
	{
	}
}

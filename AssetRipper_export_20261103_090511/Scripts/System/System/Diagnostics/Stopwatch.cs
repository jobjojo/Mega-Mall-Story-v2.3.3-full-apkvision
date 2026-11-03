namespace System.Diagnostics;

public class Stopwatch
{
	public static readonly long Frequency;

	public static readonly bool IsHighResolution;

	private long elapsed;

	private long started;

	private bool is_running;

	public TimeSpan Elapsed => default;

	public long ElapsedMilliseconds => 0L;

	public long ElapsedTicks => 0L;

	public bool IsRunning => false;

	public static long GetTimestamp()
	{
		return 0L;
	}

	public void Reset()
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}
}

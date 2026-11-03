using System.Collections.Generic;
using System.Threading;

namespace java.lang;

public class JThread
{
	public const int MAX_PRIORITY = 1;

	public const int MIN_PRIORITY = 2;

	public const int NORM_PRIORITY = 0;

	private Thread thread_;

	private int priority_;

	private static List<JThread> threadBuffer_;

	internal static bool abort_;

	public static bool operator ==(JThread obj1, JThread obj2)
	{
		return false;
	}

	public static bool operator !=(JThread obj1, JThread obj2)
	{
		return false;
	}

	public JThread()
	{
	}

	public JThread(JRunnable target)
	{
	}

	public JThread(ThreadStart start)
	{
	}

	public int GetPriority()
	{
		return 0;
	}

	public void SetPriority(int newPriority)
	{
	}

	public void Start()
	{
	}

	public void Interrupt()
	{
	}

	public static void Sleep(long millis)
	{
	}

	public static void Yield()
	{
	}

	public static JThread CurrentThread()
	{
		return null;
	}

	public static bool IsCurrentThread(JThread thread)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

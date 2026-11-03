using System.Collections.Generic;
using System.Threading;

namespace kairo.unity.ui;

public class Handler
{
	private class PostData
	{
		public ThreadStart start;

		public long uptimeMillis;

		public long delayMillis;

		public long beginTime;

		public PostData(ThreadStart start, object token = null)
		{
		}
	}

	private List<PostData> postQueue_;

	private Thread thread_;

	public bool Post(ThreadStart start)
	{
		return false;
	}

	public bool PostAtTime(ThreadStart start, long uptimeMillis)
	{
		return false;
	}

	public bool PostDelayed(ThreadStart start, long delayMillis)
	{
		return false;
	}

	private void Run()
	{
	}
}

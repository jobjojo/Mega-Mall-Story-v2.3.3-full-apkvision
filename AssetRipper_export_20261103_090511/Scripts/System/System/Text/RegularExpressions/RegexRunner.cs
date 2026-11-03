namespace System.Text.RegularExpressions;

public abstract class RegexRunner
{
	protected internal int runtextbeg;

	protected internal int runtextend;

	protected internal int runtextstart;

	protected internal string runtext;

	protected internal int runtextpos;

	protected internal int[] runtrack;

	protected internal int runtrackpos;

	protected internal int[] runstack;

	protected internal int runstackpos;

	protected internal int[] runcrawl;

	protected internal int runcrawlpos;

	protected internal int runtrackcount;

	protected internal Match runmatch;

	protected internal Regex runregex;

	private int _timeout;

	private bool _ignoreTimeout;

	private int _timeoutOccursAt;

	private int _timeoutChecksToSkip;

	protected internal RegexRunner()
	{
	}

	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
	{
		return null;
	}

	private void StartTimeoutWatch()
	{
	}

	protected void CheckTimeout()
	{
	}

	private void DoCheckTimeout()
	{
	}

	protected abstract void Go();

	protected abstract bool FindFirstChar();

	protected abstract void InitTrackCount();

	private void InitMatch()
	{
	}

	private Match TidyMatch(bool quick)
	{
		return null;
	}

	protected void EnsureStorage()
	{
	}

	protected bool IsBoundary(int index, int startpos, int endpos)
	{
		return false;
	}

	protected bool IsECMABoundary(int index, int startpos, int endpos)
	{
		return false;
	}

	protected void DoubleTrack()
	{
	}

	protected void DoubleStack()
	{
	}

	protected void DoubleCrawl()
	{
	}

	protected void Crawl(int i)
	{
	}

	protected int Popcrawl()
	{
		return 0;
	}

	protected int Crawlpos()
	{
		return 0;
	}

	protected void Capture(int capnum, int start, int end)
	{
	}

	protected void TransferCapture(int capnum, int uncapnum, int start, int end)
	{
	}

	protected void Uncapture()
	{
	}

	protected bool IsMatched(int cap)
	{
		return false;
	}

	protected int MatchIndex(int cap)
	{
		return 0;
	}

	protected int MatchLength(int cap)
	{
		return 0;
	}
}

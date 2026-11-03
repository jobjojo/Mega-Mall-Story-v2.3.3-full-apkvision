using System;

namespace Mono.Globalization.Unicode;

internal class CodePointIndexer
{
	[Serializable]
	internal struct TableRange(int start, int end, int indexStart)
	{
		public readonly int Start = 0;

		public readonly int End = 0;

		public readonly int Count = 0;

		public readonly int IndexStart = 0;

		public readonly int IndexEnd = 0;
	}

	private readonly TableRange[] ranges;

	public readonly int TotalCount;

	private int defaultIndex;

	private int defaultCP;

	public CodePointIndexer(int[] starts, int[] ends, int defaultIndex, int defaultCP)
	{
	}

	public int ToIndex(int cp)
	{
		return 0;
	}
}

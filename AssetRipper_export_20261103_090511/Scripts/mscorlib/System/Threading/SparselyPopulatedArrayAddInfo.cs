namespace System.Threading;

internal struct SparselyPopulatedArrayAddInfo<T> where T : class
{
	private SparselyPopulatedArrayFragment<T> _source = null;

	private int _index = 0;

	internal SparselyPopulatedArrayFragment<T> Source => null;

	internal int Index => 0;

	internal SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
	{
	}
}

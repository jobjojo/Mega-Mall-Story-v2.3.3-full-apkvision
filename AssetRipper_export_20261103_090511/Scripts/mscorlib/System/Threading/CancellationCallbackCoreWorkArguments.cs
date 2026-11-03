namespace System.Threading;

internal struct CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
{
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment = null;

	internal int _currArrayIndex = 0;
}

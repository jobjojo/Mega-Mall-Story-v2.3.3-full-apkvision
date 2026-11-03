namespace Unity.Properties;

public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement>
{
	protected override InstantiationKind InstantiationKind => InstantiationKind.Activator;

	protected override TElement[] InstantiateWithCount(int count)
	{
		return null;
	}

	protected override TElement[] Instantiate()
	{
		return null;
	}
}

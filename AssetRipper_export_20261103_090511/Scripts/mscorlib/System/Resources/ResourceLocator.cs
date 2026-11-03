namespace System.Resources;

internal struct ResourceLocator
{
	internal object _value = null;

	internal int _dataPos = 0;

	internal int DataPosition => 0;

	internal object Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ResourceLocator(int dataPos, object value)
	{
	}

	internal static bool CanCache(ResourceTypeCode value)
	{
		return false;
	}
}

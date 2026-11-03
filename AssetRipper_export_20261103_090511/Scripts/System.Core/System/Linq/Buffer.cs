using System.Collections.Generic;

namespace System.Linq;

internal struct Buffer<TElement>
{
	internal TElement[] items = null;

	internal int count = 0;

	internal Buffer(IEnumerable<TElement> source)
	{
	}

	internal TElement[] ToArray()
	{
		return null;
	}
}

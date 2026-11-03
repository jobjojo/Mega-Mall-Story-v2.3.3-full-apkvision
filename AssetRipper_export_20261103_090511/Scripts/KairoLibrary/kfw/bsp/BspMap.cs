using System.Collections.Generic;
using UnityEngine;

namespace kfw.bsp;

public class BspMap<T> where T : IBspObject
{
	private int offsetX_;

	private int offsetY_;

	private int bspWidth_;

	private int bspHeight_;

	private BspNode[][] nodes_;

	private List<T> list_;

	private BspContents[] bspList_;

	private T[] bspResult_;

	private T[][] GetRange_result;

	public int Count => 0;

	public T this[int index] => default;

	public BspMap(int width, int height)
	{
	}

	private void Expand(BspRange range)
	{
	}

	public void Add(T contents)
	{
	}

	public void Remove(T contents)
	{
	}

	public void Update(T contents)
	{
	}

	public T[] GetRange(float x, float y, float width, float height)
	{
		return null;
	}

	public int GetRange(float x, float y, float width, float height, out T[] list)
	{
		list = null;
		return 0;
	}

	private BspRange GetBspPoints(Rect rect)
	{
		return default;
	}
}

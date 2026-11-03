using UnityEngine;

namespace kfw.bsp;

public interface IBspObject
{
	bool GetBspRect(out Rect rect);

	BspKey GetBspKey();

	void SetBspKey(BspKey key);
}

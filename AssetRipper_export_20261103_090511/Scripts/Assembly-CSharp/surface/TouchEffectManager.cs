using java.util;
using kairo.unity.surface;
using kairo.unity.ui;
using kairo.unity.util;

namespace surface;

public class TouchEffectManager
{
	internal static TouchEffectManager instance_;

	public Vector<TouchEffect> effects;

	private FastVector<TouchEffect> effectsBuffer_;

	private TouchEffectManager()
	{
	}

	public static TouchEffectManager GetInstance()
	{
		return null;
	}

	public void Add(TouchEffect effect)
	{
	}

	public void Frame()
	{
	}

	public void Draw(Graphics g)
	{
	}

	public void Clear()
	{
	}

	public void RemoveEffect(TouchEffect effect)
	{
	}

	public void RemoveEffect(int index)
	{
	}

	public void RemoveSurface(SurfaceBase surface)
	{
	}

	public void RemoveId(int id)
	{
	}

	public void RemoveComponentId(SurfaceBase surface, int componentId)
	{
	}

	public void RemoveComponentKey(SurfaceBase surface, long componentKey)
	{
	}

	public TouchEffect AddEffect(SurfaceBase surface, int id, float x, float y, TouchComponent component)
	{
		return null;
	}

	public TouchEffect AddEffect(SurfaceBase surface, int id, float x, float y, TouchComponent component, object arg)
	{
		return null;
	}
}

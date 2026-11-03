using kairo.unity.surface;
using kairo.unity.ui;
using main;

namespace surface;

public class TouchEffect
{
	private AppData apdat_;

	public SurfaceBase surface_;

	public float x_;

	public float y_;

	public float vx_;

	public float vy_;

	public float ax_;

	public float ay_;

	public long time_;

	public long key_;

	public int id_;

	public object arg_;

	internal long lastFrameTime_;

	public const int ID_BUTTON = 0;

	public const int ID_BUILDTAB = 1;

	public const int ID_HUMAN = 2;

	public const int ID_MAPCHIP = 3;

	public TouchEffect()
	{
	}

	public TouchEffect(SurfaceBase surface, int id, float x, float y, TouchComponent component, object arg)
	{
	}

	public void Init(SurfaceBase surface, int id, float x, float y, TouchComponent component)
	{
	}

	public void Init(SurfaceBase surface, int id, float x, float y, TouchComponent component, object arg)
	{
	}

	public bool Frame()
	{
		return false;
	}

	public void Draw(Graphics g)
	{
	}
}

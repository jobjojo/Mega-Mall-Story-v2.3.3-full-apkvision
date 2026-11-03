using kairo.unity.surface;
using kairo.unity.ui;

namespace surface;

public class SurfaceManager : SurfaceManagerBase
{
	internal static SurfaceManager instance_;

	public static GameView view_;

	public static GamePad gpad_;

	internal bool wide_;

	internal bool layoutMode_;

	private SurfaceManager()
	{
	}

	public static void Setup()
	{
	}

	public override void AdjustSurfaceLayout()
	{
	}

	public override void Draw(Graphics g)
	{
	}

	public override void DrawComponents(Graphics g)
	{
	}

	public void UpdateAdMobView()
	{
	}

	public void SetLayoutMode(bool enable)
	{
	}

	public bool IsLayoutMode()
	{
		return false;
	}
}

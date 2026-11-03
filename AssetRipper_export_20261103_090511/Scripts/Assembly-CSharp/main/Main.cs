using kairo.unity.form;
using kairo.unity.ui;

namespace main;

public class Main : IApplication
{
	public static SoundBase jingle_;

	public static int jingleWait_;

	public static Main GetInstance()
	{
		return null;
	}

	protected override void OnCreate()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDraw()
	{
	}

	protected override void OnResume()
	{
	}

	protected override void OnSuspend()
	{
	}

	protected override void OnDestroy()
	{
	}

	public static void SetJingle(SoundBase sound, int wait = 20)
	{
	}

	public static SoundBase GetJingle()
	{
		return null;
	}

	public override FormManagerBase GetFormManager()
	{
		return null;
	}
}

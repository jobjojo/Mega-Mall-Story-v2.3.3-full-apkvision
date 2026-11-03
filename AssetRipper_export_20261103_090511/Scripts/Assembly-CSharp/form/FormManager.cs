using kairo.unity.form;

namespace form;

public class FormManager : FormManagerBase
{
	private static FormManager instance_;

	private long subTime_;

	private int lastTopFormId_;

	private int lastTopFormType_;

	private int lastTopFormChara_;

	public int loopCounter_;

	internal long beginUpdateTime_;

	internal long beginDrawTime_;

	public long frameMillSecond_;

	public int gcCount_;

	public new static FormManager GetInstance()
	{
		return null;
	}

	internal FormManager()
	{
	}

	public override void Resume()
	{
	}

	protected override void PreUpdate()
	{
	}

	protected override void Updated()
	{
	}

	protected override void PreDraw()
	{
	}

	protected override void Drawn()
	{
	}
}

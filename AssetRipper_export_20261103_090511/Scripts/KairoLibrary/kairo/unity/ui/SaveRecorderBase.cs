namespace kairo.unity.ui;

public abstract class SaveRecorderBase
{
	private static SaveRecorderBase objectInstance_;

	public SaveRecorderBase()
	{
	}

	public static SaveRecorderBase GetInstance()
	{
		return null;
	}

	internal abstract void Lock();

	internal abstract void Unlock(bool forced);
}

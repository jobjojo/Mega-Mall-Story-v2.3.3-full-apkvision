namespace kairo.unity.task;

public class TaskFrameChecker
{
	private Task task_;

	private int frame_;

	public int Frame { get; private set; }

	public int Length { get; private set; }

	internal void Init(Task task)
	{
	}

	public bool Check(int length)
	{
		return false;
	}

	public bool End(int length)
	{
		return false;
	}

	public bool IsFinished()
	{
		return false;
	}

	public static implicit operator int(TaskFrameChecker obj)
	{
		return 0;
	}
}

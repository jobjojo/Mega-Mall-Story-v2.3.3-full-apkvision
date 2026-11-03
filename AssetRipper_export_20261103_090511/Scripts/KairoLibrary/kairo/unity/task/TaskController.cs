using System.Collections.Generic;
using java.io;
using kairo.unity.ui;
using kairo.unity.util;

namespace kairo.unity.task;

public class TaskController : ISerializable
{
	public delegate bool DoTaskDelegate(TaskController controller, Task task, out bool finish);

	private Task first_;

	private Task pointer_;

	private List<Task> stack_;

	private bool beginInsert_;

	private DoTaskDelegate DoTask;

	public Id FirstId => null;

	public Task First => null;

	public bool Empty => false;

	public Task Last => null;

	public TaskController(DoTaskDelegate method = null)
	{
	}

	public void SetDoTaskMethod(DoTaskDelegate method)
	{
	}

	public void Update()
	{
	}

	private bool Update(Task data)
	{
		return false;
	}

	protected virtual void OnBeginTask()
	{
	}

	protected virtual void OnEndTask()
	{
	}

	public virtual void Clear()
	{
	}

	public virtual Task Add(Task add)
	{
		return null;
	}

	public void Remove(Task task)
	{
	}

	public void BeginChilds()
	{
	}

	public void EndChilds()
	{
	}

	public Task Search(int id)
	{
		return null;
	}

	private Task Search(Task task, int id)
	{
		return null;
	}

	public Task[] SearchAll(int id)
	{
		return null;
	}

	private void SearchAll(Task task, int id, List<Task> list)
	{
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public int GetTotal()
	{
		return 0;
	}

	public void BeginInsert()
	{
	}

	public override string ToString()
	{
		return null;
	}
}

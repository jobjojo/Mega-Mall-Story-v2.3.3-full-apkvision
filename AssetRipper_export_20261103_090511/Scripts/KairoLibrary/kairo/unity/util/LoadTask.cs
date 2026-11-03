using System;
using System.Reflection;
using kairo.unity.ui;

namespace kairo.unity.util;

public class LoadTask
{
	public delegate void TaskMethod(string name);

	internal enum States
	{
		None = 0,
		Loading = 1,
		Complete = 2,
		Failure = 3
	}

	internal object Object;

	internal string Name;

	internal FieldInfo FieldInfo;

	internal int ResRecord;

	internal string ResDirectory;

	internal TaskMethod Method;

	internal ResourceManager Resource;

	internal States state_;

	internal Exception error_;

	internal LoadTask(FieldInfo fieldInfo, int resRecord, object obj = null, ResourceManager res = null)
	{
	}

	internal LoadTask(FieldInfo fieldInfo, string resDirectory, object obj = null, ResourceManager res = null)
	{
	}

	internal LoadTask(TaskMethod method, string name)
	{
	}

	internal void Execute()
	{
	}
}

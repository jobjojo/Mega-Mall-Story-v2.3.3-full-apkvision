using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using kairo.unity.ui;

namespace kairo.unity.util;

public class ResourceLoader
{
	private List<LoadTask> tasks_;

	public int Progress => 0;

	public void Add<T>(Expression<Func<T>> e, int resRecord, object obj = null, ResourceManager res = null)
	{
	}

	public void Add<T>(Expression<Func<T>> e, string resName, object obj = null)
	{
	}

	public void Add(LoadTask.TaskMethod method, string name)
	{
	}

	private void Add(LoadTask task)
	{
	}

	private FieldInfo GetField<T>(object obj, Expression<Func<T>> e)
	{
		return null;
	}

	public void StartLoading()
	{
	}

	private void CallBack(object obj)
	{
	}
}

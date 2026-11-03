using System.Collections.Generic;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.mono;

public class InterfaceBase<Interface> : MonoBehaviour where Interface : MonoBehaviour
{
	private bool initialized_;

	private List<KairoFrameworkFieldAccessor> fieldAccessors_;

	protected static IApplication App => null;

	private static string Name => null;

	public static GameObject Instantiate()
	{
		return null;
	}

	internal static bool Exist()
	{
		return false;
	}

	internal void OnCreate()
	{
	}

	public void LoadSerializedObjects()
	{
	}

	protected virtual void Init()
	{
	}

	protected void Start()
	{
	}

	private void InitField(bool onCreate)
	{
	}

	public static Interface GetInstance()
	{
		return null;
	}

	public void Add(string fieldName, KairoFrameworkFieldAccessor.GetDelegate getMethod, KairoFrameworkFieldAccessor.SetDelegate setMethod)
	{
	}

	protected virtual void OnInitFieldAccessor()
	{
	}

	public KairoFrameworkFieldAccessor[] GetFieldAccessor()
	{
		return null;
	}
}

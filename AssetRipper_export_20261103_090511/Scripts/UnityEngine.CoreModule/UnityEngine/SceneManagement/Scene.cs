using System;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

[Serializable]
[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[SerializeField]
	[HideInInspector]
	private int m_Handle;

	public int handle => 0;

	public string name => null;

	public int buildIndex => 0;

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static string GetNameInternal(int sceneHandle)
	{
		return null;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static int GetBuildIndexInternal(int sceneHandle)
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}
}

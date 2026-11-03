using System;

namespace UnityEngine.SceneManagement;

[Serializable]
public struct LoadSceneParameters(LoadSceneMode mode)
{
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode = LoadSceneMode.Single;

	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode = LocalPhysicsMode.None;
}

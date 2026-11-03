using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager
{
	internal static bool s_AllowLoadScene;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static UnityAction<Scene> sceneUnloaded;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static UnityAction<Scene, Scene> activeSceneChanged;

	public static int sceneCount
	{
		[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
		[NativeMethod("GetSceneCount")]
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		get
		{
			return 0;
		}
	}

	public static int sceneCountInBuildSettings => 0;

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetActiveScene()
	{
		return default;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	public static Scene GetSceneAt(int index)
	{
		return default;
	}

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}

	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		outSuccess = default;
		return null;
	}

	[RequiredByNativeCode]
	internal static AsyncOperation LoadFirstScene_Internal(bool async)
	{
		return null;
	}

	public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
	{
	}

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
	{
		return default;
	}

	public static void LoadScene(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
	{
	}

	public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
	{
		return default;
	}

	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
	{
		return null;
	}

	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
	{
		return null;
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
	{
		return null;
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
	{
		return null;
	}

	[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
	public static bool UnloadScene(int sceneBuildIndex)
	{
		return false;
	}

	[Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
	public static bool UnloadScene(string sceneName)
	{
		return false;
	}

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene)
	{
	}

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
	{
	}

	private static void GetActiveScene_Injected(out Scene ret)
	{
		ret = default;
	}

	private static void GetSceneAt_Injected(int index, out Scene ret)
	{
		ret = default;
	}
}

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Misc/Player.h")]
public class Application
{
	public delegate void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg);

	public delegate void LowMemoryCallback();

	public delegate void MemoryUsageChangedCallback(in ApplicationMemoryUsageChange usage);

	public delegate void LogCallback(string condition, string stackTrace, LogType type);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static LowMemoryCallback m_lowMemory;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static MemoryUsageChangedCallback m_memoryUsageChanged;

	private static LogCallback s_LogCallbackHandler;

	private static LogCallback s_LogCallbackHandlerThreaded;

	internal static AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<bool> m_focusChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<string> m_deepLinkActivated;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Func<bool> m_wantsToQuit;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action m_quitting;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action m_unloading;

	private static CancellationTokenSource s_currentCancellationTokenSource;

	private static LogCallback s_RegisterLogCallbackDeprecated;

	[Obsolete("This property is deprecated, please use LoadLevelAsync to detect if a specific scene is currently loading.")]
	public static bool isLoadingLevel
	{
		[FreeFunction("GetPreloadManager().IsLoadingOrQueued")]
		get
		{
			return false;
		}
	}

	[Obsolete("Streaming was a Unity Web Player feature, and is removed. This property is deprecated and always returns 0.")]
	public static int streamedBytes => 0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Application.webSecurityEnabled is no longer supported, since the Unity Web Player is no longer supported by Unity", true)]
	public static bool webSecurityEnabled => false;

	public static bool isPlaying
	{
		[FreeFunction("IsWorldPlaying")]
		get
		{
			return false;
		}
	}

	public static bool isFocused
	{
		[FreeFunction("IsPlayerFocused")]
		get
		{
			return false;
		}
	}

	public static string buildGUID
	{
		[FreeFunction("Application_Bindings::GetBuildGUID")]
		get
		{
			return null;
		}
	}

	public static bool runInBackground
	{
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		get
		{
			return false;
		}
		[FreeFunction("SetPlayerSettingsRunInBackground")]
		set
		{
		}
	}

	public static bool isBatchMode
	{
		[FreeFunction("::IsBatchmode")]
		get
		{
			return false;
		}
	}

	internal static bool isTestRun
	{
		[FreeFunction("::IsTestRun")]
		get
		{
			return false;
		}
	}

	internal static bool isHumanControllingUs
	{
		[FreeFunction("::IsHumanControllingUs")]
		get
		{
			return false;
		}
	}

	public static string dataPath
	{
		[FreeFunction("GetAppDataPath", IsThreadSafe = true)]
		get
		{
			return null;
		}
	}

	public static string streamingAssetsPath
	{
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = true)]
		get
		{
			return null;
		}
	}

	public static string persistentDataPath
	{
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		get
		{
			return null;
		}
	}

	public static string temporaryCachePath
	{
		[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
		get
		{
			return null;
		}
	}

	public static string absoluteURL
	{
		[FreeFunction("GetPlayerSettings().GetAbsoluteURL")]
		get
		{
			return null;
		}
	}

	public static string unityVersion
	{
		[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = true)]
		get
		{
			return null;
		}
	}

	internal static int unityVersionVer
	{
		[FreeFunction("Application_Bindings::GetUnityVersionVer", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	internal static int unityVersionMaj
	{
		[FreeFunction("Application_Bindings::GetUnityVersionMaj", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	internal static int unityVersionMin
	{
		[FreeFunction("Application_Bindings::GetUnityVersionMin", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	public static string version
	{
		[FreeFunction("GetApplicationInfo().GetVersion")]
		get
		{
			return null;
		}
	}

	public static string installerName
	{
		[FreeFunction("GetApplicationInfo().GetInstallerName")]
		get
		{
			return null;
		}
	}

	public static string identifier
	{
		[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
		get
		{
			return null;
		}
	}

	public static ApplicationInstallMode installMode
	{
		[FreeFunction("GetApplicationInfo().GetInstallMode")]
		get
		{
			return ApplicationInstallMode.Unknown;
		}
	}

	public static ApplicationSandboxType sandboxType
	{
		[FreeFunction("GetApplicationInfo().GetSandboxType")]
		get
		{
			return ApplicationSandboxType.Unknown;
		}
	}

	public static string productName
	{
		[FreeFunction("GetPlayerSettings().GetProductName")]
		get
		{
			return null;
		}
	}

	public static string companyName
	{
		[FreeFunction("GetPlayerSettings().GetCompanyName")]
		get
		{
			return null;
		}
	}

	public static string cloudProjectId
	{
		[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
		get
		{
			return null;
		}
	}

	public static int targetFrameRate
	{
		[FreeFunction("GetTargetFrameRate")]
		get
		{
			return 0;
		}
		[FreeFunction("SetTargetFrameRate")]
		set
		{
		}
	}

	[Obsolete("Use SetStackTraceLogType/GetStackTraceLogType instead")]
	public static StackTraceLogType stackTraceLogType
	{
		[FreeFunction("Application_Bindings::GetStackTraceLogType")]
		get
		{
			return StackTraceLogType.None;
		}
		[FreeFunction("Application_Bindings::SetStackTraceLogType")]
		set
		{
		}
	}

	public static string consoleLogPath
	{
		[FreeFunction("GetConsoleLogPath")]
		get
		{
			return null;
		}
	}

	public static ThreadPriority backgroundLoadingPriority
	{
		[FreeFunction("GetPreloadManager().GetThreadPriority")]
		get
		{
			return ThreadPriority.Low;
		}
		[FreeFunction("GetPreloadManager().SetThreadPriority")]
		set
		{
		}
	}

	public static bool genuine
	{
		[FreeFunction("IsApplicationGenuine")]
		get
		{
			return false;
		}
	}

	public static bool genuineCheckAvailable
	{
		[FreeFunction("IsApplicationGenuineAvailable")]
		get
		{
			return false;
		}
	}

	internal static bool submitAnalytics
	{
		[FreeFunction("GetPlayerSettings().GetSubmitAnalytics")]
		get
		{
			return false;
		}
	}

	[Obsolete("This property is deprecated, please use SplashScreen.isFinished instead")]
	public static bool isShowingSplashScreen => false;

	public static RuntimePlatform platform
	{
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)]
		get
		{
			return RuntimePlatform.OSXEditor;
		}
	}

	public static bool isMobilePlatform => false;

	public static bool isConsolePlatform => false;

	public static SystemLanguage systemLanguage
	{
		[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
		get
		{
			return SystemLanguage.Afrikaans;
		}
	}

	public static NetworkReachability internetReachability
	{
		[FreeFunction("GetInternetReachability")]
		get
		{
			return NetworkReachability.NotReachable;
		}
	}

	[Obsolete("use Application.isEditor instead")]
	public static bool isPlayer => false;

	public static CancellationToken exitCancellationToken => default;

	[Obsolete("Use SceneManager.sceneCountInBuildSettings")]
	public static int levelCount => 0;

	[Obsolete("Use SceneManager to determine what scenes have been loaded")]
	public static int loadedLevel => 0;

	[Obsolete("Use SceneManager to determine what scenes have been loaded")]
	public static string loadedLevelName => null;

	public static bool isEditor => false;

	public static event LowMemoryCallback lowMemory
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event MemoryUsageChangedCallback memoryUsageChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event LogCallback logMessageReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event LogCallback logMessageReceivedThreaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event UnityAction onBeforeRender
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> focusChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<string> deepLinkActivated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Func<bool> wantsToQuit
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action quitting
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action unloading
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode)
	{
	}

	public static void Quit()
	{
	}

	[FreeFunction("GetInputManager().CancelQuitApplication")]
	[Obsolete("CancelQuit is deprecated. Use the wantsToQuit event instead.")]
	public static void CancelQuit()
	{
	}

	[FreeFunction("Application_Bindings::Unload")]
	public static void Unload()
	{
	}

	[FreeFunction("UpdateMemoryUsage")]
	internal static void SimulateMemoryUsage(ApplicationMemoryUsage usage)
	{
	}

	[Obsolete("Streaming was a Unity Web Player feature, and is removed. This function is deprecated and always returns 1.0 for valid level indices.")]
	public static float GetStreamProgressForLevel(int levelIndex)
	{
		return 0f;
	}

	[Obsolete("Streaming was a Unity Web Player feature, and is removed. This function is deprecated and always returns 1.0.")]
	public static float GetStreamProgressForLevel(string levelName)
	{
		return 0f;
	}

	public static bool CanStreamedLevelBeLoaded(int levelIndex)
	{
		return false;
	}

	[FreeFunction("Application_Bindings::CanStreamedLevelBeLoaded")]
	public static bool CanStreamedLevelBeLoaded(string levelName)
	{
		return false;
	}

	[FreeFunction]
	public static bool IsPlaying([NotNull("NullExceptionObject")] Object obj)
	{
		return false;
	}

	[Obsolete("Application.GetBuildTags is no longer supported and will be removed.", false)]
	[FreeFunction("GetBuildSettings().GetBuildTags")]
	public static string[] GetBuildTags()
	{
		return null;
	}

	[FreeFunction("GetBuildSettings().SetBuildTags")]
	[Obsolete("Application.SetBuildTags is no longer supported and will be removed.", false)]
	public static void SetBuildTags(string[] buildTags)
	{
	}

	[FreeFunction("GetBuildSettings().GetHasPROVersion")]
	public static bool HasProLicense()
	{
		return false;
	}

	[FreeFunction("HasARGV")]
	internal static bool HasARGV(string name)
	{
		return false;
	}

	[FreeFunction("GetFirstValueForARGV")]
	internal static string GetValueForARGV(string name)
	{
		return null;
	}

	[Obsolete("Application.ExternalEval is deprecated. See https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html for alternatives.")]
	public static void ExternalEval(string script)
	{
	}

	[FreeFunction("Application_Bindings::ExternalCall")]
	private static void Internal_ExternalCall(string script)
	{
	}

	[FreeFunction("GetAdsIdHandler().RequestAdsIdAsync")]
	public static bool RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod)
	{
		return false;
	}

	[FreeFunction("OpenURL")]
	public static void OpenURL(string url)
	{
	}

	[Obsolete("Use UnityEngine.Diagnostics.Utils.ForceCrash")]
	public static void ForceCrash(int mode)
	{
	}

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	private static void SetLogCallbackDefined(bool defined)
	{
	}

	[FreeFunction("GetStackTraceLogType")]
	public static StackTraceLogType GetStackTraceLogType(LogType logType)
	{
		return StackTraceLogType.None;
	}

	[FreeFunction("SetStackTraceLogType")]
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
	{
	}

	[FreeFunction("Application_Bindings::RequestUserAuthorization")]
	public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
	{
		return null;
	}

	[FreeFunction("Application_Bindings::HasUserAuthorization")]
	public static bool HasUserAuthorization(UserAuthorization mode)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal static void CallLowMemory(ApplicationMemoryUsage usage)
	{
	}

	[RequiredByNativeCode]
	internal static bool HasLogCallback()
	{
		return false;
	}

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
	{
	}

	internal static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
	{
	}

	private static string ObjectToJSString(object o)
	{
		return null;
	}

	[Obsolete("Application.ExternalCall is deprecated. See https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html for alternatives.")]
	public static void ExternalCall(string functionName, params object[] args)
	{
	}

	private static string BuildInvocationForArguments(string functionName, params object[] args)
	{
		return null;
	}

	[Obsolete("Use Object.DontDestroyOnLoad instead")]
	public static void DontDestroyOnLoad(Object o)
	{
	}

	[Obsolete("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead (UnityUpgradable) -> [UnityEngine] UnityEngine.ScreenCapture.CaptureScreenshot(*)", true)]
	public static void CaptureScreenshot(string filename, int superSize)
	{
	}

	[Obsolete("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead (UnityUpgradable) -> [UnityEngine] UnityEngine.ScreenCapture.CaptureScreenshot(*)", true)]
	public static void CaptureScreenshot(string filename)
	{
	}

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit()
	{
		return false;
	}

	[RequiredByNativeCode]
	private static void Internal_ApplicationInit()
	{
	}

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit()
	{
	}

	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload()
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender()
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus)
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url)
	{
	}

	[Obsolete("Application.RegisterLogCallback is deprecated. Use Application.logMessageReceived instead.")]
	public static void RegisterLogCallback(LogCallback handler)
	{
	}

	[Obsolete("Application.RegisterLogCallbackThreaded is deprecated. Use Application.logMessageReceivedThreaded instead.")]
	public static void RegisterLogCallbackThreaded(LogCallback handler)
	{
	}

	private static void RegisterLogCallback(LogCallback handler, bool threaded)
	{
	}

	[Obsolete("Use SceneManager.LoadScene")]
	public static void LoadLevel(int index)
	{
	}

	[Obsolete("Use SceneManager.LoadScene")]
	public static void LoadLevel(string name)
	{
	}

	[Obsolete("Use SceneManager.LoadScene")]
	public static void LoadLevelAdditive(int index)
	{
	}

	[Obsolete("Use SceneManager.LoadScene")]
	public static void LoadLevelAdditive(string name)
	{
	}

	[Obsolete("Use SceneManager.LoadSceneAsync")]
	public static AsyncOperation LoadLevelAsync(int index)
	{
		return null;
	}

	[Obsolete("Use SceneManager.LoadSceneAsync")]
	public static AsyncOperation LoadLevelAsync(string levelName)
	{
		return null;
	}

	[Obsolete("Use SceneManager.LoadSceneAsync")]
	public static AsyncOperation LoadLevelAdditiveAsync(int index)
	{
		return null;
	}

	[Obsolete("Use SceneManager.LoadSceneAsync")]
	public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
	{
		return null;
	}

	[Obsolete("Use SceneManager.UnloadScene")]
	public static bool UnloadLevel(int index)
	{
		return false;
	}

	[Obsolete("Use SceneManager.UnloadScene")]
	public static bool UnloadLevel(string scenePath)
	{
		return false;
	}
}

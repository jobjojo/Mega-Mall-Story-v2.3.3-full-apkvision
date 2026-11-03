using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using java.lang;
using kairo.unity.form;
using kairo.unity.type;
using kairo.unity.util;

namespace kairo.unity.ui;

public abstract class IApplication : MonoBehaviour
{
	public delegate object UIMethod();

	public enum Permissions
	{
		WRITE_EXTERNAL_STORAGE = 0
	}

	public delegate bool OnRequestPermissionResult(bool permited);

	internal class RequestPermissionRecord
	{
		public string name_;

		public bool reboot_;

		public bool alwaysReboot_;

		public OnRequestPermissionResult method_;

		public RequestPermissionRecord(string name, bool reboot, OnRequestPermissionResult method, bool alwaysReboot = false)
		{
		}
	}

	private class MethodTask
	{
		public UIMethod method1;

		public ThreadStart method2;

		public Exception error;

		public bool finished;

		public object result;

		public MethodTask(UIMethod method)
		{
		}

		public MethodTask(ThreadStart method)
		{
		}
	}

	public delegate bool WaitMethod();

	public enum Seb
	{
		ButtonLanguage = 0,
		ConnectingBg = 1,
		ConnectingAnim = 2,
		Balloon = 3,
		ButtonCancel = 4
	}

	[CompilerGenerated]
	private sealed class _003CDoProcOnSrv_003Ed__205 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] keys;

		public string url;

		public IApplication _003C_003E4__this;

		private WWW _003Cwww_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDoProcOnSrv_003Ed__205(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckTimeOut_003Ed__208 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeout;

		public WWW www;

		private float _003CrequestTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCheckTimeOut_003Ed__208(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static IApplication instance_;

	protected static string platform_;

	protected bool termination_;

	protected bool visible_;

	private DisplayMetrics metrics_;

	private ScreenOrientation defaultOrientation_;

	private bool isFocus_;

	private bool isPause_;

	internal Handler handler_;

	private List<MethodTask> uiMethodTasks_;

	private List<MethodTask> updateMethodTasks_;

	private JThread uiThread_;

	private int totalFrames_;

	private static Assembly entryAssembly_;

	private const int COMMON_FRAME_MAX = 3;

	private static int commonFrames_;

	public static bool commonFramesUpdate_;

	private int viewportWidth_;

	private int viewportHeight_;

	private object lockUITask_;

	private string lastPermitPermissionName_;

	private string lastNotPermitPermissionName_;

	private bool isSizing_;

	private Image sizingCapture_;

	private IntPtr lastWParam;

	private IntPtr lastLParam;

	private bool handled;

	private int updateCount_;

	private bool showMaximize_;

	private long beginJoystickTime_;

	internal static bool screenLimit_;

	private static int wheelAppFrame_;

	private static bool wheelMove_;

	private static int wheelDelta_;

	private static Point mouseCursor_;

	internal TouchScreenKeyboard touchScreenKeyboard_;

	private bool doOpenTouchScreenKeyboard_;

	private static Exception bootError_;

	private long bootErrorBeginTime_;

	private List<RequestPermissionRecord> requestPermissionTable_;

	private string advertisingId_;

	private bool updateAdvertisingId_;

	[CompilerGenerated]
	private EventHandler m_Updated;

	private string dataPath_;

	private bool rendering_;

	private bool update_;

	private float fixedScaleRatio_;

	private long renderBeginTime_;

	private long renderTime_;

	private long updateTime_;

	private long lastUpdateDisplayMetrics_;

	private bool created_;

	private float resolutionScaleRatio_;

	private bool changeResolution_;

	private int changeResolutionWidth_;

	private int changeResolutionHeight_;

	private float changeResolutionScaleRatio_;

	private int resolutionChangedWait_;

	private float resolutionScaleMax_;

	private int delayQuitFrames_;

	private bool isWaiting_;

	private long measureCPUTime_;

	internal CommonControl commonControl_;

	private bool updatePortraitSize_;

	private Size portraitSize_;

	private int lastScreenHeight_;

	internal bool openBrowsing_;

	private string[] launchArguments_;

	internal static SplashScreen splash_;

	private static UnityEngine.Font initFont_;

	private int lastWindowShowCmd_;

	private bool deactivatedWindow_;

	private bool deactivatedMaximize_;

	private int deactivatedMaximizeProcess_;

	private Size deactivatedMaximizeSize_;

	private bool captureStart_;

	private bool inputInitialized_;

	private long lastSaveWindowTime_;

	private bool resumeLicenseCheck_;

	private JThread ExecuteAsyncConnectThread_;

	private static int isTabletResult_;

	private static int getSystemBarHeightResult_;

	private static int[] GetViewport_result;

	private static bool readyAd_;

	private string ret_;

	public const float TIMEOUT_SEC = 10f;

	private static int LABEL_H;

	private static int BUTTON_W;

	private static int BUTTON_MAX_W;

	private static int BUTTON_H;

	private static int BUTTON_S_H;

	private static int BUTTON_S_FONTSIZE;

	private static int INPUTFIELD_W;

	private static int INPUTFIELD_H;

	private static int OFFSET;

	private const int OFFSET_FRAME = 4;

	private const int BOX_W = 240;

	private static int BOX_H;

	private static int MESSAGE_BOX_H;

	private GUIStyle m_inputStyle;

	private GUIStyle m_buttonStyle;

	private GUIStyle m_boxStyle;

	private GUIStyle m_labelStyle;

	private GUIStyle m_messageStyle;

	private GUIStyleState m_boxState_;

	internal const int GUI_MODE_NONE = 0;

	internal const int GUI_MODE_INPUT = 1;

	internal const int GUI_MODE_DIALOG = 2;

	internal int guiMode_;

	private int guiIndex_;

	private int guiSelect_;

	private float inputScale_;

	private int guiResult_;

	private string[] guiResultTexts_;

	private string inputTitle_;

	private string inputText_;

	private string inputPositive_;

	private string inputNegative_;

	private string[] inputButtonsText_;

	private int[] inputButtonsResult_;

	private bool guiResetFocus_;

	private bool guiResetFontSize_;

	private int guiFontSizeButton_;

	private int guiFontSizeLabel_;

	private static int IsPaintModeEnable_result;

	internal bool TouchOffset { get; private set; }

	internal bool IsIllegalHiddenStatusBar { get; set; }

	public static int TotalFrames => 0;

	internal static bool ImeComposition { get; private set; }

	internal static bool TerminateCheckEnable { get; set; }

	internal event EventHandler Updated
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

	protected void Init(IApplication app)
	{
	}

	public static IApplication GetCurrentApp()
	{
		return null;
	}

	public string GetSourceURL()
	{
		return null;
	}

	protected virtual void OnAwake()
	{
	}

	private void Awake()
	{
	}

	private static void CopyDirectory(string src, string dst)
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnGUI()
	{
	}

	public void AddUpdatedEvent(EventHandler eventHandler)
	{
	}

	public void RemoveUpdatedEvent(EventHandler eventHandler)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void StartAsyncConnectThread()
	{
	}

	private void ExecuteAsyncConnectMethod()
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private bool TerminateCheck(bool force = false)
	{
		return false;
	}

	protected virtual void OnCreate()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected virtual void OnRestart()
	{
	}

	protected virtual void OnStop()
	{
	}

	protected virtual void OnResume()
	{
	}

	protected virtual void OnSuspend()
	{
	}

	protected abstract void OnUpdate();

	protected abstract void OnDraw();

	protected virtual void OnRender()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	[Obsolete("IApplication.Gameover() を使用して下さい。")]
	public void Terminate()
	{
	}

	public void Gameover()
	{
	}

	public static string GetProperty(string key)
	{
		return null;
	}

	public float GetScaleRatio(bool forceAuto = false)
	{
		return 0f;
	}

	public void SetScaleRatio(float scaleRatio = float.NaN)
	{
	}

	public int GetBattery()
	{
		return 0;
	}

	public bool IsBatteryCharging()
	{
		return false;
	}

	public bool IsTermination()
	{
		return false;
	}

	public bool Visibe()
	{
		return false;
	}

	public bool IsSide()
	{
		return false;
	}

	public int GetWidth()
	{
		return 0;
	}

	public int GetHeight()
	{
		return 0;
	}

	public int GetWidth2()
	{
		return 0;
	}

	public int GetHeight2()
	{
		return 0;
	}

	public int GetOrientation()
	{
		return 0;
	}

	public void SetOrientation(int orientation)
	{
	}

	public bool IsAutoOrientation()
	{
		return false;
	}

	public void ResetOrientation()
	{
	}

	public static void Sleep(int ms)
	{
	}

	public bool Wait(WaitMethod wait, long interval = 1L, long timeout = 0L)
	{
		return false;
	}

	internal bool IsWaiting()
	{
		return false;
	}

	public bool Focus()
	{
		return false;
	}

	public bool HasWindowFocus()
	{
		return false;
	}

	public virtual FormManagerBase GetFormManager()
	{
		return null;
	}

	public bool GetRotateCheck()
	{
		return false;
	}

	public void SetRotateCheck(bool flag)
	{
	}

	public bool IsTablet()
	{
		return false;
	}

	public int GetSystemBarHeight()
	{
		return 0;
	}

	public string GetPackageName()
	{
		return null;
	}

	public Handler GetHandler()
	{
		return null;
	}

	public bool RunOnUpdate(ThreadStart start)
	{
		return false;
	}

	public void RunOnUiThread(ThreadStart start, bool wait = false)
	{
	}

	public object RunOnUiThread(UIMethod start, bool wait = false)
	{
		return null;
	}

	public bool CheckUiThread()
	{
		return false;
	}

	private int ExecuteUIMethods()
	{
		return 0;
	}

	private int ExecuteUpdateMethods()
	{
		return 0;
	}

	private void Error(Exception e)
	{
	}

	private void BootError(Exception e)
	{
	}

	public int GetTotalFrames()
	{
		return 0;
	}

	public string GetDataPath()
	{
		return null;
	}

	public bool IsRendering()
	{
		return false;
	}

	public void SetViewport(int width, int height)
	{
	}

	public int[] GetViewport()
	{
		return null;
	}

	public long GetRenderTime()
	{
		return 0L;
	}

	public long GetUpdateTime()
	{
		return 0L;
	}

	public void SetResolutionScaleRatio(float scaleRatio)
	{
	}

	public float GetResolutionScaleRatio()
	{
		return 0f;
	}

	private void UpdateResolution()
	{
	}

	public float GetHalfResolutionScaleRatio()
	{
		return 0f;
	}

	protected void OnPermit(string permissionName)
	{
	}

	protected void OnNotPermit(string permissionName)
	{
	}

	public void RequestPermission(Permissions permission, string message, bool reboot = true, OnRequestPermissionResult method = null)
	{
	}

	public void RequestPermission(string permissionName, string message, bool reboot = true, OnRequestPermissionResult method = null)
	{
	}

	private static string GetPermissionName(Permissions p)
	{
		return null;
	}

	private static void ShowPermissionError(string permissionName, string message = null)
	{
	}

	public string GetLastPermitPermissionName()
	{
		return null;
	}

	public string GetLastNotPermitPermissionName()
	{
		return null;
	}

	public ResourceManager GetResource()
	{
		return null;
	}

	public static void SetReadyAd(bool ready)
	{
	}

	public static bool GetReadyAd()
	{
		return false;
	}

	internal void Deactivate()
	{
	}

	public static Assembly GetEntryAssembly()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDoProcOnSrv_003Ed__205))]
	public IEnumerator DoProcOnSrv(string url, string[] keys)
	{
		return null;
	}

	public static string GetRetOfSrvProc()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckTimeOut_003Ed__208))]
	private IEnumerator CheckTimeOut(WWW www, float timeout)
	{
		return null;
	}

	private byte[] LoadBytes(string path)
	{
		return null;
	}

	protected virtual void InitGUI(float scale)
	{
	}

	public void StartGUI_Input(string title, string text, int mode, string positive, string negative)
	{
	}

	public void StartGUI_Dialog(int type, string title, string msg, string cmds)
	{
	}

	private void EndGUI_DialogButton(int result)
	{
	}

	internal void EndGUI_InputOK()
	{
	}

	internal void EndGUI_InputCancel()
	{
	}

	public bool IsEndGUI()
	{
		return false;
	}

	public string GetGUI_InputText()
	{
		return null;
	}

	public int GetGUI_Result()
	{
		return 0;
	}

	private string[] GetGUI_ResultTexts()
	{
		return null;
	}

	private bool UpdateGUI()
	{
		return false;
	}

	internal void CancelGUI_Dialog()
	{
	}

	private bool UpdateGUI_Dialog()
	{
		return false;
	}

	private bool UpdateGUI_InputField()
	{
		return false;
	}

	private void DrawGUI()
	{
	}

	private void DrawGUI_Dialog(float scale)
	{
	}

	private void DrawGUI_InputField(float scale)
	{
	}

	public string GetAdvertisingId()
	{
		return null;
	}

	public string[] GetLaunchArguments()
	{
		return null;
	}

	public void SetCommonControl(CommonControl c)
	{
	}

	public CommonControl GetCommonControl()
	{
		return null;
	}

	internal static bool IsPaintModeEnable()
	{
		return false;
	}

	internal static bool IsMetaKeyEnable()
	{
		return false;
	}

	internal static bool IsTimeSkipEnable()
	{
		return false;
	}

	internal static void GooglePlayLicenseCheck()
	{
	}

	public static void SetScreenLimit(bool enable)
	{
	}

	internal Point GetMouseCursor()
	{
		return default;
	}

	internal void SetMouseCursor(Point p)
	{
	}
}

using System;
using System.Collections.Generic;
using java.lang;
using java.util;
using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class FormManagerBase
{
	public delegate void AsyncMethod(Graphics g, long deltaTime);

	public delegate void OnCaptureCompleted(string[] files);

	public enum CallMethodType
	{
		Init = 0,
		Update = 1,
		Draw = 2,
		Resume = 3,
		Suspend = 4,
		Finish = 5
	}

	private static FormManagerBase instance_;

	public const int MODE_INIT = 0;

	public const int MODE_PREUPDATE = 1;

	public const int MODE_UPDATE = 2;

	public const int MODE_DRAW = 3;

	public const int MODE_FINISH = 4;

	protected Vector formStack_;

	protected bool resume_;

	protected bool drawall_;

	protected bool drawskip_;

	protected bool softlabel_;

	protected FormBase printForm_;

	protected FormBase currentForm_;

	protected bool showTerminationDialog_;

	protected bool termination_;

	protected bool pause_;

	protected bool pauseToast_;

	protected bool frameAdvance_;

	protected bool surfaceChanged_;

	protected bool surfaceInitialized_;

	protected long lastGcTime_;

	protected long execGcTime_;

	protected bool requestSynchronize_;

	protected bool synchronizing_;

	protected JThread thread_;

	protected bool serviceUpdate_;

	protected bool lastKeyguard_;

	protected bool lastVisibleActivity_;

	protected bool notifiedExitEvent_;

	protected bool capturing_;

	protected int captureCount_;

	protected bool warning_;

	protected bool waitLateUpdate_;

	protected bool lockUpdate_;

	protected long lockUpdateTime_;

	protected int lockUpdateCount_;

	protected object lockUpdateLock_;

	protected long updateStartTime_;

	protected long endUpdateTime_;

	protected FormBase endUpdateForm_;

	protected int frameRateBuf_;

	private long oldTime_;

	private long fpsTime_;

	private int tagFps_;

	private int fps_;

	private int frameCount_;

	private long profilerTime_;

	private int vibeTime_;

	private int vibeFlag_;

	private bool frameSkipped_;

	private bool asyncChange_;

	private JThread asyncThread_;

	private Exception asyncException_;

	private long asyncBeginTime_;

	private AsyncMethod asyncMethod_;

	protected static bool initFontTexture_;

	private int wait_;

	private FormBase waitForm_;

	private bool slow_;

	private int slowCount_;

	protected bool manualFpsControl_;

	protected List<KeyValuePair<FormBase, bool>> formIsGame_;

	private Font fontBuf_;

	public FormBase this[int index] => null;

	public int Count => 0;

	public FormBase Top => null;

	public FormBase Front => null;

	public FormBase Down => null;

	public FormBase Back => null;

	public FormBase Current => null;

	public static FormManagerBase GetInstance()
	{
		return null;
	}

	public FormBase GetForm(int index)
	{
		return null;
	}

	public int GetFormIndex(FormBase form)
	{
		return 0;
	}

	protected FormManagerBase()
	{
	}

	public bool ChangeCurrentForm(FormBase form, bool async = false)
	{
		return false;
	}

	public bool Push(FormBase form)
	{
		return false;
	}

	public bool Push(FormBase position, FormBase form)
	{
		return false;
	}

	public bool Push(FormBase position, FormBase form, bool before)
	{
		return false;
	}

	public bool Pop()
	{
		return false;
	}

	public bool Pop(FormBase form)
	{
		return false;
	}

	private bool CheckInitOrFinish()
	{
		return false;
	}

	private void ExecuteInitAndFinish()
	{
	}

	private void _executeInitAndFinish()
	{
	}

	public bool Execute()
	{
		return false;
	}

	private bool _execute()
	{
		return false;
	}

	public void ProcWait()
	{
	}

	public virtual void OnDraw()
	{
	}

	protected virtual bool DoTerminationDialog()
	{
		return false;
	}

	public virtual void Resume()
	{
	}

	public void DrawAllForms()
	{
	}

	public void DrawAllForms(bool flush)
	{
	}

	public void DrawSkip()
	{
	}

	public bool IsDrawSkip()
	{
		return false;
	}

	protected virtual void PreUpdate()
	{
	}

	private void OnUpdated()
	{
	}

	protected virtual void Updated()
	{
	}

	protected virtual void PreDraw()
	{
	}

	protected virtual void Drawn()
	{
	}

	public int GetFormsNum()
	{
		return 0;
	}

	public FormBase GetTopForm()
	{
		return null;
	}

	public FormBase GetDownForm()
	{
		return null;
	}

	public bool RemoveAllForms()
	{
		return false;
	}

	public FormBase GetCurrentForm()
	{
		return null;
	}

	public void MoveToTop(FormBase form)
	{
	}

	public void MoveToDown(FormBase form)
	{
	}

	public void SetPrintForm(FormBase form)
	{
	}

	private void DrawPrintForm(Graphics g)
	{
	}

	public bool CheckUsable(FormBase form)
	{
		return false;
	}

	public void Draw(Graphics g)
	{
	}

	public void DrawLoading(Graphics g, int screenAlpha = 255, int screenColor = -16777216, string text = "Loading")
	{
	}

	public void ShowTerminationDialog()
	{
	}

	public bool CheckShowTerminationDialog()
	{
		return false;
	}

	public void SetPause(bool b)
	{
	}

	public bool IsPause()
	{
		return false;
	}

	public void FrameAdvance()
	{
	}

	public void SetSlow(bool b)
	{
	}

	public bool IsSlow()
	{
		return false;
	}

	public void SurfaceChanged()
	{
	}

	private void BeginSynchronize()
	{
	}

	private void EndSynchronize()
	{
	}

	internal void ProcessEvent(AppEvent evt)
	{
	}

	protected virtual void OnProcessEvent(AppEvent evt)
	{
	}

	internal void ProcessBackKey()
	{
	}

	internal void ProcessBackKey(bool terminate)
	{
	}

	internal static void ProcessEvent(AppEventType type, params object[] args)
	{
	}

	public void Capture(SurfaceBase view, string[] captureTables = null, OnCaptureCompleted method = null, bool saveToTmpDirectory = false, bool fullscreen = true)
	{
	}

	private void Capture2(SurfaceBase view, string[] captureTables = null, OnCaptureCompleted method = null, bool saveToTmpDirectory = false, bool fullscreen = true)
	{
	}

	public bool IsCapturing()
	{
		return false;
	}

	internal bool WaitLateUpdate()
	{
		return false;
	}

	internal void LockUpdate()
	{
	}

	internal long UnlockUpdate()
	{
		return 0L;
	}

	internal long GetUpdateStartTime()
	{
		return 0L;
	}

	public int GetFps()
	{
		return 0;
	}

	public void StartVibrator(int ms)
	{
	}

	public void StopVibrator()
	{
	}

	public void SetTargetFps(int fps)
	{
	}

	public int GetTargetFps()
	{
		return 0;
	}

	internal void Deactivate()
	{
	}

	public bool IsFrameSkipped()
	{
		return false;
	}

	private void StopAsyncThread()
	{
	}

	public bool IsFormChanging()
	{
		return false;
	}

	public void SetAsyncMethod(AsyncMethod method)
	{
	}

	public virtual bool DoMethod(FormBase form, CallMethodType method, Graphics g = null)
	{
		return false;
	}

	public virtual void SetWait(int frame)
	{
	}

	public bool IsWait()
	{
		return false;
	}

	public FormBase GetWaitForm()
	{
		return null;
	}

	protected virtual void OnWaitFinished()
	{
	}

	public void RemoveAllDialogs()
	{
	}

	private void DoTouchEvents()
	{
	}
}

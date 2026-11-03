using System.Collections.Generic;
using UnityEngine;
using java.util;
using kairo.unity.ad;
using kairo.unity.form;
using kairo.unity.surface;
using kairo.unity.util;

namespace kairo.unity.ui;

public class Canvas
{
	public enum InputDevices
	{
		Unknown = 0,
		Touch = 1,
		Keyboard = 2,
		Mouse = 3,
		Joystick = 4
	}

	private class EditorPad
	{
		public string Up;

		public string Right;

		public string Down;

		public string Left;

		public string A;

		public string B;

		public string L;

		public string R;

		public string Num0;

		public string Num1;

		public string Num2;

		public string Num3;

		public string Num4;

		public string Num5;

		public string Num6;

		public string Num7;

		public string Num8;

		public string Num9;

		public string Mode;

		public bool GetKeyDown(string name)
		{
			return false;
		}

		public bool GetKeyUp(string name)
		{
			return false;
		}

		public bool GetKey(string name)
		{
			return false;
		}
	}

	private const int KEYID_0 = 0;

	private const int KEYID_1 = 1;

	private const int KEYID_2 = 2;

	private const int KEYID_3 = 3;

	private const int KEYID_4 = 4;

	private const int KEYID_5 = 5;

	private const int KEYID_6 = 6;

	private const int KEYID_7 = 7;

	private const int KEYID_8 = 8;

	private const int KEYID_9 = 9;

	private const int KEYID_ASTERISK = 10;

	private const int KEYID_POUND = 11;

	private const int KEYID_GAMEPAD1 = 12;

	private const int KEYID_GAMEPAD2 = 13;

	public const int KEYID_LEFT = 16;

	public const int KEYID_UP = 17;

	public const int KEYID_RIGHT = 18;

	public const int KEYID_DOWN = 19;

	private const int KEYID_SELECT = 20;

	private const int KEYID_SOFT1 = 21;

	private const int KEYID_SOFT2 = 22;

	private const int KEYID_SOFT3 = 23;

	private const int KEYID_SOFT4 = 24;

	private const int KEYID_USER1 = 25;

	private const int KEYID_USER2 = 26;

	private const int KEYID_USER3 = 27;

	private const int KEYID_USER4 = 28;

	private const int KEYID_USER5 = 29;

	private const int KEYID_USER6 = 30;

	private const int KEYID_B_BACK = 31;

	private static KeyCode[][] VALID_KEYS;

	private static bool[] onValidKeys_;

	public const int KEY_LEFT = 65536;

	public const int KEY_RIGHT = 262144;

	public const int KEY_UP = 131072;

	public const int KEY_DOWN = 524288;

	public const int KEY_SELECT = 1048576;

	public const int KEY_0 = 1;

	public const int KEY_1 = 2;

	public const int KEY_2 = 4;

	public const int KEY_3 = 8;

	public const int KEY_4 = 16;

	public const int KEY_5 = 32;

	public const int KEY_6 = 64;

	public const int KEY_7 = 128;

	public const int KEY_8 = 256;

	public const int KEY_9 = 512;

	public const int KEY_POUND = 2048;

	public const int KEY_ASTERISK = 1024;

	public const int KEY_SOFT1 = 2097152;

	public const int KEY_SOFT2 = 4194304;

	public const int KEY_SOFT3 = 8388608;

	public const int KEY_SOFT4 = 16777216;

	public const int KEY_USER1 = 33554432;

	public const int KEY_USER2 = 67108864;

	public const int KEY_USER3 = 134217728;

	public const int KEY_USER4 = 268435456;

	public const int KEY_USER5 = 536870912;

	public const int KEY_USER6 = 1073741824;

	public const int KEY_B_BACK = int.MinValue;

	public const int KEY_BACK = 32769;

	internal const int KEY_GAMEPAD1 = 4096;

	internal const int KEY_GAMEPAD2 = 8192;

	internal const int KEY_GAMEPAD = 12288;

	public const int KEY_A = 4097;

	public const int KEY_B = 4098;

	public const int KEY_X = 4100;

	public const int KEY_Y = 4104;

	public const int KEY_L = 4112;

	public const int KEY_R = 4128;

	public const int KEY_ZL = 4160;

	public const int KEY_ZR = 4224;

	public const int KEY_PLUS = 4352;

	public const int KEY_MINUS = 4608;

	public const int KEY_LSTICK_LEFT = 8193;

	public const int KEY_LSTICK_RIGHT = 8194;

	public const int KEY_LSTICK_UP = 8196;

	public const int KEY_LSTICK_DOWN = 8200;

	public const int KEY_RSTICK_LEFT = 8208;

	public const int KEY_RSTICK_RIGHT = 8224;

	public const int KEY_RSTICK_UP = 8256;

	public const int KEY_RSTICK_DOWN = 8320;

	internal static int[][] KEY_TO_JOYSTICK;

	public const int OP_REPL = 0;

	public const int OP_ADD = 1;

	public const int OP_SUB = 2;

	public const int SOFT_KEY_1 = 0;

	public const int SOFT_KEY_2 = 1;

	public const int SOFT_KEY_3 = 2;

	public const int SOFT_KEY_4 = 3;

	public const int TIMER_EXPIRED_EVENT = 0;

	public const int RESUME_VM_EVENT = 1;

	public const int KEY_RELEASED_EVENT = 2;

	public const int KEY_PRESSED_EVENT = 3;

	protected static Canvas instance_;

	protected Graphics graphics_;

	protected int background_;

	internal Font defaultFont_;

	protected SurfaceManagerBase surfaceManager_;

	protected int statusBar_;

	protected int statusBarPosition_;

	protected AdMobView admobView_;

	protected int disableKeyBits_;

	protected int pressKeyboardCount_;

	protected bool cpatureStart_;

	internal KeyCode assignedKeyCodeZL_;

	internal KeyCode assignedKeyCodeZR_;

	private FormBase pressedYButtonForm_;

	private FormBase pressedXButtonForm_;

	private bool keyStateSelectToAButton_;

	private bool hasKeyboard_;

	private bool hasJoystick_;

	protected Dictionary<int, float[]> onTouchPointer_;

	protected bool onTouchPinch_;

	protected bool invalidTouch_;

	private bool beginPhysicalInput_;

	protected int onMouseButton_;

	protected Vector3 onMousePosition_;

	protected Vector3 onMouseBeginPosition_;

	protected bool onMouseRight_;

	protected long onMouseRightTime1_;

	protected long onMouseRightTime2_;

	protected bool onMouseRightTimeSkip_;

	protected int onMouseRightTimeSkipCount_;

	protected FormBase onMouseRightTimeSkipForm_;

	protected bool onMouseRightComponent_;

	internal long timeSkipBeginTime_;

	internal bool onMousePinch_;

	protected float[] onMousePinchPointer_;

	private long onMousePinchTime_;

	private bool joystickKeyReverse_;

	private float joystickPointerAsobi_;

	protected float[] joystickPointer_;

	private int checkUpDownKeyCount_;

	private bool verticalWheelScrollLock_;

	private FormBase verticalWheelScrollDialog_;

	private bool isReplayInput_;

	private bool inputSystemEnable_;

	internal bool connectedXInput_;

	internal InputDevices lastInputDevice_;

	internal InputDevices lastInputDeviceWork_;

	private EditorPad editorPad_;

	internal long inputGuardTime_;

	internal bool inputGuardAnyKey_;

	internal bool inputGuardJoystick_;

	internal int inputGuardJoystickAppFrame_;

	internal List<FormBase> inputGuardForms_;

	internal bool joystickSkip_;

	public const int JOYSTICK_BUTTON_OFF = 0;

	public const int JOYSTICK_BUTTON_SWITCH = 1;

	public const int JOYSTICK_BUTTON_PS4 = 2;

	public const int JOYSTICK_BUTTON_XBOX = 3;

	public const int JOYSTICK_BUTTON_MAX = 4;

	private int joystickButtonType_;

	private Vector<int[]> joystickButtonDraw_;

	private int[] rightClickButtonCount_;

	protected string[] softLabel_;

	protected string[] showSoftLabel_;

	protected Keypad keypad_;

	protected Keypad currentKeypad_;

	protected int defaultKeyRepeatInterval_;

	protected int defaultKeyDoubleInterval_;

	private const int CONTROLLER_TYPE_JOYSTICK = 0;

	private const int CONTROLLER_TYPE_REMOTECONTROLLER = 1;

	private const int CONTROLLER_TYPE_SCREENCURSOR = 2;

	private const int CONTROLLER_TYPE_MAX = 3;

	private static readonly string[] CONTROLLER_TYPE_NAMES;

	private static readonly int[] CONTROLLER_TABLE;

	private int controllerIndex_;

	private const int TOUCHEFFECT_WORK_X = 0;

	private const int TOUCHEFFECT_WORK_Y = 1;

	private const int TOUCHEFFECT_WORK_FRAME = 2;

	private const int TOUCHEFFECT_WORK_MAX = 3;

	private Vector<int[]> touchEffects_;

	private float[] screenPointer_;

	private float[] screenCursor_;

	private float[] screenCursorPrev_;

	private readonly int[] screenCursorSpeedC_;

	private const int SCREENCURSOR_SPEED = 16;

	private const int SCREENCURSOR_HIDE_COUNT = 100;

	private const int SCREENCURSOR_RESUME_MAX = 12;

	private int screenCurosorClick_;

	private int screenCursorFrame_;

	private int screenCursorStopFrame_;

	private int screenCursorResumptionFrame_;

	private int screenCursorDrawFrame_;

	private const int SIDE_LIMIT = 8;

	public const int JOYSTICK_INDEX_A = 0;

	public const int JOYSTICK_INDEX_B = 1;

	public const int JOYSTICK_INDEX_X = 2;

	public const int JOYSTICK_INDEX_Y = 3;

	public const int JOYSTICK_INDEX_StickL = 4;

	public const int JOYSTICK_INDEX_StickR = 5;

	public const int JOYSTICK_INDEX_L = 6;

	public const int JOYSTICK_INDEX_R = 7;

	public const int JOYSTICK_INDEX_ZL = 8;

	public const int JOYSTICK_INDEX_ZR = 9;

	public const int JOYSTICK_INDEX_Plus = 10;

	public const int JOYSTICK_INDEX_Minus = 11;

	public const int JOYSTICK_INDEX_Left = 12;

	public const int JOYSTICK_INDEX_Up = 13;

	public const int JOYSTICK_INDEX_Right = 14;

	public const int JOYSTICK_INDEX_Down = 15;

	public const int JOYSTICK_INDEX_StickLLeft = 16;

	public const int JOYSTICK_INDEX_StickLUp = 17;

	public const int JOYSTICK_INDEX_StickLRight = 18;

	public const int JOYSTICK_INDEX_StickLDown = 19;

	public const int JOYSTICK_INDEX_StickRLeft = 20;

	public const int JOYSTICK_INDEX_StickRUp = 21;

	public const int JOYSTICK_INDEX_StickRRight = 22;

	public const int JOYSTICK_INDEX_StickRDown = 23;

	private const int JOYSTICK_INDEX_MAX = 24;

	private const int JOYSTICK_INDEX_LeftSL = 24;

	private const int JOYSTICK_INDEX_LeftSR = 25;

	private const int JOYSTICK_INDEX_RightSL = 26;

	private const int JOYSTICK_INDEX_RightSR = 27;

	public const int JOYSTICK_INDEX_Dpad = 28;

	public const int JOYSTICK_INDEX_Lanalog = 29;

	public const int JOYSTICK_INDEX_Ranalog = 30;

	public const int JOYSTICK_INDEX_Home = 31;

	public const int JOYSTICK_INDEX_DpadN = 32;

	public const int JOYSTICK_INDEX_DpadALL = 33;

	public const int JOYSTICK_INDEX_DpadUD = 34;

	public const int JOYSTICK_INDEX_DpadLR = 35;

	public const int JOYSTICK_INDEX_LanalogN = 36;

	public const int JOYSTICK_INDEX_LanalogALL = 37;

	public const int JOYSTICK_INDEX_LanalogUD = 38;

	public const int JOYSTICK_INDEX_LanalogLR = 39;

	public const int JOYSTICK_INDEX_RanalogN = 40;

	public const int JOYSTICK_INDEX_RanalogALL = 41;

	public const int JOYSTICK_INDEX_RanalogUD = 42;

	public const int JOYSTICK_INDEX_RanalogLR = 43;

	private const int JOYSTICK_BUTTONDRAW_BUTTON = 0;

	private const int JOYSTICK_BUTTONDRAW_REGISTER = 1;

	private const int JOYSTICK_BUTTONDRAW_DISP = 2;

	private const int JOYSTICK_BUTTONDRAW_X = 3;

	private const int JOYSTICK_BUTTONDRAW_Y = 4;

	private const int JOYSTICK_BUTTONDRAW_LIFE = 5;

	private const int JOYSTICK_BUTTONDRAW_SCALE = 6;

	private const int JOYSTICK_BUTTONDRAW_MAX = 7;

	private const int JOYSTICK_BUTTON_DRAWLIFE_MAX = 4;

	private static readonly string[][] JOYSTICK_INPUTSYSTEM_CODE;

	private static readonly bool BOOT_FIRST_DEBUG;

	private bool steamOffsetEnable_;

	private const float JOYSTICK_AXIS_ASOBI = 0.5f;

	private static readonly KeyCode[] JOYSTICK_CODE;

	private int[] joystickPress;

	private bool[] joystickDown;

	private bool[] joystickUp;

	private const string MOUSE_SCROLLWHEEL = "Mouse ScrollWheel";

	protected bool fullscreen_;

	protected bool fullscreenChanging_;

	protected int linearFilterQuality_;

	private static DisplayMetrics displayMetrics_;

	private List<string> backSoftLabels_;

	private List<string> menuSoftLabels_;

	private float aspectRatio_;

	internal static int lastOpenBrowserFrame_;

	internal bool isAlterStaticRendering_;

	internal bool touchCancel_;

	private static Graphics graphicsBuffer_;

	private static List<Keypad> DecideKeyState_keypads;

	private bool updateAdMobViewRun_;

	public bool InvalidJoystick { get; set; }

	public Keypad CurrentKeypad
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void ChangeControllerType()
	{
	}

	public bool IsJoystick()
	{
		return false;
	}

	private bool IsRemocon()
	{
		return false;
	}

	public bool IsScreenCursor()
	{
		return false;
	}

	private bool IsPointingMode()
	{
		return false;
	}

	private void InitScreenCursor()
	{
	}

	private void SetScreenPointer(float pointerX, float pointerY)
	{
	}

	private void SetScreenCursor(float cursorX, float cursorY)
	{
	}

	public void JumpScreenCursor(float cursorX, float cursorY)
	{
	}

	public float[] GetScreenCursor()
	{
		return null;
	}

	private KeyCode GetJoystick2Keycode(int index)
	{
		return KeyCode.None;
	}

	private void InitJoystick()
	{
	}

	public void SetJoystickButtonDraw(int button, int x, int y, int registerID = -1, int scale = 100)
	{
	}

	public void ResetJoystickButtonDraw()
	{
	}

	public void RaiseJoystickButtonDraw()
	{
	}

	private void ChangeJoystickButtonType()
	{
	}

	public int GetJoystickButtonType()
	{
		return 0;
	}

	public void SetSteamOffsetEnable(bool enable)
	{
	}

	public bool IsSteamOffsetEnable()
	{
		return false;
	}

	internal bool GetJoystickButton(int index, bool ignoreKeyCode = false)
	{
		return false;
	}

	internal float GetJoystickAxis(int index)
	{
		return 0f;
	}

	private void resetJoystickState()
	{
	}

	private void updateJoystickStateBegin()
	{
	}

	private void updateJoystickStateEnded()
	{
	}

	public bool GetJoystickPress(int index)
	{
		return false;
	}

	public int GetJoystickPressCount(int index)
	{
		return 0;
	}

	public bool GetJoystickDown(int index)
	{
		return false;
	}

	public bool GetJoystickUp(int index)
	{
		return false;
	}

	public float GetJoystickAnalog(int index, bool asobi = true)
	{
		return 0f;
	}

	public bool GetJoystickHoldDown(int index, int frame)
	{
		return false;
	}

	public bool GetJoystickAnalogPress(int index, bool asobi = true)
	{
		return false;
	}

	private Canvas()
	{
	}

	private void Init()
	{
	}

	public static Canvas GetInstance()
	{
		return null;
	}

	public static Canvas GetInstance(bool make)
	{
		return null;
	}

	public void SetDisplayCurrent(IApplication app)
	{
	}

	public Graphics GetGraphicsInstance()
	{
		return null;
	}

	public Graphics BeginPaint()
	{
		return null;
	}

	internal Graphics BeginPaint(Graphics g, int meshId = -1)
	{
		return null;
	}

	internal Graphics BeginAlterStaticRender(Graphics g, int meshId = -1)
	{
		return null;
	}

	public void LockAndUnlock()
	{
	}

	public void EndPaint()
	{
	}

	internal void EndPaint(Graphics g, int meshId = -1)
	{
	}

	internal void EndAlterStaticRender(Graphics g, int meshId = -1)
	{
	}

	public void Paint(object arg0)
	{
	}

	public void SetSoftLabel(string sk1, string sk2, string sk3 = null, string sk4 = null)
	{
	}

	public void SetSoftLabel(int type, string label)
	{
	}

	public string GetSoftLabelL()
	{
		return null;
	}

	public string GetSoftLabelR()
	{
		return null;
	}

	public string GetSoftLabel(int id)
	{
		return null;
	}

	public void UpdateSoftLabel()
	{
	}

	public void SetKeyRepeatInterval(int frame)
	{
	}

	public int GetKeyRepeatInterval()
	{
		return 0;
	}

	public void SetKeyDoubleInterval(int frame)
	{
	}

	public int GetKeyDoubleInterval()
	{
		return 0;
	}

	internal void Update()
	{
	}

	public void OnInputUpdate()
	{
	}

	public void DecideKeyState()
	{
	}

	private void _decideKeyState()
	{
	}

	public int GetKeyState()
	{
		return 0;
	}

	public bool CheckKeyState(Keys key)
	{
		return false;
	}

	public bool CheckKeyState(int key)
	{
		return false;
	}

	public bool CheckKeyPulse(Keys key)
	{
		return false;
	}

	public bool CheckKeyPulse(int key)
	{
		return false;
	}

	public bool CheckPhysicalKey()
	{
		return false;
	}

	public bool GetKeyPulse(Keys key)
	{
		return false;
	}

	public bool GetKeyPulse(int key)
	{
		return false;
	}

	public bool CheckKeyRepeat(Keys key)
	{
		return false;
	}

	public bool CheckKeyRepeat(int key)
	{
		return false;
	}

	public bool CheckKeyRepeat(Keys key, int interval)
	{
		return false;
	}

	public bool CheckKeyRepeat(int key, int interval)
	{
		return false;
	}

	public bool CheckKeyDouble(Keys key)
	{
		return false;
	}

	public bool CheckKeyDouble(int key)
	{
		return false;
	}

	public bool CheckKeyDouble(Keys key, int interval)
	{
		return false;
	}

	public bool CheckKeyDouble(int key, int interval)
	{
		return false;
	}

	public int GetKeypadState()
	{
		return 0;
	}

	public void ClearKeyBuffer()
	{
	}

	public bool OnKeyDown(KeyCode keyCode, KeyEvent evt, List<Keypad> keypads = null)
	{
		return false;
	}

	public bool OnKeyUp(KeyCode keyCode, KeyEvent evt, List<Keypad> keypads = null)
	{
		return false;
	}

	public void KeyDown(Keys key, bool pulse = true)
	{
	}

	public void KeyDown(int key, bool pulse = true)
	{
	}

	public void KeyUp(Keys key)
	{
	}

	public void KeyUp(int key)
	{
	}

	public void KeyClick(Keys key)
	{
	}

	public void KeyClick(int key)
	{
	}

	public void KeyClickImmediate(Keys key)
	{
	}

	public void KeyClickImmediate(int key)
	{
	}

	protected int GetKeyID(KeyCode keyCode)
	{
		return 0;
	}

	public static void Vibrator(bool flag)
	{
	}

	public static void Vibrator(long ms)
	{
	}

	public static void Vibrator(long[] pattern)
	{
	}

	public static void BackLight(bool on)
	{
	}

	public static bool OpenBrowser(string url)
	{
		return false;
	}

	public static bool JumpReview()
	{
		return false;
	}

	public static bool JumpStore(long ID)
	{
		return false;
	}

	public static bool JumpStore(string ID)
	{
		return false;
	}

	public static bool JumpStoreKairosoft()
	{
		return false;
	}

	public static void VersionUp(string url)
	{
	}

	public string ImeOnBlock(string text, int displayMode, int inputMode)
	{
		return null;
	}

	public void SetBackground(int c)
	{
	}

	public void SetBackColor(int c)
	{
	}

	public int GetBackColor()
	{
		return 0;
	}

	public int GetSyncMillSecound(int framerate)
	{
		return 0;
	}

	public void Fullscreen(bool enable)
	{
	}

	public bool IsFullscreen()
	{
		return false;
	}

	public void SetSurfaceManager(SurfaceManagerBase surfaceManager)
	{
	}

	public SurfaceManagerBase GetSurfaceManager()
	{
		return null;
	}

	public void RemoveView()
	{
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

	public int GetStatusBarHeight()
	{
		return 0;
	}

	public bool IsGetStatusBarHeight()
	{
		return false;
	}

	public bool OnTouchEvent(MotionEvent evt)
	{
		return false;
	}

	public bool OnTrackballEvent(MotionEvent evt)
	{
		return false;
	}

	public void SetLinearFilterEnable(bool enable)
	{
	}

	public bool IsLinearFilterEnable()
	{
		return false;
	}

	public int GetStatusBarPosition()
	{
		return 0;
	}

	public bool IsGetStatusBarPosition()
	{
		return false;
	}

	public bool UpdateAdMobView()
	{
		return false;
	}

	public AdMobView GetAdMobView()
	{
		return null;
	}

	internal void RemoveAdMobView()
	{
	}

	public void SetDisableKeyBits(int keyBits)
	{
	}

	public void RegistBackSoftLabel(string label)
	{
	}

	public void UnregistBackSoftLabel(string label)
	{
	}

	public int GetShowBackSoftKey()
	{
		return 0;
	}

	public void RegistMenuSoftLabel(string label)
	{
	}

	public void UnregistMenuSoftLabel(string label)
	{
	}

	public void SetAspectRatio(int width, int height)
	{
	}

	public void SetAspectRatio()
	{
	}

	public float[] GetJoystickPointer(bool enableAsobi = true)
	{
		return null;
	}

	public void SetJoystickAsobi(float asobi)
	{
	}

	public void SetJoystickKeyReverse(bool r)
	{
	}

	public int GetJoystickKeyOK()
	{
		return 0;
	}

	public int GetJoystickKeyCancel()
	{
		return 0;
	}

	public void DrawScreenCursor(Graphics g)
	{
	}

	internal void DrawJoystickButtons(Graphics g)
	{
	}

	public void DrawDebugInfo(Graphics g, int dx = -1, int dy = -1)
	{
	}

	public void DrawDebugForm(Graphics g)
	{
	}

	public void DrawStringBG(Graphics g, string text, int x, int y, int fontSize, int textColor, int bgColor, int anchor)
	{
	}

	private void InitTouchEffect()
	{
	}

	private void AddTouchEffect(float x, float y)
	{
	}

	public void DrawTouchEffect(Graphics g)
	{
	}

	public bool IsGameSkip()
	{
		return false;
	}

	public bool IsTimeSkip()
	{
		return false;
	}

	public bool IsMessageSkip()
	{
		return false;
	}

	private static int GetJoystickIndex(int key)
	{
		return 0;
	}

	internal Keypad GetFocusKeypad()
	{
		return null;
	}

	public static bool IsJoystickEnable()
	{
		return false;
	}

	public bool HasKeyboard()
	{
		return false;
	}

	public void SetInputGuard(long ms)
	{
	}

	public void SetInputGuardKey()
	{
	}

	public void SetInputGuardJoystick()
	{
	}

	public void SetInputGuard(FormBase form, bool guard)
	{
	}

	private bool CheckInputGuard()
	{
		return false;
	}

	private bool CheckJoystickGuard()
	{
		return false;
	}

	public void CaptureStart()
	{
	}

	public void BeginPhysicalInput()
	{
	}

	public void EndPhysicalInput()
	{
	}

	public bool IsFingerTouch()
	{
		return false;
	}

	public bool IsAnyInput()
	{
		return false;
	}

	public int GetShowMenuSoftKey()
	{
		return 0;
	}

	public void SetJoystickKeyCode(KeyCode ZL = KeyCode.Keypad0, KeyCode ZR = KeyCode.Keypad4)
	{
	}

	public InputDevices GetCurrentInputDevice()
	{
		return InputDevices.Unknown;
	}

	public bool IsPointingDevice()
	{
		return false;
	}

	public void SetCurrentInputDevice(InputDevices device)
	{
	}

	internal int GetMouseWheelMode()
	{
		return 0;
	}

	internal bool CheckInGameView(float x, float y)
	{
		return false;
	}
}

using System.Collections.Generic;
using java.util;
using kairo.unity.form;
using kairo.unity.type;
using kairo.unity.ui;

namespace kairo.unity.surface;

public abstract class SurfaceBase
{
	public class TouchPoint
	{
		public long key;

		public int id;

		public int value;

		public float x;

		public float y;

		public float dragBaseX;

		public float dragBaseY;

		public TouchComponent component;

		public void Init(long key, float x, float y, TouchComponent component)
		{
		}
	}

	public class MotionEventRecord
	{
		private class MultiTouch
		{
			private MotionEvent event_;

			public void Set(MotionEvent evt)
			{
			}

			public int GetPointerCount()
			{
				return 0;
			}

			public int GetPointerId(int index)
			{
				return 0;
			}

			public float GetX(int index)
			{
				return 0f;
			}

			public float GetY(int index)
			{
				return 0f;
			}

			public float GetDeltaX(int index)
			{
				return 0f;
			}

			public float GetDeltaY(int index)
			{
				return 0f;
			}

			public float GetDeltaTime(int index)
			{
				return 0f;
			}
		}

		private static MultiTouch multiTouch_;

		public int action;

		public float x;

		public float y;

		public float deltaX;

		public float deltaY;

		public float deltaTime;

		public int pointerCount;

		public int[] pointerIds;

		public float[] pointerPos;

		public float[] pointerDelta;

		public bool isMousePointer;

		public bool isRightClick;

		public bool IsEmpty()
		{
			return false;
		}

		public void Clear()
		{
		}

		public void Copy(SurfaceBase surface, MotionEvent evt)
		{
		}

		public void Copy(SurfaceBase surface, MotionEventRecord evt)
		{
		}

		public int GetAction()
		{
			return 0;
		}

		public float GetX()
		{
			return 0f;
		}

		public float GetY()
		{
			return 0f;
		}

		public float GetDeltaX()
		{
			return 0f;
		}

		public float GetDeltaY()
		{
			return 0f;
		}

		public float GetDeltaTime()
		{
			return 0f;
		}

		public bool IsMousePointer()
		{
			return false;
		}

		public bool IsRightClick()
		{
			return false;
		}

		public int GetPointerCount()
		{
			return 0;
		}

		public int GetPointerId(int pointerIndex)
		{
			return 0;
		}

		public float GetX(int index)
		{
			return 0f;
		}

		public float GetY(int index)
		{
			return 0f;
		}

		public float GetDeltaX(int index)
		{
			return 0f;
		}

		public float GetDeltaY(int index)
		{
			return 0f;
		}

		public float GetDeltaTime(int index)
		{
			return 0f;
		}
	}

	public delegate bool OnTouchEventDelegate(TouchEvent e);

	private class TouchEventHook
	{
		public FormBase form_;

		public OnTouchEventDelegate method_;

		public TouchEventHook(FormBase form, OnTouchEventDelegate method)
		{
		}
	}

	private Vector<TouchComponent> componentBuffer_;

	private Vector<TouchComponent> components_;

	public Vector<TouchPoint> startTouchList_;

	public Vector<TouchPoint> lastTouchList_;

	internal Vector<TouchPoint> touchListBuffer_;

	private int touchDownComponentId_;

	private bool delayEraseTouchDownComponentId_;

	private TouchComponent touchDownComponent_;

	internal bool touch_;

	private Vector<TouchEvent> touchEvents_;

	private Vector<TouchEvent> taskBuffer_;

	private Vector<TouchEvent>[] touchEventBuffer_;

	private int[] touchEventBufferNum_;

	private MotionEventRecord start_;

	private MotionEventRecord last_;

	private MotionEventRecord last2_;

	private MotionEventRecord[] delay_;

	private int delayNum_;

	private bool lock_;

	private bool multiTouchEnable_;

	private int[][] pinchPointer_;

	private int pinchDistance_;

	private int[][] pinchStartPoint_;

	private bool pinchStart_;

	private int x_;

	private int y_;

	private int width_;

	private int height_;

	protected float scaleRatio_;

	protected List<float> windowsScaleBackup_;

	protected List<Graphics> windowsScaleGraphics_;

	protected Graphics graphics_;

	private int[] scrollBarComponents_;

	private int scrollBgComponent_;

	private int touchOffset_;

	public int lastTouchX;

	public int lastTouchY;

	private bool registTouch_;

	public bool touchCancelOnce;

	private List<TouchEventHook> touchEventHooks_;

	private int invalidTouchFrames_;

	private bool clearTouchEvent_;

	private object OnReceiveTouchEvent_lock1;

	private static MotionEventRecord onReceiveTouchEvent_tmp;

	private object OnReceiveTouchEvent_lock2;

	private object OnReceiveTrackballEvent_lock;

	private static int[] screenTouchToLocal_result;

	private static int[] localTouchToScreen_result;

	public bool registTouch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MotionEventRecord Last => null;

	public void RegistTouchEventHook(FormBase form, OnTouchEventDelegate method)
	{
	}

	public void UnregistTouchEventHook(FormBase form)
	{
	}

	public TouchComponent AddTouchComponent(int id, int x, int y, int width, int height, int value, TouchOption option)
	{
		return null;
	}

	public TouchComponent AddTouchComponent(TouchComponent component)
	{
		return null;
	}

	public bool ExistTouchComponent(TouchComponent component)
	{
		return false;
	}

	public void ClearTouchComponent()
	{
	}

	internal TouchPoint CreateTouchPoint(long key, float x, float y, TouchComponent component)
	{
		return null;
	}

	internal virtual void DoBegin()
	{
	}

	internal void ClearTouchEvent()
	{
	}

	public virtual void DoEnd()
	{
	}

	internal bool CheckTouchComponent(TouchComponent c, float x, float y)
	{
		return false;
	}

	internal virtual bool DoEvent(TouchComponent c)
	{
		return false;
	}

	protected abstract void OnTouchEvent(TouchEvent evt);

	public virtual void BeginTouchRegist(Graphics g)
	{
	}

	public virtual void EndTouchRegist(Graphics g)
	{
	}

	public virtual void SetTouchRegistEnable(bool enable)
	{
	}

	public abstract void Draw(Graphics g);

	internal void OnDraw(Graphics g)
	{
	}

	public bool IsTouch()
	{
		return false;
	}

	public bool IsMultiTouchEnable()
	{
		return false;
	}

	public abstract bool IsGameSurface();

	public abstract void RotateClear();

	public int GetComponentLength()
	{
		return 0;
	}

	public TouchComponent GetComponent(int index)
	{
		return null;
	}

	public TouchComponent GetComponent(int id, int value)
	{
		return null;
	}

	public TouchComponent GetComponentId(int id)
	{
		return null;
	}

	public bool CheckTouch(int id, int value)
	{
		return false;
	}

	public bool CheckTouch(int id)
	{
		return false;
	}

	public bool CheckFirstTouch(int id, int value)
	{
		return false;
	}

	public bool CheckFirstTouch(int id)
	{
		return false;
	}

	private int SearchTouchKey(Vector<TouchPoint> list, long key)
	{
		return 0;
	}

	private int SearchTouchId(Vector<TouchPoint> list, int id)
	{
		return 0;
	}

	private bool CheckTouchKey(Vector<TouchPoint> list, long key)
	{
		return false;
	}

	private bool CheckTouchId(Vector<TouchPoint> list, int id)
	{
		return false;
	}

	protected Vector<TouchEvent> GetTouchEventsId(int id)
	{
		return null;
	}

	protected Vector<TouchEvent> GetTouchEventsId(int id, int type)
	{
		return null;
	}

	protected Vector<TouchEvent> GetTouchEventsKey(long key)
	{
		return null;
	}

	protected Vector<TouchEvent> GetTouchEventsKey(long key, int type)
	{
		return null;
	}

	protected TouchEvent GetTouchEventId(int id)
	{
		return null;
	}

	protected TouchEvent GetTouchEventId(int id, int type)
	{
		return null;
	}

	protected TouchEvent GetTouchEventKey(long key)
	{
		return null;
	}

	protected TouchEvent GetTouchEventKey(long key, int type)
	{
		return null;
	}

	protected TouchEvent GetTouchEventFlag(int flag)
	{
		return null;
	}

	protected TouchEvent GetTouchEventFlag(int flag, int type)
	{
		return null;
	}

	protected Vector<TouchEvent> GetTouchEventsFlag(int flag)
	{
		return null;
	}

	protected Vector<TouchEvent> GetTouchEventsFlag(int flag, int type)
	{
		return null;
	}

	protected TouchEvent CreateTouchEvent(int type)
	{
		return null;
	}

	protected TouchEvent CreateTouchEvent(int type, TouchComponent component)
	{
		return null;
	}

	public void SetScaleRatio(float scale)
	{
	}

	public float GetScaleRatio()
	{
		return 0f;
	}

	public void SetX(int x)
	{
	}

	public int GetX()
	{
		return 0;
	}

	public void SetY(int y)
	{
	}

	public int GetY()
	{
		return 0;
	}

	public void SetWidth(int width)
	{
	}

	public int GetWidth()
	{
		return 0;
	}

	public void SetHeight(int height)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void SetLocation(int x, int y)
	{
	}

	public void SetSize(int width, int height)
	{
	}

	public virtual int GetGameWidth()
	{
		return 0;
	}

	public virtual int GetGameHeight()
	{
		return 0;
	}

	public void BeginWindow(Graphics g)
	{
	}

	public void BeginWindow(Graphics g, int viewWidth, int viewHeight)
	{
	}

	public void EndWindow()
	{
	}

	public bool IsWindowMode()
	{
		return false;
	}

	protected bool CheckHitPointRect(int x, int y, int rcx, int rcy, int rcw, int rch)
	{
		return false;
	}

	public virtual void OnReceiveTouchEvent(MotionEvent evt)
	{
	}

	public void OnReceiveTouchEvent(MotionEventRecord evt)
	{
	}

	public void OnReceiveTrackballEvent(MotionEvent evt)
	{
	}

	public virtual void OnKeyDown(int key)
	{
	}

	public void OnKeyUp(int key)
	{
	}

	public virtual void OnKeyDown(int keyCode, KeyEvent evt)
	{
	}

	public virtual void OnKeyUp(int keyCode, KeyEvent evt)
	{
	}

	public int[] ScreenTouchToLocal(int x, int y)
	{
		return null;
	}

	public int[] LocalTouchToScreen(int x, int y)
	{
		return null;
	}

	public int GetTouchOffset()
	{
		return 0;
	}

	public virtual bool CanRegistComponent()
	{
		return false;
	}

	public bool CanForceRegistTouch()
	{
		return false;
	}

	public virtual bool CanRegistTouch(FormBase form)
	{
		return false;
	}

	public virtual bool CanForceRegistTouch(FormBase form)
	{
		return false;
	}

	public virtual bool CanRegistComponent(FormBase form)
	{
		return false;
	}

	public bool IsBezelless()
	{
		return false;
	}

	public Alignment GetSensorHousing()
	{
		return Alignment.None;
	}

	public Padding GetBezellessSafeArea()
	{
		return default;
	}

	public void TouchDown(int componentId)
	{
	}

	internal void ProcessTouchDown()
	{
	}

	public virtual int GetMouseWheelMode()
	{
		return 0;
	}

	public virtual int GetMouseWheelOrientation()
	{
		return 0;
	}

	public Point GetMouseCursor()
	{
		return default;
	}

	public Point GetMouseCursor(int viewX, int viewY, int cursorX, int cursorY, int camX, int camY, int zoom)
	{
		return default;
	}

	public void SetScrollComponent(int bgId, int[] barIds)
	{
	}

	protected TouchComponent GetScrollBarComponent()
	{
		return null;
	}

	protected TouchComponent GetScrollBgComponent()
	{
		return null;
	}

	protected void OnScrollBg(TouchEvent e)
	{
	}
}

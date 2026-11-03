using System;
using System.Collections.Generic;
using UnityEngine;
using kairo.unity.component;
using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.form;

public class FormBase : TouchValueAccessor, IComponentContainer
{
	internal int id_;

	internal string leftSoftLabel_;

	internal string rightSoftLabel_;

	internal string softLabel3_;

	internal string softLabel4_;

	internal int formProcMode_;

	internal FormManagerBase formManager_;

	internal int continuousUpdate_;

	internal int frameRate_;

	internal int updateFrameRate_;

	internal bool frameSkip_;

	private const int JOYIDX_A = 0;

	private const int JOYIDX_B = 1;

	private const int JOYIDX_X = 2;

	private const int JOYIDX_Y = 3;

	private const int JOYIDX_END = 4;

	private static KeyCode[] joystickKeycodeBase_;

	internal KeyCode[] joystickKeycode_;

	internal int[] joystickCancelFrame_;

	private bool[] joystickAssigned_;

	public const int FORMID_CONTROLLER = 200;

	public const int FORMID_LANGUAGESELECT = 201;

	public const int FORMID_GAMEOVER = 202;

	public const int FORMID_DIALOG = 203;

	public const int FORMID_SPLASH = 204;

	public const int FORMID_TROPHY = 205;

	public const int FORMID_SOCIAL = 206;

	public const int FORMID_TROPHY_MANAGER = 207;

	public const int FORMID_GRAPHICS_FONT = 208;

	public const int FORMID_ACCOUNT_DELETE = 209;

	public const int FORMID_REVIEW = 210;

	internal bool updated_;

	private string typeName_;

	public List<UIComponent> Components { get; private set; }

	public KeyCode JoystickAKeycode
	{
		get
		{
			return KeyCode.None;
		}
		set
		{
		}
	}

	public KeyCode JoystickBKeycode
	{
		get
		{
			return KeyCode.None;
		}
		set
		{
		}
	}

	public KeyCode JoystickXKeycode
	{
		get
		{
			return KeyCode.None;
		}
		set
		{
		}
	}

	public KeyCode JoystickYKeycode
	{
		get
		{
			return KeyCode.None;
		}
		set
		{
		}
	}

	public virtual bool IsFilledScreen => false;

	public virtual bool IsShowLowerForm => false;

	public FormBase(int id)
	{
	}

	public virtual bool Init()
	{
		return false;
	}

	public virtual void Draw(kairo.unity.ui.Graphics g)
	{
	}

	public virtual bool Update()
	{
		return false;
	}

	public virtual bool Resume()
	{
		return false;
	}

	internal virtual int DoGetTouchValue(int type, int index)
	{
		return 0;
	}

	internal virtual void DoSetTouchValue(int type, int value)
	{
	}

	public virtual int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public virtual void SetTouchValue(int type, int value)
	{
	}

	public virtual void Suspend()
	{
	}

	public virtual bool Finish()
	{
		return false;
	}

	public virtual void RefreshSoftLabel()
	{
	}

	public void SetSoftLabel(string left, string right, string soft3 = null, string soft4 = null)
	{
	}

	public string GetLeftSoftLabel()
	{
		return null;
	}

	public string GetRightSoftLabel()
	{
		return null;
	}

	public string GetSoftLabel3()
	{
		return null;
	}

	public string GetSoftLabel4()
	{
		return null;
	}

	public bool Push(FormBase form)
	{
		return false;
	}

	public bool Pop()
	{
		return false;
	}

	public virtual bool CheckMainWindow()
	{
		return false;
	}

	public bool CheckUsable()
	{
		return false;
	}

	public int GetId()
	{
		return 0;
	}

	public int GetProcessMode()
	{
		return 0;
	}

	public void SetProcessMode(int mode)
	{
	}

	public bool IsAlive()
	{
		return false;
	}

	public virtual bool ProcessEvent(AppEvent evt)
	{
		return false;
	}

	public virtual bool ProcessBackKey()
	{
		return false;
	}

	public void SetFrameRate(int frameRate, int updateFrameRate = -1, bool frameSkip = false)
	{
	}

	public void SetFrameRate(bool frameSkip)
	{
	}

	public T AddComponent<T>(T component, UIComponent.DisplayModes mode, int layer = 0) where T : UIComponent
	{
		return null;
	}

	public T AddComponent<T>(T component) where T : UIComponent
	{
		return null;
	}

	public void RemoveComponent(UIComponent component)
	{
	}

	public T GetComponent<T>() where T : UIComponent
	{
		return null;
	}

	public T[] GetComponents<T>() where T : UIComponent
	{
		return null;
	}

	public T GetComponent<T>(string name) where T : UIComponent
	{
		return null;
	}

	public UIComponent GetComponent(Type type)
	{
		return null;
	}

	public UIComponent[] GetComponents(Type type)
	{
		return null;
	}

	public UIComponent GetComponent(Type type, string name)
	{
		return null;
	}

	public UIComponent GetComponent(string name)
	{
		return null;
	}

	public void UpdateComponents()
	{
	}

	public void DrawComponents(kairo.unity.ui.Graphics g)
	{
	}

	public void DrawComponents(kairo.unity.ui.Graphics g, int layer)
	{
	}

	public void DrawComponents(kairo.unity.ui.Graphics g, int beginLayer, int lastLayer)
	{
	}

	public bool IsSubFormEx()
	{
		return false;
	}

	internal void SetAutoCancelJoystick(int button)
	{
	}

	private KeyCode GetJoystickKeycode(int index)
	{
		return KeyCode.None;
	}

	public string GetTypeName()
	{
		return null;
	}
}

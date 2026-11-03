using System;
using System.Collections.Generic;
using UnityEngine;
using kairo.unity.form;
using kairo.unity.graphics;
using kairo.unity.surface;
using kairo.unity.type;
using kairo.unity.ui;

namespace kairo.unity.component;

public abstract class UIComponent : IDisposable, IComponentContainer
{
	public enum DisplayModes
	{
		Form = 0,
		Float = 1,
		Manual = 2
	}

	public enum KeyInputModes
	{
		Disable = 0,
		Modeless = 1,
		Modal = 2
	}

	public delegate void PreUpdateDelegate(UIComponent c);

	public delegate void PreDrawDelegate(UIComponent c, kairo.unity.ui.Graphics g, SurfaceBase surface);

	protected int drawCall_;

	protected PointF position_;

	protected SizeF size_;

	protected bool refresh_;

	protected int dynamicOnly_;

	protected bool visible_;

	protected Keypad keypad_;

	internal List<IComponentContainer> ParentContainers;

	private bool forceRender_;

	private kairo.unity.ui.Font fontBuf_;

	private kairo.unity.ui.Font fontBuf2_;

	private bool keep_;

	private static List<UIComponent> keepComponents_;

	public static UIComponent Current { get; set; }

	public string Name { get; set; }

	public FormBase Form { get; set; }

	public UIComponent Parent { get; private set; }

	public Keypad Keypad => null;

	public bool Enable { get; set; }

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PointF Position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public SizeF Size
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public int Layer { get; set; }

	public UIOffscreen Offscreen { get; protected set; }

	public int BackColor { get; set; }

	public int ForeColor { get; set; }

	public KeyInputModes KeyInputMode { get; set; }

	public object Tag { get; set; }

	public bool IsDispose { get; internal set; }

	public int Alpha { get; set; }

	public GameObject GameObject { get; set; }

	public DisplayModes DisplayMode { get; set; }

	public List<UIComponent> Components { get; private set; }

	public object Option { get; set; }

	public DisplayModes DefaultDisplayMode { get; set; }

	public int DefaultLayer { get; set; }

	public bool Blur
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int BlurCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool RenderEnable { get; set; }

	public bool Origin { get; set; }

	public bool Keep
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PreUpdateDelegate PreUpdate { get; set; }

	public PreDrawDelegate PreDraw { get; set; }

	public static bool RefreshLock { get; set; }

	protected virtual void PositionChanged()
	{
	}

	protected virtual void SizeChanged()
	{
	}

	protected virtual void VisibleChanged()
	{
	}

	public UIComponent(string name)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void OnDispose()
	{
	}

	public void Draw(kairo.unity.ui.Graphics g)
	{
	}

	protected void Draw(kairo.unity.ui.Graphics g, float x, float y, float width, float height)
	{
	}

	protected virtual void OnPreDraw(kairo.unity.ui.Graphics g, SurfaceBase surface)
	{
	}

	protected virtual void OnDraw(kairo.unity.ui.Graphics g, float x, float y, float width, float height)
	{
	}

	public void Update()
	{
	}

	public void Update(bool forceUpdate)
	{
	}

	protected virtual void OnPreUpdate()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	public bool DoTouchEvent(TouchEvent e)
	{
		return false;
	}

	public virtual bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}

	public TouchValue DoGetTouchValue(int type, int index)
	{
		return default;
	}

	public virtual TouchValue GetTouchValue(int type, int index)
	{
		return default;
	}

	public bool DoSetTouchValue(int type, int value)
	{
		return false;
	}

	public virtual bool SetTouchValue(int type, int value)
	{
		return false;
	}

	internal void OffscreenLayout(out int width, out int height, out Image.Format format, out Image.Filter filterMode)
	{
		width = default;
		height = default;
		format = default;
		filterMode = default;
	}

	protected virtual void OnOffscreenLayout(ref int width, ref int height, ref Image.Format format, ref Image.Filter filterMode)
	{
	}

	internal bool StaticRender(kairo.unity.ui.Graphics g, Offscreen offscreen)
	{
		return false;
	}

	protected virtual void OnStaticRender(kairo.unity.ui.Graphics g, Offscreen offscreen)
	{
	}

	internal bool DynamicRender(kairo.unity.ui.Graphics g, Offscreen offscreen)
	{
		return false;
	}

	protected virtual void OnPreDynamicRender(kairo.unity.ui.Graphics g, Offscreen offscreen)
	{
	}

	protected virtual void OnDynamicRender(kairo.unity.ui.Graphics g, Offscreen offscreen)
	{
	}

	public void SetPosition(float x, float y, float width, float height)
	{
	}

	public T AddComponent<T>(T component, DisplayModes mode, int layer = 0) where T : UIComponent
	{
		return null;
	}

	public T AddComponent<T>(T component) where T : UIComponent
	{
		return null;
	}

	internal static void AddComponentHierarchy(UIComponent component)
	{
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

	public void Refresh()
	{
	}

	public void Refresh(bool dynamicOnly)
	{
	}

	internal void InvokeAddComponent(IComponentContainer parent)
	{
	}

	protected virtual void OnAddComponent(IComponentContainer parent)
	{
	}

	internal void InvokeRemoveComponent(IComponentContainer parent)
	{
	}

	protected virtual void OnRemoveComponent(IComponentContainer parent)
	{
	}

	internal static void RemoveKeepComponents()
	{
	}
}

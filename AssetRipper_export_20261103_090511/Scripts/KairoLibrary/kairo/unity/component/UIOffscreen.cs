using kairo.unity.graphics;
using kairo.unity.ui;

namespace kairo.unity.component;

public class UIOffscreen
{
	private UIComponent com_;

	private int order_;

	private int density_;

	private bool enable_;

	public Offscreen Object { get; private set; }

	public Image Image => null;

	public bool Enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Density
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Order
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator Offscreen(UIOffscreen ofs)
	{
		return null;
	}

	internal UIOffscreen(UIComponent com)
	{
	}

	internal void ResetOffscreen()
	{
	}
}

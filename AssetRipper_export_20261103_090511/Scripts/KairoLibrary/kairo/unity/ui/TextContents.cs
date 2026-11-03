using System;

namespace kairo.unity.ui;

public struct TextContents
{
	[Flags]
	private enum Flags
	{
		Bold = 1,
		Shadow = 2,
		SizeDefault = 4,
		ColorDefault = 8,
		StyleDefault = 0x10
	}

	public enum Styles
	{
		Plain = 0,
		Bold = 1,
		Shadow = 2
	}

	private Flags flag_ = (Flags)0;

	private int fontSize_ = 0;

	private int color_ = 0;

	public string Text { get; set; } = null;

	public int FontSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Color
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Color2 { get; set; } = 0;

	public int WidthMax { get; set; } = 0;

	public Styles Style
	{
		get
		{
			return Styles.Plain;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsShadow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsSizeDefault
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool IsColorDefault
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool IsStyleDefault
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static implicit operator TextContents(string text)
	{
		return default;
	}

	public static bool operator ==(TextContents a, string b)
	{
		return false;
	}

	public static bool operator !=(TextContents a, string b)
	{
		return false;
	}

	public TextContents(Graphics g, string label)
	{
	}

	public TextContents(Graphics g, string label, Styles style)
	{
	}

	public TextContents(Graphics g, string label, Styles style, int color2)
	{
	}

	public TextContents(string text)
	{
	}

	public TextContents(string text, int color)
	{
	}

	public TextContents(string text, int color, int size)
	{
	}

	public TextContents(string text, int color, Styles style, int color2)
	{
	}

	public TextContents(string text, int color, Styles style, int color2, int size)
	{
	}

	public void Draw(Graphics g, float x, float y, int anchor = 0)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

using kairo.unity.type;

namespace kairo.unity.ui;

public class RenderContents
{
	public delegate void RenderMethodDelegate(Graphics g, RectF rc);

	public Rect Rectangle;

	public Seb Seb { get; set; }

	public int Frame { get; set; }

	public int BlendMode { get; set; }

	public int BlendColor { get; set; }

	private RenderMethodDelegate RenderMethod { get; set; }

	public static implicit operator RenderContents(Seb seb)
	{
		return null;
	}

	public RenderContents(Seb seb, int frame, int blendMode = 0, int blendColor = 0)
	{
	}

	public RenderContents(RenderMethodDelegate method, Rect rect, int blendMode = 0, int blendColor = 0)
	{
	}

	public RenderContents(Seb seb, int frame, RenderMethodDelegate method, int blendMode = 0, int blendColor = 0)
	{
	}

	public void Draw(Graphics g, float x, float y)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

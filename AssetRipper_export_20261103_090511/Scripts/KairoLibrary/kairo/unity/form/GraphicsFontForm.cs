using UnityEngine;
using kairo.unity.type;
using kairo.unity.ui;
using kairo.unity.util;

namespace kairo.unity.form;

internal class GraphicsFontForm : LibraryFormBase
{
	private kairo.unity.type.Rect captureRect_;

	private int frame_;

	private const string TEMP_FILE = "gfont_temp.png";

	public GraphicsFontForm()
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override bool Update()
	{
		return false;
	}

	private Image Convert(GraphicsFont.Data data, Image img)
	{
		return null;
	}

	private void AntiAliasing(UnityEngine.Color[] line, bool[] check, int xi, int yi)
	{
	}

	private bool CheckPixel(UnityEngine.Color p1, UnityEngine.Color p2, float max = 50f)
	{
		return false;
	}

	public override void Draw(kairo.unity.ui.Graphics g)
	{
	}
}

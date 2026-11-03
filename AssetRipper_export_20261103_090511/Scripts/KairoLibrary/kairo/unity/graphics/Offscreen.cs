using System;
using System.Collections.Generic;
using UnityEngine;
using kairo.unity.surface;
using kairo.unity.ui;

namespace kairo.unity.graphics;

public class Offscreen : MonoBehaviour, IDisposable
{
	public delegate bool RenderMethod(kairo.unity.ui.Graphics g, Offscreen offscreen);

	public delegate bool MultiRenderMethod(kairo.unity.ui.Graphics g, Offscreen offscreen, int id);

	public delegate void GetLayoutMethod(out int width, out int height, out Image.Format format, out Image.Filter filterMode);

	private static GameObject prefabOffscreen_;

	internal static List<Offscreen> offscreenList_;

	internal RenderMethod DynamicRender;

	internal RenderMethod StaticRedner;

	internal GetLayoutMethod GetLayout;

	private Image image_;

	private bool isEmpty_;

	private bool clear_;

	private bool dispose_;

	private Matrix4x4[] staticTransform_;

	private Matrix4x4 staticTransformGen_;

	internal Matrix4x4 dynamicTransform_;

	private bool staticRenderd_;

	private kairo.unity.ui.Graphics graDynamics_;

	private kairo.unity.ui.Graphics graStatics_;

	private static bool rendering_;

	internal static int DepthBits;

	internal static float lowDepthScaling_;

	internal bool useLowDepthScaling_;

	private Matrix4x4[] renderMatrix_;

	private MeshManager[] renderMesh_;

	private int[] renderIndex_;

	private int[] renderLength_;

	private List<MeshManager.LayerMesh>[] renderList_;

	private int lastRenderMaterialCount_;

	private List<Material> lastRenderMaterials_;

	private int density_;

	internal int useDensity_;

	private bool postRenderLocK_;

	private Blur blurObject_;

	private bool blur_;

	private int blurFrame_;

	private int blurCount_;

	private bool guiSkip_;

	private int Resize_param1;

	private int Resize_param2;

	private Image.Format Resize_param3;

	private Image.Filter Resize_param4;

	private bool Resize_param5;

	private TouchComponent[] touchComponentBuffer_;

	private static bool WARNING;

	private static int RESOLUTION_MAX;

	public Image Image => null;

	public bool IsEmpty => false;

	public int Density => 0;

	public int Width => 0;

	public int Height => 0;

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

	private Offscreen()
	{
	}

	public static Offscreen CreateOffscreen(RenderMethod dynamicRender, RenderMethod staticRender, GetLayoutMethod layout, int order = 0, int density = 1)
	{
		return null;
	}

	public static void Render(Image image, RenderMethod render)
	{
	}

	public void Render()
	{
	}

	private bool Resize(int width, int height, Image.Format format = Image.Format.ARGB32, Image.Filter filterMode = Image.Filter.Default, bool force = false)
	{
		return false;
	}

	private bool _resize(int width, int height, Image.Format format = Image.Format.ARGB32, Image.Filter filterMode = Image.Filter.Default, bool force = false)
	{
		return false;
	}

	public void SetStaticsTransform(float x, float y, float depth = 0f, float scaleX = 1f, float scaleY = 1f)
	{
	}

	public void SetStaticsTransform(Matrix4x4 matrix)
	{
	}

	public void SetMultiStaticsTransform(int id, int x, int y, int depth = 0, float scaleX = 1f, float scaleY = 1f)
	{
	}

	public void SetMultiStaticsTransform(int id, Matrix4x4 matrix)
	{
	}

	public void SetDynamicsTransform(float x, float y, float depth = 0f, float scaleX = 1f, float scaleY = 1f)
	{
	}

	public void SetDynamicsTransform(Matrix4x4 matrix)
	{
	}

	public static void SetLowDepthScaling(float scale = 1024f)
	{
	}

	public static float GetLowDepthScaling()
	{
		return 0f;
	}

	public void RenderStatics()
	{
	}

	public void RenderAlterStatics(RenderMethod method)
	{
	}

	public void RenderMultiStatics(int id, MultiRenderMethod method)
	{
	}

	public void Dispose()
	{
	}

	private void OnDestroy()
	{
	}

	public static void DisposeAll()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPostRender()
	{
	}

	internal void Flush()
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

	public static bool IsRendering()
	{
		return false;
	}

	public void Clear(int color)
	{
	}

	public void Clear(int r, int g, int b, int a = 255)
	{
	}

	public static int GetDepthBits()
	{
		return 0;
	}

	private static int AdjustDensity(int width, int height, int density)
	{
		return 0;
	}
}

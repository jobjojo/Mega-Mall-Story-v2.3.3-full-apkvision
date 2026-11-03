using System.Collections.Generic;
using UnityEngine;
using java.util;
using kairo.unity.ui;

namespace kairo.unity.surface;

public abstract class SurfaceManagerBase
{
	protected Vector<SurfaceBase> surfaceList_;

	private TouchComponent[] components_;

	private List<Vector2[]> paintRects_;

	private int currentPaintRect_;

	private int currentPaintPoint_;

	private static bool autoGLRender_;

	private static bool autoGLRenderClipEnable_;

	private static SurfaceBase currentSurface_;

	private int[] getBoundingRect_tmp;

	private static int[] safeArea_;

	public static SurfaceBase CurrentSurface => null;

	public Vector<SurfaceBase> GetSurfaceList()
	{
		return null;
	}

	public void DoAdjustSurfaceLayout()
	{
	}

	public abstract void AdjustSurfaceLayout();

	public void ClearTouchComponent()
	{
	}

	public void DoEvents()
	{
	}

	private bool GetSelectPaintPoint(float x, float y, out int rectIndex, out int handleIndex)
	{
		rectIndex = default;
		handleIndex = default;
		return false;
	}

	private int[] GetPaintRect(Vector2[] points)
	{
		return null;
	}

	private Vector2[] GetPaintHandlePoint(Vector2[] points)
	{
		return null;
	}

	public void BeginTouchRegist(kairo.unity.ui.Graphics g)
	{
	}

	public void EndTouchRegist(kairo.unity.ui.Graphics g)
	{
	}

	public virtual void Draw(kairo.unity.ui.Graphics g)
	{
	}

	public int[] GetBoundingRect()
	{
		return null;
	}

	public void CheckScreenRotation()
	{
	}

	public void CheckScreenRotation(bool skip)
	{
	}

	public virtual void DrawComponents(kairo.unity.ui.Graphics g)
	{
	}

	public void OnKeyDown(int key)
	{
	}

	public void OnKeyUp(int key)
	{
	}

	public void OnKeyDown(int keyCode, KeyEvent evt)
	{
	}

	public void OnKeyUp(int keyCode, KeyEvent evt)
	{
	}

	public void DisposeRotatingBuffer()
	{
	}

	public bool CheckRotatingBuffer()
	{
		return false;
	}

	public bool CheckNativeRotation()
	{
		return false;
	}

	public bool IsRotating()
	{
		return false;
	}

	public static void SetAutoGLRender(bool use, bool clipEnable = true)
	{
	}

	public static bool IsAutoGLRender()
	{
		return false;
	}

	public static void UpdateAutoSafeArea()
	{
	}

	public static int GetAutoSafeArea(int safeIndex)
	{
		return 0;
	}

	private static bool IsDrawAutoSafeArea()
	{
		return false;
	}

	public bool CheckTouchRightComponent(int x, int y)
	{
		return false;
	}
}

using System;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.graphics;

public class Material : IDisposable
{
	private Shader shader_;

	private Image image_;

	private UnityEngine.Material material_;

	private int hashCode_;

	internal string key_;

	internal int NotAccessFrame;

	internal bool UntiColor;

	private int renderQueueOffset_;

	private int renderQueue_;

	private bool isDisposed_;

	internal int RenderQueueOffset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int RenderQueue => 0;

	public bool IsDisposed => false;

	public Material(Shader shader, Image image = null)
	{
	}

	public Material(UnityEngine.Material material, Image image = null)
	{
	}

	public Shader GetShader()
	{
		return null;
	}

	public Image GetImage()
	{
		return null;
	}

	public UnityEngine.Material GetMaterial()
	{
		return null;
	}

	public bool SetPass(int pass)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void Dispose()
	{
	}
}

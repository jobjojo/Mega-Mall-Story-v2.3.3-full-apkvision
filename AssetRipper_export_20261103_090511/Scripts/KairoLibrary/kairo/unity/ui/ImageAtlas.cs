using System;
using System.Collections.Generic;
using UnityEngine;
using kairo.unity.graphics;

namespace kairo.unity.ui;

public class ImageAtlas
{
	internal enum Types
	{
		Create = 0,
		Load = 1
	}

	private class HeightPoint
	{
		public int X;

		public int Y;

		public HeightPoint(int x, int y)
		{
		}

		public void Set(int x, int y)
		{
		}

		public void Set(int y)
		{
		}
	}

	internal class AtlasRegion : IDisposable
	{
		public ImageAtlas Atlas;

		public Image Image;

		public int X;

		public int Y;

		public int Width;

		public int Height;

		public Color[] Pixels;

		public bool Valid;

		public bool Hint;

		public int AlphaType;

		internal AtlasRegion(ImageAtlas atlas)
		{
		}

		internal bool IsValid()
		{
			return false;
		}

		public void Dispose()
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private int id_;

	internal Dictionary<Image, AtlasRegion> regions_;

	private List<AtlasRegion> spaces_;

	private Image imgAtlas_;

	private HeightPoint[] heightMap_;

	private bool change_;

	internal bool reservedApply_;

	internal Types type_;

	private const int BSP_WIDTH = 32;

	private const int BSP_HEIGHT = 32;

	private List<AtlasRegion>[][] bspMap_;

	private List<AtlasRegion> bspList_;

	private const int MARGIN = 1;

	private Dictionary<string, AtlasRegion> hintRegions_;

	private HeightPoint[] hintHeightMap_;

	private Rectangle GetBspRect_Result;

	private ImageAtlas(int id)
	{
	}

	internal static ImageAtlas CreateImageAtlas(int id, int width, int height, Image.Format format, Image.Filter filterMode)
	{
		return null;
	}

	internal void Reset()
	{
	}

	internal void Dispose()
	{
	}

	public void Compaction()
	{
	}

	internal AtlasRegion ImageToAtlas(Image image)
	{
		return null;
	}

	internal void Apply()
	{
	}

	internal void AtlasToImages()
	{
	}

	internal void AtlasToImage(Image image)
	{
	}

	internal void RemoveAtlas(Image image)
	{
	}

	private AtlasRegion Pack(Image image, int width = 0, int height = 0, Color[] pixels = null)
	{
		return null;
	}

	private void Pack(AtlasRegion region)
	{
	}

	internal void RaiseHeightMap()
	{
	}

	private void RegistBSP(AtlasRegion region)
	{
	}

	private void UnregistBSP(AtlasRegion region)
	{
	}

	private static bool CheckHitRect(int x1, int y1, int w1, int h1, int x2, int y2, int w2, int h2)
	{
		return false;
	}

	private Rectangle GetBspRect(int x, int y, int width, int height)
	{
		return null;
	}

	public Image GetImage()
	{
		return null;
	}

	public void GetAtlasInfo(out int totalPixels, out int usedPixels, out int fragmentPixels, out int totalImages, out int atlasImages)
	{
		totalPixels = default;
		usedPixels = default;
		fragmentPixels = default;
		totalImages = default;
		atlasImages = default;
	}

	public string GetHint()
	{
		return null;
	}

	public void SetHint(string data)
	{
	}

	public void SetHint(string data, string[] excludeFiles)
	{
	}

	public void Load(Image image, string hint, string[] excludeFiles = null)
	{
	}

	public byte[] GetPng()
	{
		return null;
	}

	public byte[] GetPng(bool trim)
	{
		return null;
	}

	public static Image[] SortForAtlas(Image[] images)
	{
		return null;
	}

	internal Image LoadImageFromAtlas(string file, byte[] data)
	{
		return null;
	}
}

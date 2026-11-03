using System;
using System.Collections.Generic;

namespace kairo.unity.ui;

public class ImageAtlasManager : IDisposable
{
	private static ImageAtlasManager instance_;

	private List<ImageAtlas> imageAtlas_;

	internal bool enable_;

	internal bool loadAtlas_;

	internal bool isAtlasLoading_;

	internal bool LockApply { get; set; }

	private ImageAtlasManager()
	{
	}

	public static ImageAtlasManager GetInstance()
	{
		return null;
	}

	public void Dispose()
	{
	}

	public void Dispose(int id)
	{
	}

	public void CreateImageAtlas(int id, int width = 512, int height = 512, Image.Format format = Image.Format.ARGB32, Image.Filter filterMode = Image.Filter.Default)
	{
	}

	public void Compaction(int id = -1)
	{
	}

	public int GetAtlasCount()
	{
		return 0;
	}

	public ImageAtlas GetAtlas(int id)
	{
		return null;
	}

	internal Image.Result ImageToAtlas(int id, Image image)
	{
		return Image.Result.Success;
	}

	internal void AtlasToImage(Image image)
	{
	}

	internal void RemoveAtlas(Image image)
	{
	}

	public void SetEnable(bool enable)
	{
	}

	public void SavePng()
	{
	}

	public void SavePng(int id)
	{
	}

	private void SavePng(ImageAtlas atlas)
	{
	}

	public void ImageToAtlas(int id, int size, Image[] images, string hint = null)
	{
	}

	public void ImageToAtlas(int id, int max, int size, Image[] images, string hint = null)
	{
	}

	public void LoadImageAtlas(int id, Image image, string hint, string[] excludeFiles = null)
	{
	}

	internal Image LoadImageFromAtlas(string file, byte[] data)
	{
		return null;
	}

	private void CheckAtlas(int id, int size)
	{
	}
}

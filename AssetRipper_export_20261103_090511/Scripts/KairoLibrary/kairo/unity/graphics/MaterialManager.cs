using System.Collections.Generic;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.graphics;

public class MaterialManager
{
	private static MaterialManager instance_;

	private static Image empty_;

	private Dictionary<Image, Dictionary<string, Material>> materlas_;

	private static ShaderBuilder GetMaterial_sb;

	private static Dictionary<string, Dictionary<Color, string>> blendNameCache_;

	private static Dictionary<string, Dictionary<int, string>> queueNameCache_;

	protected MaterialManager()
	{
	}

	public static MaterialManager GetInstance()
	{
		return null;
	}

	public Material GetMaterial(kairo.unity.ui.Graphics g, Image image, Color[] colors, bool clipRegion = false)
	{
		return null;
	}

	public Material GetMaterial(kairo.unity.ui.Graphics g, bool clearDepth, bool clearColor, bool clearStencil)
	{
		return null;
	}

	public Material GetMaterial(kairo.unity.ui.Graphics g, Image image = null, float alpha = 1f, bool clipRegion = false, int opaTransOrder = -1, bool clearDepth = false, bool clearColor = false, bool clearStencil = false)
	{
		return null;
	}

	public Material GetMaterial(kairo.unity.ui.Graphics g, Image image, Color[] colors, float alpha, bool clipRegion, int opaTransOrder, bool clearDepth, bool clearColor, bool clearStencil)
	{
		return null;
	}

	public Material GetMaterial(Shader shader, Image image, params object[] args)
	{
		return null;
	}

	public Material GetMaterial(Material material, Image image)
	{
		return null;
	}

	public void RemoveInvalidMaterials()
	{
	}

	public void Clear()
	{
	}
}

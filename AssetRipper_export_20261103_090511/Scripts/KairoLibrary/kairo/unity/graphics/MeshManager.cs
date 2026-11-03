using System.Collections.Generic;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.graphics;

public class MeshManager
{
	internal class LayerMesh
	{
		public Material Material;

		public MeshBuilder.Layer Layer;

		public int Queue;

		public void Init(Material material, MeshBuilder.Layer layer)
		{
		}
	}

	internal const int DEPTH_MAX = 1500000;

	internal kairo.unity.ui.Graphics graphics_;

	internal bool dynamic_;

	internal Dictionary<Material, MeshBuilder> meshList_;

	internal List<KeyValuePair<Material, MeshBuilder>> sortedMeshList_;

	internal Offscreen offscreen_;

	internal bool isLowDepth_;

	internal float frontDepth_;

	internal float CurrentDepth;

	internal int CurrentDepthLayer;

	internal bool AlterStaticMesh;

	internal List<LayerMesh> layerMeshes_;

	internal int layerMeshesNum_;

	internal MeshRecord meshRecord_;

	internal List<MeshRecord> meshRecordList_;

	public MeshManager(MeshManager meshMan)
	{
	}

	public MeshManager(kairo.unity.ui.Graphics g, Offscreen offscreen = null, bool dynamic = true)
	{
	}

	public MeshBuilder GetMeshBuilder(Material material)
	{
		return null;
	}

	public void BeginMesh()
	{
	}

	public void EndMesh()
	{
	}

	public void RenderMesh(Matrix4x4 matrix)
	{
	}

	private void RenderMeshGL(Matrix4x4 matrix)
	{
	}

	public void RemoveInvalidMeshes()
	{
	}

	public bool CheckBrokenMesh()
	{
		return false;
	}

	public void SetDepth(int depth, bool back = false)
	{
	}

	public void SetDepthLayer(int layer)
	{
	}

	public int GetDepthLayer()
	{
		return 0;
	}

	public int GetDepthBack()
	{
		return 0;
	}

	public int GetDepthMin()
	{
		return 0;
	}

	public int GetDepthMax()
	{
		return 0;
	}

	public void SetDepthFront()
	{
	}

	public void Clear()
	{
	}

	public bool IsDynamic()
	{
		return false;
	}

	public kairo.unity.ui.Graphics GetGraphics()
	{
		return null;
	}

	public void UpdateLayerMeshes()
	{
	}

	internal void EndAlterRender()
	{
	}

	private void QuickSort(List<LayerMesh> a, int i, int j)
	{
	}

	private int Pivot(List<LayerMesh> a, int i, int j)
	{
		return 0;
	}

	private int Partition(List<LayerMesh> a, int i, int j, int x)
	{
		return 0;
	}
}

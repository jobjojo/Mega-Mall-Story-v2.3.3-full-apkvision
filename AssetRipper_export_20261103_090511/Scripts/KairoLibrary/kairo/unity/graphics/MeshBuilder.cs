using System;
using System.Collections.Generic;
using UnityEngine;

namespace kairo.unity.graphics;

public class MeshBuilder : IDisposable
{
	internal class Group
	{
		internal MeshBuilder builder;

		internal Mesh mesh;

		internal int vertexCount;

		internal Vector3[] verticies;

		internal Vector2[] texcoords;

		internal Color[] colors;

		internal int indexCount;

		internal int[] indicies;

		internal List<int> triangles;

		internal bool vertexColor;

		internal int head;

		internal List<int> removeIndicies;

		internal bool change;

		internal Group(MeshBuilder mb)
		{
		}

		internal void RemoveIndex(int index)
		{
		}

		public void UpdateRemoveMesh(List<MeshRecord> list)
		{
		}
	}

	internal class Layer
	{
		internal int layer;

		internal List<Group> groups;

		internal int currentGroup;

		private const int DEPTH_MAX = 1498976;

		internal Group Current => null;

		internal Layer(MeshBuilder mb, int layer)
		{
		}

		internal int GetIndexCount()
		{
			return 0;
		}
	}

	private MeshManager meshMan;

	internal Dictionary<int, Layer> layers;

	internal Layer currentLayer;

	internal bool vertexColor;

	internal int emptyFrames;

	internal float DepthTotal;

	internal Material material;

	internal float DEPTH_SCALE;

	internal float DEPTH_STEP;

	internal static bool DepthStepEnable { get; set; }

	public bool IsDisposed => false;

	public MeshBuilder(MeshManager meshMan, bool vertexColor, Material material)
	{
	}

	public void Reset()
	{
	}

	public void ReadyAddition()
	{
	}

	protected void CheckAndExpandGroup()
	{
	}

	protected void CheckAndExpand(int add)
	{
	}

	public void AddVertex(float x, float y, float z, Color color)
	{
	}

	public void AddVertex(Vector3 vertex, Color color)
	{
	}

	public void AddVertex(float x, float y, float z, float u, float v)
	{
	}

	public void AddVertex(Vector3 vertex, float u, float v)
	{
	}

	public void AddVertex(float x, float y, float z, float u, float v, Color color)
	{
	}

	public void AddVertex(Vector3 vertex, float u, float v, Color color)
	{
	}

	public void AddQuad(Vector3[] vertices, float tu, float tv, float tw, float th)
	{
	}

	public void AddQuad(Vector3[] vertices, float tu, float tv, float tw, float th, Color color)
	{
	}

	public void AddQuad(RectangleF dst, float tu, float tv, float tw, float th, Color color)
	{
	}

	public void AddQuad(RectangleF dst, float tu, float tv, float tw, float th)
	{
	}

	public void AddIndex(int tris)
	{
	}

	public void AddIndicies(params int[] tris)
	{
	}

	public void AddIndicies(int[] tris, int count)
	{
	}

	public void AddTriangleIndicies()
	{
	}

	public void AddQuadIndicies()
	{
	}

	public Mesh ConvertMesh(int layer = 0)
	{
		return null;
	}

	internal Mesh ConvertMesh(Layer layer)
	{
		return null;
	}

	internal Mesh ConvertMesh(Group group)
	{
		return null;
	}

	public Mesh GetMesh(int layer = 0)
	{
		return null;
	}

	public int GetTriangleCount()
	{
		return 0;
	}

	public int GetVertexCount()
	{
		return 0;
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

	public bool HasVertexColor()
	{
		return false;
	}

	private Layer GetLayer()
	{
		return null;
	}
}

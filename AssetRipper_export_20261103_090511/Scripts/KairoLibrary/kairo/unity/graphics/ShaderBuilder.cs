using System.Collections.Generic;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.graphics;

public class ShaderBuilder
{
	private class Node
	{
		public Node Parent;

		public int[] Flags;

		public List<Node> Nodes;

		public Node(params int[] flags)
		{
		}

		public Node Add(params Node[] nodes)
		{
			return null;
		}

		public Node Add(Node node)
		{
			return null;
		}

		public Node Add(params int[] flags)
		{
			return null;
		}

		public static Node New(params int[] flags)
		{
			return null;
		}

		public static Node New(Node copy)
		{
			return null;
		}

		public Node Clone()
		{
			return null;
		}

		public Node Top()
		{
			return null;
		}
	}

	public bool setClip;

	public bool useClip;

	public bool maskMode;

	public bool useTexture;

	public bool useBlendColor;

	public int renderOperator;

	public int renderSrcAlpha;

	public int renderDstAlpha;

	public bool isGUI;

	public int alphaType;

	public int opaTransOrder;

	public bool untiColor;

	public bool clearDepth;

	public bool clearColor;

	public bool clearStencil;

	private const int NAMEBIT_GUI = 1;

	private const int NAMEBIT_SETCLIP = 2;

	private const int NAMEBIT_USECLIP = 4;

	private const int NAMEBIT_MASKMODE = 8;

	private const int NAMEBIT_TEXTURE = 16;

	private const int NAMEBIT_BLEND = 32;

	private const int NAMEBIT_ADD = 64;

	private const int NAMEBIT_SUB = 128;

	private const int NAMEBIT_OPAQUE = 256;

	private const int NAMEBIT_TRANSPARENT = 512;

	private const int NAMEBIT_ALPHATEST = 1024;

	private const int NAMEBIT_OPATRANS1 = 2048;

	private const int NAMEBIT_OPATRANS2 = 4096;

	private const int NAMEBIT_INDEX0 = 8192;

	private const int NAMEBIT_INDEX1 = 16384;

	private const int NAMEBIT_INDEX2 = 32768;

	private const int NAMEBIT_UNTICOLOR = 65536;

	private const int NAMEBIT_CLEAR_COLOR = 131072;

	private const int NAMEBIT_CLEAR_DEPTH = 262144;

	private const int NAMEBIT_CLEAR_STENCIL = 524288;

	private const int NAMEBIT_CLEAR = 917504;

	private static Dictionary<int, string> nameCache_;

	public void Init(kairo.unity.ui.Graphics g, Image img = null, float alpha = 1f, bool clipRegion = false, int opaTransOrder = -1, bool clearDepth = false, bool clearColor = false, bool clearStencil = false)
	{
	}

	public void Init(kairo.unity.ui.Graphics g, Image img, Color[] colors, float alpha = 1f, bool clipRegion = false, int opaTransOrder = -1, bool clearDepth = false, bool clearColor = false, bool clearStencil = false)
	{
	}

	public Shader ToShader()
	{
		return null;
	}

	public string GetCode()
	{
		return null;
	}

	private static string GetCode(int nameId)
	{
		return null;
	}

	public string GetName()
	{
		return null;
	}

	private static string GetName(int nameBits)
	{
		return null;
	}

	public int GetNameId()
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

	public static void OutputShaders()
	{
	}

	private static void OutputShaders(Node node, int flag)
	{
	}
}

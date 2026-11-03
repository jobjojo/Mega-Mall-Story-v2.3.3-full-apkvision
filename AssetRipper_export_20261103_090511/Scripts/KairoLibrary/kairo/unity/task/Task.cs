using System.Collections.Generic;
using java.io;
using kairo.unity.secure;
using kairo.unity.type;
using kairo.unity.ui;
using kairo.unity.util;

namespace kairo.unity.task;

public class Task : ISerializable
{
	public class PaintInfo : ISerializable
	{
		public delegate void RenderDelegate(Graphics g, float x, float y, float h, int sebId, int frame);

		public PointF Pos { get; set; }

		public int Seb { get; set; }

		public int Frame { get; set; }

		public int Dir { get; set; }

		public int State { get; set; }

		public int[] Args { get; set; }

		public bool AutoReset { get; set; }

		public RenderDelegate Render { get; set; }

		public PaintInfo(bool autoReset = true)
		{
		}

		public void Reset()
		{
		}

		public void SetSeb(int seb, int frame = 0)
		{
		}

		public PaintInfo SetArgs(int[] args)
		{
			return null;
		}

		public PaintInfo SetRender(RenderDelegate render)
		{
			return null;
		}

		public void Serialize(OutputStream stream)
		{
		}

		public void Deserialize(InputStream stream)
		{
		}
	}

	private TaskFrameChecker frameChecker_;

	public Id Id { get; set; }

	public int Frame { get; set; }

	public int Count { get; internal set; }

	public XInt[] I { get; set; }

	public XLong[] L { get; set; }

	public float[] F { get; set; }

	public string[] S { get; set; }

	public object Opt { get; set; }

	public Task Next { get; set; }

	public List<Task> Childs { get; set; }

	public PaintInfo Paint { get; set; }

	public int this[int index]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Length => 0;

	public TaskFrameChecker FrameChecker => null;

	internal Task()
	{
	}

	public Task(Id id, params int[] param)
	{
	}

	public Task(Id id, int[] ints, long[] longs, float[] floats, string[] strs, object option = null)
	{
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

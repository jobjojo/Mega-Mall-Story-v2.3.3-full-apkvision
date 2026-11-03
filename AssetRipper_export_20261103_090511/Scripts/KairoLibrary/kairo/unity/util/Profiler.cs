using System;
using System.Collections.Generic;
using System.Diagnostics;
using kairo.unity.ui;

namespace kairo.unity.util;

public class Profiler
{
	private class Record
	{
		public string name_;

		public Stopwatch timer_;

		public int call_;

		public Dictionary<string, Record> childs_;

		public int rank_;

		public long subTicks_;

		public long secondTicks_;

		public int secondCount_;

		public double Time { get; set; }

		public int Count { get; set; }

		public Record(string name)
		{
		}

		public void FrameUpdate()
		{
		}
	}

	public enum Modes
	{
		Normal = 0,
		Unit = 1,
		Flat = 2
	}

	public struct Controller : IDisposable
	{
		public bool Enabled { get; internal set; }

		public void Dispose()
		{
		}
	}

	private static Dictionary<string, Record> records_;

	private static List<Record> stacks_;

	private static Stopwatch stopwatch_;

	private static bool visible_;

	private static bool enabled_;

	private static Modes mode_;

	private static bool readySample_;

	private static string[][] Logs { get; set; }

	public static bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Modes Mode
	{
		get
		{
			return Modes.Normal;
		}
		set
		{
		}
	}

	private static void Reset()
	{
	}

	public static void ChangePattern()
	{
	}

	internal static void FrameUpdate()
	{
	}

	public static void ReadySample()
	{
	}

	public static Controller BeginSample(string name)
	{
		return default;
	}

	public static void EndSample()
	{
	}

	internal static void SecondUpdate()
	{
	}

	private static void GetLog(Record record, List<Record> records)
	{
	}

	internal static void Draw(Graphics g, int x, int y, int width, int height)
	{
	}

	public static double GetSampleTime(string name)
	{
		return 0.0;
	}
}

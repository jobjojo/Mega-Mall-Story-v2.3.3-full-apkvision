using System.Collections.Generic;
using UnityEngine;
using kairo.unity.form;

namespace kairo.unity.ui;

public class ActionReplay
{
	internal class Record
	{
		public Vector2 scrollDelta_;

		public Vector3 position_;

		public bool[] button_;

		public bool[] buttonDown_;

		public bool[] buttonUp_;

		public float wheel_;

		public bool capture_;
	}

	public enum Modes
	{
		None = 0,
		Record = 1,
		Play = 2
	}

	internal static Modes mode_;

	internal static Modes reserveMode_;

	internal static List<Record> records_;

	internal static List<Record> replay_;

	internal static bool captureEnable_;

	internal static bool oldVersion_;

	internal static List<Record> oldReplay_;

	private static bool start_;

	private static Dictionary<string, byte[]> backup_;

	private static bool backupExist_;

	private static string devcmdReplayRecord_;

	private static bool checkReplayFile_;

	public static Modes Mode => Modes.None;

	internal static void Create()
	{
	}

	internal static void Init()
	{
	}

	internal static void Start(FormBase form)
	{
	}

	internal static byte[] Save()
	{
		return null;
	}

	internal static void Load(byte[] data)
	{
	}

	internal static void Push(bool capture = false)
	{
	}

	internal static Record Pop()
	{
		return null;
	}

	internal static void Restore()
	{
	}

	internal static bool CheckReplayFile()
	{
		return false;
	}
}

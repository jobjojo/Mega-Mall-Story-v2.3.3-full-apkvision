using System.Collections.Generic;
using java.io;
using kairo.unity.util;

namespace kairo.unity.ui;

public static class TextTable
{
	private class TextData
	{
		public int id_;

		public string tag_;

		public string text_;
	}

	private static List<TextData> systemTable_;

	private static List<TextData> userTable_;

	private static string tag_;

	private static string file_;

	private const int USERHEAD = 1000000;

	public static void SetTag(string tag)
	{
	}

	public static int Regist(string text)
	{
		return 0;
	}

	public static string Get(int id)
	{
		return null;
	}

	public static void Clear()
	{
	}

	public static void Load(JarInflater jar)
	{
	}

	public static void Serialize(OutputStream stream)
	{
	}

	public static void Deserialize(InputStream stream)
	{
	}
}

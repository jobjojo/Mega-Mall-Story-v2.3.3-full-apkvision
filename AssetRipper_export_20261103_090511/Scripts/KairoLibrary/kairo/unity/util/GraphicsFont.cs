using System.Collections.Generic;
using UnityEngine;
using kairo.unity.ui;

namespace kairo.unity.util;

public class GraphicsFont
{
	public class Data
	{
		internal Image image_;

		internal string langCode_;

		internal int hashCode_;

		internal static List<Data> taskList_;

		public string File { get; set; }

		public string Text { get; set; }

		public int FontSize { get; set; }

		public int WideSize { get; set; }

		public Color[] FontColors { get; set; }

		public int[] FontColorEasing { get; set; }

		public Color[] OutlineColors { get; set; }

		public Color ShadowColor { get; set; }

		public Data()
		{
		}

		public Data(string file, string text, int fontSize, int wideSize, int[] fontColors, int[] fontColorEasing, int shadowColor, int[] outlineColors)
		{
		}

		public Data(string file, string text, int fontSize, int wideSize, Color[] fontColors, int[] fontColorEasing, Color shadowColor, Color[] outlineColors)
		{
		}

		public Data(string file, string text, int fontSize, int wideSize, string fontColors, string fontColorEasing, string shadowColor, string outlineColors)
		{
		}

		private void Init(string file, string text, int fontSize, int wideSize, Color[] fontColors, int[] fontColorEasing, Color shadowColor, Color[] outlineColors)
		{
		}

		internal void Dispose()
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	internal static List<Data> taskList_;

	private static Dictionary<string, Data> renderData_;

	public static void Create(Data data, bool enforce = false)
	{
	}

	public static bool Draw(kairo.unity.ui.Graphics g, string file, float x, float y, int widthMax = -1, int anchor = 0)
	{
		return false;
	}

	private static Data Search(string file)
	{
		return null;
	}

	private static Data Search(string file, int hashCode = 0)
	{
		return null;
	}

	private static Color GetColor(string s)
	{
		return default;
	}

	private static int[] GetInts(string s)
	{
		return null;
	}

	internal static string GetFolder()
	{
		return null;
	}
}

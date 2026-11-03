using System;
using System.Collections.Generic;

namespace kairo.unity.util;

internal class LanguageConfig
{
	[Flags]
	internal enum Flag
	{
		Empty = 0xFF,
		Switch = 1,
		Create = 2,
		Disable = 4
	}

	internal class Settings
	{
		internal string code_;

		internal int priority_;

		internal Flag flag_;

		internal Settings(string code, int priority = -1, Flag flag = Flag.Empty)
		{
		}

		internal Settings(Settings copy)
		{
		}

		internal bool Check(Flag flag)
		{
			return false;
		}
	}

	internal int version_;

	internal Flag flag_;

	internal List<Settings> settings_;

	internal bool switchable_;

	internal bool creatable_;

	internal bool enable_;

	internal static Dictionary<string, Settings> settingCache_;

	internal void Load(byte[] src)
	{
	}

	private static bool TryReadInt(string value, out int v)
	{
		v = default;
		return false;
	}

	private static bool TryReadFlag(string value, out Flag v)
	{
		v = default;
		return false;
	}

	internal Settings GetLanguageSettings(string code)
	{
		return null;
	}
}

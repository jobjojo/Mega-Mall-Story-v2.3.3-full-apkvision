using System;
using System.Collections.Generic;
using java.io;
using kairo.unity.util;

namespace kairo.unity.ui;

public class Id : ISerializable
{
	private string name_;

	private Type type_;

	private static List<string> cache_;

	internal static Id Empty;

	public int Value { get; private set; }

	public string Name => null;

	public string Type { get; private set; }

	public string Key { get; private set; }

	public static bool operator ==(Id a, int b)
	{
		return false;
	}

	public static bool operator !=(Id a, int b)
	{
		return false;
	}

	public static bool operator ==(Id a, Id b)
	{
		return false;
	}

	public static bool operator !=(Id a, Id b)
	{
		return false;
	}

	public static implicit operator int(Id id)
	{
		return 0;
	}

	public Id()
	{
	}

	public Id(int id)
	{
	}

	public Id(int id, Type type)
	{
	}

	private void Init(int id, Type type)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	private static string Regist(string s)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}

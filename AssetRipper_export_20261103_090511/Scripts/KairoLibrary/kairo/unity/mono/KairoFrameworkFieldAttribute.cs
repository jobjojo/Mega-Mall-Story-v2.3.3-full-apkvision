using System;

namespace kairo.unity.mono;

[AttributeUsage(AttributeTargets.Field)]
public class KairoFrameworkFieldAttribute : Attribute
{
	public string Folder;

	public string Summary;

	public bool OnCreate;

	public bool PlayingReadOnly;

	public double Minimum;

	public double Maximum;

	public KairoFrameworkFieldAttribute(string foldout, string summary, bool playingReadOnly = false, bool onAwake = true)
	{
	}

	public KairoFrameworkFieldAttribute(string foldout, string summary, double minimum, double maximum, bool playingReadOnly = false, bool onAwake = true)
	{
	}
}

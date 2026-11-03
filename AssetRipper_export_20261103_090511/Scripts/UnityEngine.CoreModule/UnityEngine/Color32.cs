using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)2)]
[UsedByNativeCode]
[DefaultMember("Item")]
public struct Color32 : IFormattable
{
	[FieldOffset(0)]
	[Ignore(DoesNotContributeToSize = true)]
	private int rgba;

	[FieldOffset(0)]
	public byte r;

	[FieldOffset(1)]
	public byte g;

	[FieldOffset(2)]
	public byte b;

	[FieldOffset(3)]
	public byte a;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}
}

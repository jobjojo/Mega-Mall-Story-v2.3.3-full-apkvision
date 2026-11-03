using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[DefaultMember("Item")]
[NativeType("Runtime/Math/Vector2Int.h")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	private int m_X = 0;

	private int m_Y = 0;

	private static readonly Vector2Int s_Zero;

	private static readonly Vector2Int s_One;

	private static readonly Vector2Int s_Up;

	private static readonly Vector2Int s_Down;

	private static readonly Vector2Int s_Left;

	private static readonly Vector2Int s_Right;

	public int x
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0;
		}
	}

	public int y
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2Int(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector2Int other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

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

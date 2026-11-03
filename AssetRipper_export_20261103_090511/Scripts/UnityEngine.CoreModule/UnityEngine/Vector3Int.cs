using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine;

[DefaultMember("Item")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
{
	private int m_X = 0;

	private int m_Y = 0;

	private int m_Z = 0;

	private static readonly Vector3Int s_Zero;

	private static readonly Vector3Int s_One;

	private static readonly Vector3Int s_Up;

	private static readonly Vector3Int s_Down;

	private static readonly Vector3Int s_Left;

	private static readonly Vector3Int s_Right;

	private static readonly Vector3Int s_Forward;

	private static readonly Vector3Int s_Back;

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

	public int z
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3Int(int x, int y, int z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector3Int lhs, Vector3Int rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector3Int other)
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

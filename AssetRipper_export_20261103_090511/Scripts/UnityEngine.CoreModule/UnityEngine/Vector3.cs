using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeType(Header = "Runtime/Math/Vector3.h")]
[DefaultMember("Item")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("Vector3f")]
[NativeHeader("Runtime/Math/Vector3.h")]
[Il2CppEagerStaticClassConstruction]
public struct Vector3 : IEquatable<Vector3>, IFormattable
{
	public const float kEpsilon = 1E-05f;

	public const float kEpsilonNormalSqrt = 1E-15f;

	public float x = 0f;

	public float y = 0f;

	public float z = 0f;

	private static readonly Vector3 zeroVector;

	private static readonly Vector3 oneVector;

	private static readonly Vector3 upVector;

	private static readonly Vector3 downVector;

	private static readonly Vector3 leftVector;

	private static readonly Vector3 rightVector;

	private static readonly Vector3 forwardVector;

	private static readonly Vector3 backVector;

	private static readonly Vector3 positiveInfinityVector;

	private static readonly Vector3 negativeInfinityVector;

	public Vector3 normalized
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public float magnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public float sqrMagnitude
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return 0f;
		}
	}

	public static Vector3 zero
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3(float x, float y, float z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3(float x, float y)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Set(float newX, float newY, float newZ)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(Vector3 other)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Normalize(Vector3 value)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Magnitude(Vector3 vector)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator *(Vector3 a, float d)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 operator /(Vector3 a, float d)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector3 lhs, Vector3 rhs)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector3 lhs, Vector3 rhs)
	{
		return false;
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

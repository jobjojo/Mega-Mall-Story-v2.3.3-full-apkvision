using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[DefaultMember("Item")]
[UsedByNativeCode]
public struct Quaternion : IEquatable<Quaternion>, IFormattable
{
	public float x = 0f;

	public float y = 0f;

	public float z = 0f;

	public float w = 0f;

	private static readonly Quaternion identityQuaternion;

	public const float kEpsilon = 1E-06f;

	public static Quaternion identity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	[FreeFunction("EulerToQuaternion", IsThreadSafe = true)]
	private static Quaternion Internal_FromEulerRad(Vector3 euler)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Quaternion(float x, float y, float z, float w)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
	{
		return default;
	}

	public static Vector3 operator *(Quaternion rotation, Vector3 point)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion Euler(float x, float y, float z)
	{
		return default;
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
	public bool Equals(Quaternion other)
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

	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret)
	{
		ret = default;
	}
}

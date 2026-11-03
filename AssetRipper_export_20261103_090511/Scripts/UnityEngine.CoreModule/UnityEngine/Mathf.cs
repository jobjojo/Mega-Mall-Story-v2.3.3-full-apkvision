using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[StructLayout((LayoutKind)0, Size = 1)]
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Utilities/BitUtility.h")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
public struct Mathf
{
	public static readonly float Epsilon;

	[FreeFunction(IsThreadSafe = true)]
	public static bool IsPowerOfTwo(int value)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static float GammaToLinearSpace(float value)
	{
		return 0f;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static Color CorrelatedColorTemperatureToRGB(float kelvin)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Tan(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Atan(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Sqrt(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Abs(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Min(float a, float b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Min(int a, int b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Max(float a, float b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Max(int a, int b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Pow(float f, float p)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Ceil(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Floor(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Round(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int CeilToInt(float f)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Sign(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Clamp(float value, float min, float max)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Clamp(int value, int min, int max)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Clamp01(float value)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Lerp(float a, float b, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Approximately(float a, float b)
	{
		return false;
	}

	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
	{
		ret = default;
	}
}

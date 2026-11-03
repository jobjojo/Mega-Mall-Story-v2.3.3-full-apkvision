using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion
{
	public static bool EnableLegacyPngGammaRuntimeLoadBehavior
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeMethod(Name = "ImageConversionBindings::GetEnableLegacyPngGammaRuntimeLoadBehavior", IsFreeFunction = true, ThrowsException = false)]
	private static bool GetEnableLegacyPngGammaRuntimeLoadBehavior()
	{
		return false;
	}

	[NativeMethod(Name = "ImageConversionBindings::SetEnableLegacyPngGammaRuntimeLoadBehavior", IsFreeFunction = true, ThrowsException = false)]
	private static void SetEnableLegacyPngGammaRuntimeLoadBehavior(bool enable)
	{
	}

	[NativeMethod(Name = "ImageConversionBindings::EncodeToTGA", IsFreeFunction = true, ThrowsException = true)]
	public static byte[] EncodeToTGA(this Texture2D tex)
	{
		return null;
	}

	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = true, ThrowsException = true)]
	public static byte[] EncodeToPNG(this Texture2D tex)
	{
		return null;
	}

	[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = true, ThrowsException = true)]
	public static byte[] EncodeToJPG(this Texture2D tex, int quality)
	{
		return null;
	}

	public static byte[] EncodeToJPG(this Texture2D tex)
	{
		return null;
	}

	[NativeMethod(Name = "ImageConversionBindings::EncodeToEXR", IsFreeFunction = true, ThrowsException = true)]
	public static byte[] EncodeToEXR(this Texture2D tex, Texture2D.EXRFlags flags)
	{
		return null;
	}

	public static byte[] EncodeToEXR(this Texture2D tex)
	{
		return null;
	}

	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = true)]
	public static bool LoadImage([NotNull("ArgumentNullException")] this Texture2D tex, byte[] data, bool markNonReadable)
	{
		return false;
	}

	public static bool LoadImage(this Texture2D tex, byte[] data)
	{
		return false;
	}

	[FreeFunction("ImageConversionBindings::EncodeArrayToTGA", true)]
	public static byte[] EncodeArrayToTGA(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u)
	{
		return null;
	}

	[FreeFunction("ImageConversionBindings::EncodeArrayToPNG", true)]
	public static byte[] EncodeArrayToPNG(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u)
	{
		return null;
	}

	[FreeFunction("ImageConversionBindings::EncodeArrayToJPG", true)]
	public static byte[] EncodeArrayToJPG(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, int quality = 75)
	{
		return null;
	}

	[FreeFunction("ImageConversionBindings::EncodeArrayToEXR", true)]
	public static byte[] EncodeArrayToEXR(Array array, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, Texture2D.EXRFlags flags = Texture2D.EXRFlags.None)
	{
		return null;
	}

	public static NativeArray<byte> EncodeNativeArrayToTGA<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u) where T : struct
	{
		return default;
	}

	public static NativeArray<byte> EncodeNativeArrayToPNG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u) where T : struct
	{
		return default;
	}

	public static NativeArray<byte> EncodeNativeArrayToJPG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, int quality = 75) where T : struct
	{
		return default;
	}

	public static NativeArray<byte> EncodeNativeArrayToEXR<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, Texture2D.EXRFlags flags = Texture2D.EXRFlags.None) where T : struct
	{
		return default;
	}

	[FreeFunction("ImageConversionBindings::UnsafeEncodeNativeArrayToTGA", true)]
	private unsafe static void* UnsafeEncodeNativeArrayToTGA(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u)
	{
		return null;
	}

	[FreeFunction("ImageConversionBindings::UnsafeEncodeNativeArrayToPNG", true)]
	private unsafe static void* UnsafeEncodeNativeArrayToPNG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u)
	{
		return null;
	}

	[FreeFunction("ImageConversionBindings::UnsafeEncodeNativeArrayToJPG", true)]
	private unsafe static void* UnsafeEncodeNativeArrayToJPG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, int quality = 75)
	{
		return null;
	}

	[FreeFunction("ImageConversionBindings::UnsafeEncodeNativeArrayToEXR", true)]
	private unsafe static void* UnsafeEncodeNativeArrayToEXR(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes = 0u, Texture2D.EXRFlags flags = Texture2D.EXRFlags.None)
	{
		return null;
	}
}

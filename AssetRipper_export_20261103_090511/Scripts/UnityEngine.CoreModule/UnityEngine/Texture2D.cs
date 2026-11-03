using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[ExcludeFromPreset]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
public sealed class Texture2D : Texture
{
	[Flags]
	public enum EXRFlags
	{
		None = 0,
		OutputAsFloat = 1,
		CompressZIP = 2,
		CompressRLE = 4,
		CompressPIZ = 8
	}

	internal const int streamingMipmapsPriorityMin = -128;

	internal const int streamingMipmapsPriorityMax = 127;

	public TextureFormat format
	{
		[NativeName("GetTextureFormat")]
		get
		{
			return (TextureFormat)0;
		}
	}

	public bool ignoreMipmapLimit
	{
		[NativeName("IgnoreMipmapLimit")]
		get
		{
			return false;
		}
		[NativeName("SetIgnoreMipmapLimitAndReload")]
		set
		{
		}
	}

	public string mipmapLimitGroup
	{
		[NativeName("GetMipmapLimitGroupName")]
		get
		{
			return null;
		}
	}

	public int activeMipmapLimit
	{
		[NativeName("GetMipmapLimit")]
		get
		{
			return 0;
		}
	}

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D whiteTexture => null;

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D blackTexture => null;

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D redTexture => null;

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D grayTexture => null;

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D linearGrayTexture => null;

	[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
	public static Texture2D normalTexture => null;

	public override bool isReadable => false;

	[NativeName("VTOnly")]
	[NativeConditional("ENABLE_VIRTUALTEXTURING && UNITY_EDITOR")]
	public bool vtOnly => false;

	internal bool isPreProcessed => false;

	public bool streamingMipmaps => false;

	public int streamingMipmapsPriority => 0;

	public int requestedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = true)]
		get
		{
			return 0;
		}
		[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = true)]
		set
		{
		}
	}

	public int minimumMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = true)]
		get
		{
			return 0;
		}
		[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = true)]
		set
		{
		}
	}

	internal bool loadAllMips
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = true)]
		get
		{
			return false;
		}
		[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = true)]
		set
		{
		}
	}

	public int calculatedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int desiredMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int loadingMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int loadedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public void Compress(bool highQuality)
	{
	}

	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName)
	{
		return false;
	}

	private static void Internal_Create([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName)
	{
	}

	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
	{
	}

	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height)
	{
		return false;
	}

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color)
	{
	}

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y)
	{
		return default;
	}

	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v)
	{
		return default;
	}

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = true)]
	private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		return false;
	}

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = true)]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap)
	{
		return false;
	}

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = true)]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
	{
	}

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame)
	{
	}

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = true)]
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size)
	{
		return false;
	}

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = true)]
	private bool LoadRawTextureDataImplArray(byte[] data)
	{
		return false;
	}

	[FreeFunction(Name = "Texture2DScripting::SetPixelDataArray", HasExplicitThis = true, ThrowsException = true)]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0)
	{
		return false;
	}

	[FreeFunction(Name = "Texture2DScripting::SetPixelData", HasExplicitThis = true, ThrowsException = true)]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0)
	{
		return false;
	}

	private IntPtr GetWritableImageData(int frame)
	{
		return (IntPtr)0;
	}

	private ulong GetRawImageDataSize()
	{
		return 0uL;
	}

	[FreeFunction("Texture2DScripting::GenerateAtlas")]
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, [Out] Rect[] rect)
	{
	}

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = true)]
	public void ClearRequestedMipmapLevel()
	{
	}

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = true)]
	public bool IsRequestedMipmapLevelLoaded()
	{
		return false;
	}

	[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = true)]
	public void ClearMinimumMipmapLevel()
	{
	}

	[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = true)]
	public void UpdateExternalTexture(IntPtr nativeTex)
	{
	}

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = true, ThrowsException = true)]
	private void SetAllPixels32([Unmarshalled] Color32[] colors, int miplevel)
	{
	}

	[FreeFunction("Texture2DScripting::SetBlockOfPixels32", HasExplicitThis = true, ThrowsException = true)]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, [Unmarshalled] Color32[] colors, int miplevel)
	{
	}

	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = true, ThrowsException = true)]
	public byte[] GetRawTextureData()
	{
		return null;
	}

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = true, ThrowsException = true)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel)
	{
		return null;
	}

	[ExcludeFromDocs]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
	{
		return null;
	}

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = true, ThrowsException = true)]
	public Color32[] GetPixels32([DefaultValue("0")] int miplevel)
	{
		return null;
	}

	[ExcludeFromDocs]
	public Color32[] GetPixels32()
	{
		return null;
	}

	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = true)]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
	{
		return null;
	}

	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize)
	{
		return null;
	}

	public Rect[] PackTextures(Texture2D[] textures, int padding)
	{
		return null;
	}

	internal bool ValidateFormat(TextureFormat format, int width, int height)
	{
		return false;
	}

	internal bool ValidateFormat(GraphicsFormat format, int width, int height)
	{
		return false;
	}

	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags)
	{
	}

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear, [DefaultValue("false")] bool createUninitialized)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear, [DefaultValue("false")] bool createUninitialized, [DefaultValue("false")] bool ignoreMipmapLimit, [DefaultValue("null")] string mipmapLimitGroupName)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear)
	{
	}

	public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear, [DefaultValue("false")] bool createUninitialized)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
	{
	}

	[ExcludeFromDocs]
	public Texture2D(int width, int height)
	{
	}

	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex)
	{
		return null;
	}

	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color)
	{
	}

	public void SetPixel(int x, int y, Color color, [DefaultValue("0")] int mipLevel)
	{
	}

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors)
	{
	}

	public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels(Color[] colors)
	{
	}

	[ExcludeFromDocs]
	public Color GetPixel(int x, int y)
	{
		return default;
	}

	public Color GetPixel(int x, int y, [DefaultValue("0")] int mipLevel)
	{
		return default;
	}

	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v)
	{
		return default;
	}

	public Color GetPixelBilinear(float u, float v, [DefaultValue("0")] int mipLevel)
	{
		return default;
	}

	public void LoadRawTextureData(IntPtr data, int size)
	{
	}

	public void LoadRawTextureData(byte[] data)
	{
	}

	public void LoadRawTextureData<T>(NativeArray<T> data) where T : struct
	{
	}

	public void SetPixelData<T>(T[] data, int mipLevel, [DefaultValue("0")] int sourceDataStartIndex = 0)
	{
	}

	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, [DefaultValue("0")] int sourceDataStartIndex = 0) where T : struct
	{
	}

	public NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct
	{
		return default;
	}

	public NativeArray<T> GetRawTextureData<T>() where T : struct
	{
		return default;
	}

	public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
	{
	}

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps)
	{
	}

	[ExcludeFromDocs]
	public void Apply()
	{
	}

	public bool Reinitialize(int width, int height)
	{
		return false;
	}

	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
	{
		return false;
	}

	public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		return false;
	}

	[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", false)]
	public bool Resize(int width, int height)
	{
		return false;
	}

	[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", false)]
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap)
	{
		return false;
	}

	[Obsolete("Texture2D.Resize(int, int, GraphicsFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, GraphicsFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, [*] System.Boolean)", false)]
	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap)
	{
		return false;
	}

	public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
	{
	}

	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY)
	{
	}

	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results)
	{
		return false;
	}

	public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors)
	{
	}

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel)
	{
	}

	[ExcludeFromDocs]
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors)
	{
	}

	public Color[] GetPixels([DefaultValue("0")] int miplevel)
	{
		return null;
	}

	[ExcludeFromDocs]
	public Color[] GetPixels()
	{
		return null;
	}

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
	{
	}

	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret)
	{
		ret = default;
	}

	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret)
	{
		ret = default;
	}

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps)
	{
	}
}

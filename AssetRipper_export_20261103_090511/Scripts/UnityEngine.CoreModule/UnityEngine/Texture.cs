using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
public class Texture : Object
{
	public static readonly int GenerateAllMips;

	public int mipmapCount
	{
		[NativeName("GetMipmapCount")]
		get
		{
			return 0;
		}
	}

	public virtual int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool isReadable => false;

	public TextureWrapMode wrapMode
	{
		set
		{
		}
	}

	public FilterMode filterMode
	{
		get
		{
			return FilterMode.Point;
		}
		set
		{
		}
	}

	protected Texture()
	{
	}

	private int GetDataWidth()
	{
		return 0;
	}

	private int GetDataHeight()
	{
		return 0;
	}

	internal ulong GetPixelDataSize(int mipLevel, int element = 0)
	{
		return 0uL;
	}

	internal ulong GetPixelDataOffset(int mipLevel, int element = 0)
	{
		return 0uL;
	}

	internal TextureColorSpace GetTextureColorSpace(bool linear)
	{
		return TextureColorSpace.Linear;
	}

	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
	{
		return TextureColorSpace.Linear;
	}

	internal bool ValidateFormat(TextureFormat format)
	{
		return false;
	}

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage)
	{
		return false;
	}

	internal UnityException CreateNonReadableException(Texture t)
	{
		return null;
	}

	internal UnityException CreateNativeArrayLengthOverflowException()
	{
		return null;
	}
}

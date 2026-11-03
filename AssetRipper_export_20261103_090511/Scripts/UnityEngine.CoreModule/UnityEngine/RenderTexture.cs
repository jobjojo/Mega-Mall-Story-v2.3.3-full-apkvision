using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
public class RenderTexture : Texture
{
	public override int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public GraphicsFormat graphicsFormat
	{
		get
		{
			return GraphicsFormat.None;
		}
		set
		{
		}
	}

	public RenderTextureFormat format => RenderTextureFormat.ARGB32;

	public GraphicsFormat depthStencilFormat
	{
		set
		{
		}
	}

	public bool enableRandomWrite
	{
		set
		{
		}
	}

	public static RenderTexture active
	{
		set
		{
		}
	}

	public RenderTextureDescriptor descriptor => default;

	[NativeName("GetColorFormat")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings)
	{
		return GraphicsFormat.None;
	}

	[NativeName("SetColorFormat")]
	private void SetColorFormat(GraphicsFormat format)
	{
	}

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt)
	{
	}

	private void SetMipMapCount(int count)
	{
	}

	public void Release()
	{
	}

	internal void SetSRGBReadWrite(bool srgb)
	{
	}

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create([Writable] RenderTexture rt)
	{
	}

	[FreeFunction("RenderTextureSupportsStencil")]
	public static bool SupportsStencil(RenderTexture rt)
	{
		return false;
	}

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
	{
	}

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor()
	{
		return default;
	}

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
	{
		return null;
	}

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp)
	{
	}

	[RequiredByNativeCode]
	protected internal RenderTexture()
	{
	}

	public RenderTexture(RenderTextureDescriptor desc)
	{
	}

	public RenderTexture(RenderTexture textureToCopy)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
	{
	}

	public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth)
	{
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
	{
	}

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
	{
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
	{
		return GraphicsFormat.None;
	}

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
	{
	}

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth)
	{
		return GraphicsFormat.None;
	}

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
	{
		return GraphicsFormat.None;
	}

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc)
	{
		return null;
	}

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
	{
		return null;
	}

	public static RenderTexture GetTemporary(int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing, [DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [DefaultValue("false")] bool useDynamicScale)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
	{
		return null;
	}

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc)
	{
	}

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret)
	{
		ret = default;
	}

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc)
	{
		return null;
	}
}

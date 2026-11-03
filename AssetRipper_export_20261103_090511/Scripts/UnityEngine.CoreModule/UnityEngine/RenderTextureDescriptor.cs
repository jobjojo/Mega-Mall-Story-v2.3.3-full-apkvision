using System.Diagnostics;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine;

public struct RenderTextureDescriptor
{
	private GraphicsFormat _graphicsFormat = GraphicsFormat.None;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GraphicsFormat stencilFormat = GraphicsFormat.None;

	private RenderTextureCreationFlags _flags = (RenderTextureCreationFlags)0;

	public int width { get; set; } = 0;

	public int height { get; set; } = 0;

	public int msaaSamples { get; set; } = 0;

	public int volumeDepth { get; set; } = 0;

	public int mipCount { set; }

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

	public GraphicsFormat depthStencilFormat { get; set; } = GraphicsFormat.None;

	public int depthBufferBits
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public TextureDimension dimension { get; set; } = TextureDimension.None;

	public ShadowSamplingMode shadowSamplingMode { get; set; } = ShadowSamplingMode.CompareDepths;

	public VRTextureUsage vrUsage { set; }

	public RenderTextureMemoryless memoryless { set; }

	internal bool createdFromScript
	{
		set
		{
		}
	}

	public bool useDynamicScale
	{
		set
		{
		}
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
	{
	}

	[ExcludeFromDocs]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
	{
	}

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
	{
	}
}

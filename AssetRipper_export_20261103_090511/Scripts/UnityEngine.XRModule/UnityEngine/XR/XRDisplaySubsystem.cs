using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	public struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance;

		public int renderPassIndex;

		public RenderTargetIdentifier renderTarget;

		public RenderTextureDescriptor renderTargetDesc;

		public bool hasMotionVectorPass;

		public RenderTargetIdentifier motionVectorRenderTarget;

		public RenderTextureDescriptor motionVectorRenderTargetDesc;

		public bool shouldFillOutDepth;

		public int cullingPassIndex;

		public IntPtr foveatedRenderingInfo;
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public struct XRBlitParams
	{
		public RenderTexture srcTex;

		public int srcTexArraySlice;

		public Rect srcRect;

		public Rect destRect;

		public IntPtr foveatedRenderingInfo;

		public bool srcHdrEncoded;

		public ColorGamut srcHdrColorGamut;

		public int srcHdrMaxLuminance;
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance;

		public bool nativeBlitAvailable;

		public bool nativeBlitInvalidStates;

		public int blitParamsCount;
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<bool> displayFocusChanged;

	[RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus)
	{
	}
}

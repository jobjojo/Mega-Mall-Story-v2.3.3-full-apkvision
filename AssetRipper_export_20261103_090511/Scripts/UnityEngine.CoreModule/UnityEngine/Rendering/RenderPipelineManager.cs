using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

public static class RenderPipelineManager
{
	internal static RenderPipelineAsset s_CurrentPipelineAsset;

	private static List<Camera> s_Cameras;

	private static string s_CurrentPipelineType;

	private static RenderPipeline s_CurrentPipeline;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action activeRenderPipelineTypeChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action activeRenderPipelineCreated;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action activeRenderPipelineDisposed;

	public static RenderPipeline currentPipeline
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineTypeChanged()
	{
	}

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to)
	{
	}

	[RequiredByNativeCode]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
	{
	}

	[RequiredByNativeCode]
	internal static void CleanupRenderPipeline()
	{
	}

	[RequiredByNativeCode]
	private static string GetCurrentPipelineAssetType()
	{
		return null;
	}

	[RequiredByNativeCode]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest)
	{
	}

	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
	{
	}

	private static bool IsPipelineRequireCreation()
	{
		return false;
	}
}

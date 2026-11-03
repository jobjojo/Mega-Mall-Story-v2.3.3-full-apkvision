using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private static readonly ShaderTagId kRenderTypeTag;

	private IntPtr m_Ptr = (IntPtr)0;

	private void GetCameras_Internal(Type listType, object resultList)
	{
	}

	internal ScriptableRenderContext(IntPtr ptr)
	{
	}

	internal void GetCameras(List<Camera> results)
	{
	}

	public bool Equals(ScriptableRenderContext other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList)
	{
	}
}

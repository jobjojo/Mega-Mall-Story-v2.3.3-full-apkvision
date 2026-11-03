using System.Collections.Generic;

namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	public bool disposed { get; private set; }

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
	{
	}

	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
	{
	}

	internal void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}

using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Camera/CameraUtil.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
public sealed class GL
{
	[NativeName("ImmediateVertex")]
	public static void Vertex3(float x, float y, float z)
	{
	}

	public static void Vertex(Vector3 v)
	{
	}

	[NativeName("ImmediateTexCoordAll")]
	public static void TexCoord3(float x, float y, float z)
	{
	}

	public static void TexCoord2(float x, float y)
	{
	}

	[NativeName("ImmediateColor")]
	private static void ImmediateColor(float r, float g, float b, float a)
	{
	}

	public static void Color(Color c)
	{
	}

	[FreeFunction("GLPushMatrixScript")]
	public static void PushMatrix()
	{
	}

	[FreeFunction("GLPopMatrixScript")]
	public static void PopMatrix()
	{
	}

	[FreeFunction("GLLoadPixelMatrixScript")]
	public static void LoadPixelMatrix()
	{
	}

	[FreeFunction("GLBegin", ThrowsException = true)]
	public static void Begin(int mode)
	{
	}

	[FreeFunction("GLEnd")]
	public static void End()
	{
	}

	[FreeFunction]
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
	{
	}

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
	{
	}

	[FreeFunction("SetGLViewport")]
	public static void Viewport(Rect pixelRect)
	{
	}

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
	{
	}

	private static void Viewport_Injected(ref Rect pixelRect)
	{
	}
}

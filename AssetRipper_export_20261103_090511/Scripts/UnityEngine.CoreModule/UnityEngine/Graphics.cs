using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount;

	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts;

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = true)]
	private static int Internal_GetMaxDrawMeshInstanceCount()
	{
		return 0;
	}

	[FreeFunction("GraphicsScripting::DrawMeshNow")]
	private static void Internal_DrawMeshNow2([NotNull("NullExceptionObject")] Mesh mesh, int subsetIndex, Matrix4x4 matrix)
	{
	}

	[FreeFunction("GraphicsScripting::DrawTexture")]
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
	{
	}

	[FreeFunction("GraphicsScripting::BlitMultitap")]
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, [NotNull("ArgumentNullException")] Vector2[] offsets)
	{
	}

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit2(Texture source, RenderTexture dest)
	{
	}

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
	{
	}

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
	{
	}

	public static void Blit(Texture source, RenderTexture dest)
	{
	}

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
	{
	}

	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix)
	{
	}
}

using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
public sealed class Shader : Object
{
	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		get
		{
			return false;
		}
	}

	public int renderQueue
	{
		[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public static Shader Find(string name)
	{
		return null;
	}

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name)
	{
		return 0;
	}

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
	public static int PropertyToID(string name)
	{
		return 0;
	}

	private Shader()
	{
	}
}

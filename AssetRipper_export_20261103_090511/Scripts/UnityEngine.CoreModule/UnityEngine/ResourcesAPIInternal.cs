using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
internal static class ResourcesAPIInternal
{
	[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	public static Object[] FindObjectsOfTypeAll(Type type)
	{
		return null;
	}

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	public static Shader FindShaderByName(string name)
	{
		return null;
	}

	[NativeThrows]
	[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
	[FreeFunction("Resources_Bindings::Load")]
	public static Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance)
	{
		return null;
	}

	[FreeFunction("Scripting::UnloadAssetFromScripting")]
	public static void UnloadAsset(Object assetToUnload)
	{
	}
}

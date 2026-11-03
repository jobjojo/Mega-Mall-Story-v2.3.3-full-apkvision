using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
[VisibleToOtherModules]
internal class NativeTypeAttribute : Attribute
{
	public string Header { set; }

	public string IntermediateScriptingStructName { set; }

	public CodegenOptions CodegenOptions { set; }

	public NativeTypeAttribute()
	{
	}

	public NativeTypeAttribute(CodegenOptions codegenOptions)
	{
	}

	public NativeTypeAttribute(string header)
	{
	}

	public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
	{
	}
}

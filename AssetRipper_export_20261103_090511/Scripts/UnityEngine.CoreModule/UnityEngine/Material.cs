using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : Object
{
	public Shader shader => null;

	public Texture mainTexture
	{
		set
		{
		}
	}

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader)
	{
	}

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source)
	{
	}

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString([Writable] Material self)
	{
	}

	public Material(Shader shader)
	{
	}

	[RequiredByNativeCode]
	public Material(Material source)
	{
	}

	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Material(string contents)
	{
	}

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
	{
		return 0;
	}

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
	public bool SetPass(int pass)
	{
		return false;
	}

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value)
	{
	}

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value)
	{
	}

	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value)
	{
	}

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value)
	{
	}

	[NativeName("SetBufferFromScript")]
	private void SetBufferImpl(int name, ComputeBuffer value)
	{
	}

	public void SetInt(string name, int value)
	{
	}

	public void SetFloat(string name, float value)
	{
	}

	public void SetColor(string name, Color value)
	{
	}

	public void SetVector(string name, Vector4 value)
	{
	}

	public void SetMatrix(string name, Matrix4x4 value)
	{
	}

	public void SetTexture(string name, Texture value)
	{
	}

	public void SetTexture(int nameID, Texture value)
	{
	}

	public void SetBuffer(string name, ComputeBuffer value)
	{
	}

	private void SetColorImpl_Injected(int name, ref Color value)
	{
	}

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
	{
	}
}

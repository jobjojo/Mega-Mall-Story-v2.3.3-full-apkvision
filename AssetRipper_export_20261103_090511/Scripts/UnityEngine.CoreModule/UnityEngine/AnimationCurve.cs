using System;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
[DefaultMember("Item")]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	internal IntPtr m_Ptr;

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = true)]
	private static IntPtr Internal_Create(Keyframe[] keys)
	{
		return (IntPtr)0;
	}

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = true, IsThreadSafe = true)]
	private bool Internal_Equals(IntPtr other)
	{
		return false;
	}

	~AnimationCurve()
	{
	}

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = true, IsThreadSafe = true)]
	public override int GetHashCode()
	{
		return 0;
	}

	public AnimationCurve(params Keyframe[] keys)
	{
	}

	[RequiredByNativeCode]
	public AnimationCurve()
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public bool Equals(AnimationCurve other)
	{
		return false;
	}
}

using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
public class Gradient : IEquatable<Gradient>
{
	internal IntPtr m_Ptr;

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
	private static IntPtr Init()
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
	private void Cleanup()
	{
	}

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
	private bool Internal_Equals(IntPtr other)
	{
		return false;
	}

	[RequiredByNativeCode]
	public Gradient()
	{
	}

	~Gradient()
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public bool Equals(Gradient other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

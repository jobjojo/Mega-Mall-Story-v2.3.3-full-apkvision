using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[StructLayout((LayoutKind)0)]
[UsedByNativeCode]
[NativeHeader("Modules/IMGUI/GUIStyle.h")]
public class RectOffset : IFormattable
{
	[NonSerialized]
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr;

	private readonly object m_SourceStyle;

	[NativeProperty("left", false, TargetType.Field)]
	public int left => 0;

	[NativeProperty("right", false, TargetType.Field)]
	public int right => 0;

	[NativeProperty("top", false, TargetType.Field)]
	public int top => 0;

	[NativeProperty("bottom", false, TargetType.Field)]
	public int bottom => 0;

	public int horizontal => 0;

	public int vertical => 0;

	public RectOffset()
	{
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	internal RectOffset(object sourceStyle, IntPtr source)
	{
	}

	~RectOffset()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	private void Destroy()
	{
	}

	[ThreadAndSerializationSafe]
	private static IntPtr InternalCreate()
	{
		return (IntPtr)0;
	}

	[ThreadAndSerializationSafe]
	private static void InternalDestroy(IntPtr ptr)
	{
	}

	public Rect Remove(Rect rect)
	{
		return default;
	}

	private void Remove_Injected(ref Rect rect, out Rect ret)
	{
		ret = default;
	}
}

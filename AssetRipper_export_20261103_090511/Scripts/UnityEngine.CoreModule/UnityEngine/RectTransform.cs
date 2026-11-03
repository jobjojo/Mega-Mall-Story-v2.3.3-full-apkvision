using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeClass("UI::RectTransform")]
public sealed class RectTransform : Transform
{
	public delegate void ReapplyDrivenProperties(RectTransform driven);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static ReapplyDrivenProperties reapplyDrivenProperties;

	[RequiredByNativeCode]
	internal static void SendReapplyDrivenProperties(RectTransform driven)
	{
	}
}

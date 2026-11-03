using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
public sealed class Font : Object
{
	public delegate void FontTextureRebuildCallback();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<Font> textureRebuilt;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback;

	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font)
	{
	}

	public bool HasCharacter(char c)
	{
		return false;
	}

	private bool HasCharacter(int c)
	{
		return false;
	}

	private static void Internal_CreateFont([Writable] Font self, string name)
	{
	}
}

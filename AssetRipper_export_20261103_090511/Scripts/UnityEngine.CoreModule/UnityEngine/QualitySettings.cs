using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
public sealed class QualitySettings : Object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<int, int> activeQualityLevelChanged;

	public static int vSyncCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int antiAliasing => 0;

	[NativeProperty("QualitySettingsNames")]
	public static string[] names => null;

	public static ColorSpace activeColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
		get
		{
			return ColorSpace.Gamma;
		}
	}

	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
	{
	}

	[NativeName("GetCurrentIndex")]
	public static int GetQualityLevel()
	{
		return 0;
	}
}

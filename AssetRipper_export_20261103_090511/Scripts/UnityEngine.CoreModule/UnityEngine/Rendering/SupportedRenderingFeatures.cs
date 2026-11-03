using System;
using System.Diagnostics;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures
{
	[Flags]
	public enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1
	}

	[Flags]
	public enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4
	}

	private static SupportedRenderingFeatures s_Active;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ReflectionProbeModes reflectionProbeModes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool lightProbeProxyVolumes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool motionVectors;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool receiveShadows;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool reflectionProbes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool reflectionProbesBlendDistance;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool rendererPriority;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesEnvironmentLighting;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesFog;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesRealtimeReflectionProbes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesOtherLightingSettings;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool editableMaterialRenderQueue;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesLODBias;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesMaximumLODLevel;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesEnableLODCrossFade;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool rendererProbes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool particleSystemInstancing;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool overridesShadowmask;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool supportsHDR;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string overridesLightProbeSystemWarningMessage;

	public static SupportedRenderingFeatures active
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LightmapMixedBakeModes defaultMixedLightingModes { get; }

	public LightmapMixedBakeModes mixedLightingModes { get; }

	public LightmapBakeType lightmapBakeTypes { get; }

	public LightmapsMode lightmapsModes { get; }

	[Obsolete("Bake with the Progressive Lightmapper. The backend that uses Enlighten to bake is deprecated.", false)]
	public bool enlightenLightmapper { get; }

	public bool enlighten { get; }

	public bool rendersUIOverlay { get; }

	public bool autoAmbientProbeBaking { get; }

	public bool autoDefaultReflectionProbeBaking { get; }

	public bool overridesLightProbeSystem { get; }

	[RequiredByNativeCode]
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
	{
	}

	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
	{
	}

	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr)
	{
	}

	[RequiredByNativeCode]
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
	{
	}
}

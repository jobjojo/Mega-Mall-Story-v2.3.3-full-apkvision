using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
public sealed class SystemInfo
{
	public static OperatingSystemFamily operatingSystemFamily => OperatingSystemFamily.Other;

	public static int processorCount => 0;

	public static string deviceName => null;

	public static string deviceModel => null;

	public static DeviceType deviceType => DeviceType.Unknown;

	[Obsolete("supportsImageEffects always returns true, no need to call it")]
	public static bool supportsImageEffects => false;

	private static bool IsValidEnumValue(Enum value)
	{
		return false;
	}

	public static bool SupportsTextureFormat(TextureFormat format)
	{
		return false;
	}

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily()
	{
		return OperatingSystemFamily.Other;
	}

	[FreeFunction("systeminfo::GetProcessorCount")]
	private static int GetProcessorCount()
	{
		return 0;
	}

	[FreeFunction("systeminfo::GetDeviceName")]
	private static string GetDeviceName()
	{
		return null;
	}

	[FreeFunction("systeminfo::GetDeviceModel")]
	private static string GetDeviceModel()
	{
		return null;
	}

	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType()
	{
		return DeviceType.Unknown;
	}

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format)
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
	{
		return false;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
	{
		return GraphicsFormat.None;
	}

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
	{
		return GraphicsFormat.None;
	}
}

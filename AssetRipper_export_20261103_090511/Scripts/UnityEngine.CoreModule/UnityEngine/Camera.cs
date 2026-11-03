using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
public sealed class Camera : Behaviour
{
	public enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2
	}

	public delegate void CameraCallback(Camera cam);

	public const float kMinAperture = 0.7f;

	public const float kMaxAperture = 32f;

	public const int kMinBladeCount = 3;

	public const int kMaxBladeCount = 11;

	public static CameraCallback onPreCull;

	public static CameraCallback onPreRender;

	public static CameraCallback onPostRender;

	[NativeProperty("Near")]
	public float nearClipPlane => 0f;

	[NativeProperty("Far")]
	public float farClipPlane => 0f;

	public float orthographicSize
	{
		set
		{
		}
	}

	public float depth
	{
		set
		{
		}
	}

	public int cullingMask => 0;

	public int eventMask => 0;

	public Color backgroundColor
	{
		set
		{
		}
	}

	public CameraClearFlags clearFlags
	{
		get
		{
			return (CameraClearFlags)0;
		}
		set
		{
		}
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		set
		{
		}
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect => default;

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
		get
		{
			return 0;
		}
	}

	public RenderTexture targetTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int targetDisplay => 0;

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		get
		{
			return null;
		}
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		get
		{
			return false;
		}
	}

	public static int allCamerasCount => 0;

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
	{
		return default;
	}

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
	{
		return default;
	}

	public Ray ScreenPointToRay(Vector3 pos)
	{
		return default;
	}

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount()
	{
		return 0;
	}

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl([Out][NotNull("ArgumentNullException")] Camera[] cam)
	{
		return 0;
	}

	public static int GetAllCameras(Camera[] cameras)
	{
		return 0;
	}

	[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
	public void Render()
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam)
	{
	}

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam)
	{
	}

	[SpecialName]
	private void set_backgroundColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private void set_rect_Injected(ref Rect value)
	{
	}

	[SpecialName]
	private void get_pixelRect_Injected(out Rect ret)
	{
		ret = default;
	}

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
	{
		ret = default;
	}
}

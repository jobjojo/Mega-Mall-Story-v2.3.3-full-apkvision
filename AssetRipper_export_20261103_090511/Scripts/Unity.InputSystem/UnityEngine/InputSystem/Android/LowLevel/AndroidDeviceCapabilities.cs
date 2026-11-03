using System;

namespace UnityEngine.InputSystem.Android.LowLevel;

[Serializable]
internal struct AndroidDeviceCapabilities
{
	public string deviceDescriptor;

	public int productId;

	public int vendorId;

	public bool isVirtual;

	public AndroidAxis[] motionAxes;

	public AndroidInputSource inputSources;

	public string ToJson()
	{
		return null;
	}

	public static AndroidDeviceCapabilities FromJson(string json)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}

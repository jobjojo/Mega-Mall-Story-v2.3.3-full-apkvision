using System;

namespace UnityEngine.InputSystem.Android.LowLevel;

[Serializable]
internal struct AndroidSensorCapabilities
{
	public AndroidSensorType sensorType;

	public string ToJson()
	{
		return null;
	}

	public static AndroidSensorCapabilities FromJson(string json)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}

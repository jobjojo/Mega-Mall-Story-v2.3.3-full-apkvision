using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Android.LowLevel;

internal struct AndroidSensorState : IInputStateTypeInfo
{
	public static FourCC kFormat;

	[InputControl(name = "rate", layout = "Axis", variants = "HeartRate")]
	[InputControl(name = "stepCounter", layout = "Integer", variants = "StepCounter")]
	[InputControl(name = "ambientTemperature", layout = "Axis", variants = "AmbientTemperature")]
	[InputControl(name = "relativeHumidity", layout = "Axis", variants = "RelativeHumidity")]
	[InputControl(name = "attitude", layout = "Quaternion", processors = "AndroidCompensateRotation", variants = "RotationVector")]
	[InputControl(name = "acceleration", layout = "Vector3", processors = "AndroidCompensateDirection", variants = "LinearAcceleration")]
	[InputControl(name = "rotation", layout = "Quaternion", processors = "AndroidCompensateRotation", variants = "GeomagneticRotationVector")]
	[InputControl(name = "distance", layout = "Axis", variants = "Proximity")]
	[InputControl(name = "gravity", layout = "Vector3", processors = "AndroidCompensateDirection", variants = "Gravity")]
	[InputControl(name = "acceleration", layout = "Vector3", processors = "AndroidCompensateDirection", variants = "Accelerometer")]
	[InputControl(name = "atmosphericPressure", layout = "Axis", variants = "Pressure")]
	[InputControl(name = "angularVelocity", layout = "Vector3", processors = "CompensateDirection", variants = "Gyroscope")]
	[InputControl(name = "lightLevel", layout = "Axis", variants = "Light")]
	[InputControl(name = "magneticField", layout = "Vector3", variants = "MagneticField")]
	public unsafe fixed float data[16];

	public FourCC format => default;

	public AndroidSensorState WithData(params float[] data)
	{
		return default;
	}
}

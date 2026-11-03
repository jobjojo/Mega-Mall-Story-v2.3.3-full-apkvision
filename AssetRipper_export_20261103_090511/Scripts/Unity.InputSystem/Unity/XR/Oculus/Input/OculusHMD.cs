using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset", hideInUI = true)]
public class OculusHMD : XRHMD
{
	[InputControl]
	[InputControl(name = "isTracked", layout = "Button", aliases = new string[] { "deviceistracked" })]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new string[] { "devicetrackingstate" })]
	public ButtonControl userPresence { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAngularAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAngularAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAcceleration { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAngularAcceleration { get; private set; }

	protected override void FinishSetup()
	{
	}
}

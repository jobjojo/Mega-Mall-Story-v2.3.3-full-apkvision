using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "OpenVR Headset", hideInUI = true)]
public class OpenVRHMD : XRHMD
{
	[InputControl(noisy = true)]
	public Vector3Control deviceVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control leftEyeAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control rightEyeAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control centerEyeAngularVelocity { get; private set; }

	protected override void FinishSetup()
	{
	}
}

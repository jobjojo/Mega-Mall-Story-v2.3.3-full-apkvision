using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Oculus Touch Controller (OpenVR)", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
public class OpenVROculusTouchController : XRControllerWithRumble
{
	[InputControl]
	public Vector2Control thumbstick { get; private set; }

	[InputControl]
	public AxisControl trigger { get; private set; }

	[InputControl]
	public AxisControl grip { get; private set; }

	[InputControl(aliases = new string[] { "Alternate" })]
	public ButtonControl primaryButton { get; private set; }

	[InputControl(aliases = new string[] { "Primary" })]
	public ButtonControl secondaryButton { get; private set; }

	[InputControl]
	public ButtonControl gripPressed { get; private set; }

	[InputControl]
	public ButtonControl triggerPressed { get; private set; }

	[InputControl(aliases = new string[] { "primary2DAxisClicked" })]
	public ButtonControl thumbstickClicked { get; private set; }

	[InputControl(aliases = new string[] { "primary2DAxisTouch" })]
	public ButtonControl thumbstickTouched { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularVelocity { get; private set; }

	protected override void FinishSetup()
	{
	}
}

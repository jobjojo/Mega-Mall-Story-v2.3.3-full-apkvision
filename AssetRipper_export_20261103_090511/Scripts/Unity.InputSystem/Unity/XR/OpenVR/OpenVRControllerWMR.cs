using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.OpenVR;

[InputControlLayout(displayName = "Windows MR Controller (OpenVR)", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
public class OpenVRControllerWMR : XRController
{
	[InputControl(noisy = true)]
	public Vector3Control deviceVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAngularVelocity { get; private set; }

	[InputControl(aliases = new string[] { "primary2DAxisClick", "joystickOrPadPressed" })]
	public ButtonControl touchpadClick { get; private set; }

	[InputControl(aliases = new string[] { "primary2DAxisTouch", "joystickOrPadTouched" })]
	public ButtonControl touchpadTouch { get; private set; }

	[InputControl]
	public ButtonControl gripPressed { get; private set; }

	[InputControl]
	public ButtonControl triggerPressed { get; private set; }

	[InputControl(aliases = new string[] { "primary" })]
	public ButtonControl menu { get; private set; }

	[InputControl]
	public AxisControl trigger { get; private set; }

	[InputControl]
	public AxisControl grip { get; private set; }

	[InputControl(aliases = new string[] { "secondary2DAxis" })]
	public Vector2Control touchpad { get; private set; }

	[InputControl(aliases = new string[] { "primary2DAxis" })]
	public Vector2Control joystick { get; private set; }

	protected override void FinishSetup()
	{
	}
}

using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout(displayName = "Windows MR Controller", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
public class WMRSpatialController : XRControllerWithRumble
{
	[InputControl(aliases = new string[] { "Primary2DAxis", "thumbstickaxes" })]
	public Vector2Control joystick { get; private set; }

	[InputControl(aliases = new string[] { "Secondary2DAxis", "touchpadaxes" })]
	public Vector2Control touchpad { get; private set; }

	[InputControl(aliases = new string[] { "gripaxis" })]
	public AxisControl grip { get; private set; }

	[InputControl(aliases = new string[] { "gripbutton" })]
	public ButtonControl gripPressed { get; private set; }

	[InputControl(aliases = new string[] { "Primary", "menubutton" })]
	public ButtonControl menu { get; private set; }

	[InputControl(aliases = new string[] { "triggeraxis" })]
	public AxisControl trigger { get; private set; }

	[InputControl(aliases = new string[] { "triggerbutton" })]
	public ButtonControl triggerPressed { get; private set; }

	[InputControl(aliases = new string[] { "thumbstickpressed" })]
	public ButtonControl joystickClicked { get; private set; }

	[InputControl(aliases = new string[] { "joystickorpadpressed", "touchpadpressed" })]
	public ButtonControl touchpadClicked { get; private set; }

	[InputControl(aliases = new string[] { "joystickorpadtouched", "touchpadtouched" })]
	public ButtonControl touchpadTouched { get; private set; }

	[InputControl(noisy = true, aliases = new string[] { "gripVelocity" })]
	public Vector3Control deviceVelocity { get; private set; }

	[InputControl(noisy = true, aliases = new string[] { "gripAngularVelocity" })]
	public Vector3Control deviceAngularVelocity { get; private set; }

	[InputControl(noisy = true)]
	public AxisControl batteryLevel { get; private set; }

	[InputControl(noisy = true)]
	public AxisControl sourceLossRisk { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control sourceLossMitigationDirection { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control pointerPosition { get; private set; }

	[InputControl(noisy = true, aliases = new string[] { "PointerOrientation" })]
	public QuaternionControl pointerRotation { get; private set; }

	protected override void FinishSetup()
	{
	}
}

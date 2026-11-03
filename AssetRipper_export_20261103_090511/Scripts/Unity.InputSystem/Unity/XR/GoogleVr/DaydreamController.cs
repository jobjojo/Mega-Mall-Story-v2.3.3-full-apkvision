using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;

namespace Unity.XR.GoogleVr;

[InputControlLayout(displayName = "Daydream Controller", commonUsages = new string[] { "LeftHand", "RightHand" }, hideInUI = true)]
public class DaydreamController : XRController
{
	[InputControl]
	public Vector2Control touchpad { get; private set; }

	[InputControl]
	public ButtonControl volumeUp { get; private set; }

	[InputControl]
	public ButtonControl recentered { get; private set; }

	[InputControl]
	public ButtonControl volumeDown { get; private set; }

	[InputControl]
	public ButtonControl recentering { get; private set; }

	[InputControl]
	public ButtonControl app { get; private set; }

	[InputControl]
	public ButtonControl home { get; private set; }

	[InputControl]
	public ButtonControl touchpadClicked { get; private set; }

	[InputControl]
	public ButtonControl touchpadTouched { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceVelocity { get; private set; }

	[InputControl(noisy = true)]
	public Vector3Control deviceAcceleration { get; private set; }

	protected override void FinishSetup()
	{
	}
}

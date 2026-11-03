using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Remote", hideInUI = true)]
public class OculusRemote : InputDevice
{
	[InputControl]
	public ButtonControl back { get; private set; }

	[InputControl]
	public ButtonControl start { get; private set; }

	[InputControl]
	public Vector2Control touchpad { get; private set; }

	protected override void FinishSetup()
	{
	}
}

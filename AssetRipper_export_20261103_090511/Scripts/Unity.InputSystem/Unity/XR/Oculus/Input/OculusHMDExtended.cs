using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Unity.XR.Oculus.Input;

[InputControlLayout(displayName = "Oculus Headset (w/ on-headset controls)", hideInUI = true)]
public class OculusHMDExtended : OculusHMD
{
	[InputControl]
	public ButtonControl back { get; private set; }

	[InputControl]
	public Vector2Control touchpad { get; private set; }

	protected override void FinishSetup()
	{
	}
}

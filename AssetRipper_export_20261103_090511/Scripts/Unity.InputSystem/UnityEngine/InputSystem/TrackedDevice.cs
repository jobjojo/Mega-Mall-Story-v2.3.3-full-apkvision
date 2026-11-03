using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Tracked Device", isGenericTypeOfDevice = true)]
public class TrackedDevice : InputDevice
{
	[InputControl(synthetic = true)]
	public IntegerControl trackingState { get; private set; }

	[InputControl(synthetic = true)]
	public ButtonControl isTracked { get; private set; }

	[InputControl(noisy = true, dontReset = true)]
	public Vector3Control devicePosition { get; private set; }

	[InputControl(noisy = true, dontReset = true)]
	public QuaternionControl deviceRotation { get; private set; }

	protected override void FinishSetup()
	{
	}
}

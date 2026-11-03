using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.XR;

[Preserve]
[InputControlLayout(stateType = typeof(PoseState))]
public class PoseControl : InputControl<PoseState>
{
	public ButtonControl isTracked { get; private set; }

	public IntegerControl trackingState { get; private set; }

	public Vector3Control position { get; private set; }

	public QuaternionControl rotation { get; private set; }

	public Vector3Control velocity { get; private set; }

	public Vector3Control angularVelocity { get; private set; }

	protected override void FinishSetup()
	{
	}

	public unsafe override PoseState ReadUnprocessedValueFromState(void* statePtr)
	{
		return default;
	}

	public unsafe override void WriteValueIntoState(PoseState value, void* statePtr)
	{
	}
}

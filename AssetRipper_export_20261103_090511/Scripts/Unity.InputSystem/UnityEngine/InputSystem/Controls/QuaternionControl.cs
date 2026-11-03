using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.Controls;

public class QuaternionControl : InputControl<Quaternion>
{
	[InputControl(displayName = "X")]
	public AxisControl x { get; private set; }

	[InputControl(displayName = "Y")]
	public AxisControl y { get; private set; }

	[InputControl(displayName = "Z")]
	public AxisControl z { get; private set; }

	[InputControl(displayName = "W")]
	public AxisControl w { get; private set; }

	protected override void FinishSetup()
	{
	}

	public unsafe override Quaternion ReadUnprocessedValueFromState(void* statePtr)
	{
		return default;
	}

	public unsafe override void WriteValueIntoState(Quaternion value, void* statePtr)
	{
	}
}

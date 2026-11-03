namespace UnityEngine.InputSystem.Controls;

public class IntegerControl : InputControl<int>
{
	public unsafe override int ReadUnprocessedValueFromState(void* statePtr)
	{
		return 0;
	}

	public unsafe override void WriteValueIntoState(int value, void* statePtr)
	{
	}
}

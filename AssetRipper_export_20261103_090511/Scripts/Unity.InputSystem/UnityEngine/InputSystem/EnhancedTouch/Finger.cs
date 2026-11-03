using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch;

public class Finger
{
	internal readonly InputStateHistory<TouchState> m_StateHistory;

	public Touchscreen screen { get; }

	public int index { get; }

	public bool isActive => false;

	public Vector2 screenPosition => default;

	public Touch lastTouch => default;

	public Touch currentTouch => default;

	public TouchHistory touchHistory => default;

	internal Finger(Touchscreen screen, int index, InputUpdateType updateMask)
	{
	}

	private static bool ShouldRecordTouch(InputControl control, double time, InputEventPtr eventPtr)
	{
		return false;
	}

	private void OnTouchRecorded(InputStateHistory.Record record)
	{
	}

	private Touch FindTouch(uint uniqueId)
	{
		return default;
	}

	internal TouchHistory GetTouchHistory(Touch touch)
	{
		return default;
	}
}

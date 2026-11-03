namespace UnityEngine;

internal struct SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null)
{
	private readonly Rect position = default;

	private readonly float currentValue = 0f;

	private readonly float size = 0f;

	private readonly float start = 0f;

	private readonly float end = 0f;

	private readonly GUIStyle slider = null;

	private readonly GUIStyle thumb = null;

	private readonly GUIStyle thumbExtent = null;

	private readonly bool horiz = false;

	private readonly int id = 0;

	public float Handle()
	{
		return 0f;
	}

	private float OnMouseDown()
	{
		return 0f;
	}

	private float OnMouseDrag()
	{
		return 0f;
	}

	private float OnMouseUp()
	{
		return 0f;
	}

	private float OnRepaint()
	{
		return 0f;
	}

	private EventType CurrentEventType()
	{
		return EventType.MouseDown;
	}

	private int CurrentScrollTroughSide()
	{
		return 0;
	}

	private bool IsEmptySlider()
	{
		return false;
	}

	private bool SupportsPageMovements()
	{
		return false;
	}

	private float PageMovementValue()
	{
		return 0f;
	}

	private float PageUpMovementBound()
	{
		return 0f;
	}

	private Event CurrentEvent()
	{
		return null;
	}

	private float ValueForCurrentMousePosition()
	{
		return 0f;
	}

	private float Clamp(float value)
	{
		return 0f;
	}

	private Rect ThumbSelectionRect()
	{
		return default;
	}

	private void StartDraggingWithValue(float dragStartValue)
	{
	}

	private SliderState SliderState()
	{
		return null;
	}

	private Rect ThumbExtRect()
	{
		return default;
	}

	private Rect ThumbRect()
	{
		return default;
	}

	private Rect VerticalThumbRect()
	{
		return default;
	}

	private Rect HorizontalThumbRect()
	{
		return default;
	}

	private float ClampedCurrentValue()
	{
		return 0f;
	}

	private float MousePosition()
	{
		return 0f;
	}

	private float ValuesPerPixel()
	{
		return 0f;
	}

	private float ThumbSize()
	{
		return 0f;
	}

	private float MaxValue()
	{
		return 0f;
	}

	private float MinValue()
	{
		return 0f;
	}
}

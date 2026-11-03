using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

internal struct PointerState : IInputStateTypeInfo
{
	private uint pointerId;

	[InputControl(layout = "Vector2", displayName = "Position", usage = "Point", dontReset = true)]
	public Vector2 position;

	[InputControl(layout = "Delta", displayName = "Delta", usage = "Secondary2DMotion")]
	public Vector2 delta;

	[InputControl(layout = "Analog", displayName = "Pressure", usage = "Pressure", defaultState = -1.7E-44f)]
	public float pressure;

	[InputControl(layout = "Vector2", displayName = "Radius", usage = "Radius")]
	public Vector2 radius;

	[InputControl(name = "press", displayName = "Press", layout = "Button", format = "BIT", bit = 0u)]
	public ushort buttons;

	public static FourCC kFormat => default;

	public FourCC format => default;
}

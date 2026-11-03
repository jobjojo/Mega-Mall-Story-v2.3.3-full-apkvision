using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 12)]
internal struct QuerySamplingFrequencyCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 12;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public float frequency;

	public static FourCC Type => default;

	public FourCC typeStatic => default;

	public static QuerySamplingFrequencyCommand Create()
	{
		return default;
	}
}

using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)2, Size = 9)]
internal struct UseWindowsGamingInputCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 9;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte enable;

	public static FourCC Type => default;

	public FourCC typeStatic => default;

	public static UseWindowsGamingInputCommand Create(bool enable)
	{
		return default;
	}
}

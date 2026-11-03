namespace UnityEngine.InputSystem.XR.Haptics;

public struct HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize)
{
	public uint numChannels { get; private set; } = 0u;

	public uint frequencyHz { get; private set; } = 0u;

	public uint maxBufferSize { get; private set; } = 0u;
}

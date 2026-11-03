namespace UnityEngine.InputSystem.XR.Haptics;

public struct BufferedRumble
{
	public HapticCapabilities capabilities { get; private set; } = default;

	private InputDevice device { get; set; } = null;

	public BufferedRumble(InputDevice device)
	{
	}

	public void EnqueueRumble(byte[] samples)
	{
	}
}

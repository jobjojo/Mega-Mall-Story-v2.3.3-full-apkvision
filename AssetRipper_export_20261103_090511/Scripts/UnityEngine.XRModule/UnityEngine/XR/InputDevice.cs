using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	private ulong m_DeviceId = 0uL;

	private bool m_Initialized = false;

	private ulong deviceId => 0uL;

	internal InputDevice(ulong deviceId)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(InputDevice other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

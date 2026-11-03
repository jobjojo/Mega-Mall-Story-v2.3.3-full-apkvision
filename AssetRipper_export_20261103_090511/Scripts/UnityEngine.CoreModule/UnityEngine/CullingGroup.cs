using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup
{
	public delegate void StateChanged(CullingGroupEvent sphere);

	internal IntPtr m_Ptr;

	private StateChanged m_OnStateChanged;

	[RequiredByNativeCode]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
	{
	}
}

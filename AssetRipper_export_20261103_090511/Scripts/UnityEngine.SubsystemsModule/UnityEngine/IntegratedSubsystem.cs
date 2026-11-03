using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[UsedByNativeCode]
[NativeHeader("Modules/Subsystems/Subsystem.h")]
public class IntegratedSubsystem
{
	internal IntPtr m_Ptr;

	internal ISubsystemDescriptor m_SubsystemDescriptor;

	internal void SetHandle(IntegratedSubsystem subsystem)
	{
	}
}
[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem where TSubsystemDescriptor : ISubsystemDescriptor
{
}

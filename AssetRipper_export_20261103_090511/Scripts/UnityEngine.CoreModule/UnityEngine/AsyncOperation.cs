using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction
{
	internal IntPtr m_Ptr;

	private Action<AsyncOperation> m_completeCallback;

	[NativeMethod(IsThreadSafe = true)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
	private static void InternalDestroy(IntPtr ptr)
	{
	}

	~AsyncOperation()
	{
	}

	[RequiredByNativeCode]
	internal void InvokeCompletionEvent()
	{
	}
}

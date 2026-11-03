using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[StaticAccessor("GetObjectDispatcher()", StaticAccessorType.Dot)]
[RequiredByNativeCode]
internal sealed class ObjectDispatcher
{
	private IntPtr m_Ptr;

	private static Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch;

	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch;
}

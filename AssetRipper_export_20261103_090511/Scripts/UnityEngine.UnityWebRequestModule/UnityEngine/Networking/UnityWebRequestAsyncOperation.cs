using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation
{
	internal UnityWebRequest webRequest { set; }
}

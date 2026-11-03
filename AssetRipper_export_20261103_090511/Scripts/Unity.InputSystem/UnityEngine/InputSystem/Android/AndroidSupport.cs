using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Android;

internal class AndroidSupport
{
	internal const string kAndroidInterface = "Android";

	public static void Initialize()
	{
	}

	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate)
	{
		return null;
	}
}

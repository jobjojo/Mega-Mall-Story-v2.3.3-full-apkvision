using System.ComponentModel;
using UnityEngine.InputSystem.Processors;

namespace UnityEngine.InputSystem.Android.LowLevel;

[DesignTimeVisible(false)]
internal class AndroidCompensateRotationProcessor : CompensateRotationProcessor
{
	public override Quaternion Process(Quaternion value, InputControl control)
	{
		return default;
	}
}

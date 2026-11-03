using System.ComponentModel;
using UnityEngine.Scripting;

namespace UnityEngine.InputSystem.Processors;

[Preserve]
[DesignTimeVisible(false)]
internal class CompensateDirectionProcessor : InputProcessor<Vector3>
{
	public override Vector3 Process(Vector3 value, InputControl control)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}

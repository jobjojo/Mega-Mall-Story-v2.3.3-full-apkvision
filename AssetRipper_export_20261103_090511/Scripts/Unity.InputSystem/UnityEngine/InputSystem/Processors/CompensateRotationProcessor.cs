using System.ComponentModel;

namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(false)]
internal class CompensateRotationProcessor : InputProcessor<Quaternion>
{
	public override Quaternion Process(Quaternion value, InputControl control)
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}
}

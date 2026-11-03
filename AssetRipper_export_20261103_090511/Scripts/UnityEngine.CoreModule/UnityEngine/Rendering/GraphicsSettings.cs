using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
public sealed class GraphicsSettings : Object
{
	public static bool lightsUseLinearIntensity => false;
}

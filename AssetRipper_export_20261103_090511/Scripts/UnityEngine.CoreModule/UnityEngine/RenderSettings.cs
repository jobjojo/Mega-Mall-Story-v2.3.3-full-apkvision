using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
public sealed class RenderSettings : Object
{
}

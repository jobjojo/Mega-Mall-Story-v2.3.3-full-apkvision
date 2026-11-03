using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
public sealed class Sprite : Object
{
	[RequiredByNativeCode]
	private Sprite()
	{
	}
}

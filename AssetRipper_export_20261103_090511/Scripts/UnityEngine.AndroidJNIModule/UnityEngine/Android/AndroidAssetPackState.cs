using System.Diagnostics;

namespace UnityEngine.Android;

public class AndroidAssetPackState
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string name;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly AndroidAssetPackStatus status;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly AndroidAssetPackError error;

	internal AndroidAssetPackState(string name, AndroidAssetPackStatus status, AndroidAssetPackError error)
	{
	}
}

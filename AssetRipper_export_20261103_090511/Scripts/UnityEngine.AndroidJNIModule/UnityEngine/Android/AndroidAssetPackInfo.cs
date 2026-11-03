using System.Diagnostics;

namespace UnityEngine.Android;

public class AndroidAssetPackInfo
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly string name;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly AndroidAssetPackStatus status;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong size;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly ulong bytesDownloaded;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly float transferProgress;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly AndroidAssetPackError error;

	internal AndroidAssetPackInfo(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error)
	{
	}
}

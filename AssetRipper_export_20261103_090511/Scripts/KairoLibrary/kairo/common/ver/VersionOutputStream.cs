using System;
using java.io;

namespace kairo.common.ver;

internal class VersionOutputStream : ByteArrayOutputStream, IDisposable
{
	private VersionCode version_;

	public VersionOutputStream(VersionCode version)
	{
	}

	public new void Dispose()
	{
	}
}

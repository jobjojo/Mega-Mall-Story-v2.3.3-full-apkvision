using System;
using java.io;

namespace kairo.common.ver;

internal class VersionInputStream : ByteArrayInputStream, IDisposable
{
	private VersionCode version_;

	public VersionInputStream(byte[] data, VersionCode version)
		: base(null)
	{
	}

	public new void Dispose()
	{
	}
}

using System.Collections.Generic;
using java.io;
using kairo.unity.util;

namespace kairo.common.ver;

public class VersionCode
{
	private List<int> queue_;

	internal int Latest { get; private set; }

	public int Version => 0;

	internal VersionCode(VersionCode version)
	{
	}

	public VersionCode(int version)
	{
	}

	public static implicit operator int(VersionCode ver)
	{
		return 0;
	}

	internal VersionCode Push(int version)
	{
		return null;
	}

	internal void Pop()
	{
	}

	public ByteArrayOutputStream OpenWrite()
	{
		return null;
	}

	public ByteArrayInputStream OpenRead(byte[] data)
	{
		return null;
	}

	public ByteArrayInputStream OpenRead(JarInflater jar, string file)
	{
		return null;
	}
}

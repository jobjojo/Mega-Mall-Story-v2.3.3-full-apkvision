using System.Runtime.Serialization;

namespace System;

[Serializable]
public sealed class OperatingSystem : ISerializable, ICloneable
{
	private readonly Version _version;

	private readonly PlatformID _platform;

	private readonly string _servicePack;

	private string _versionString;

	public PlatformID Platform => PlatformID.Win32S;

	public string VersionString => null;

	public OperatingSystem(PlatformID platform, Version version)
	{
	}

	internal OperatingSystem(PlatformID platform, Version version, string servicePack)
	{
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public object Clone()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}

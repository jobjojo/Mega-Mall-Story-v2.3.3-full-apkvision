namespace System.Resources;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	private readonly string Version;

	public SatelliteContractVersionAttribute(string version)
	{
	}
}

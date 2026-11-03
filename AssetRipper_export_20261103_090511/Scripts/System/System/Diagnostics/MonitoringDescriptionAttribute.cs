using System.ComponentModel;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.All)]
public class MonitoringDescriptionAttribute : DescriptionAttribute
{
	public override string Description => null;

	public MonitoringDescriptionAttribute(string description)
	{
	}
}

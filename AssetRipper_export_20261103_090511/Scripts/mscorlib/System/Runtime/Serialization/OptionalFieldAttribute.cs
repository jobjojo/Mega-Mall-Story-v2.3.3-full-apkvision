using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[ComVisible(true)]
[AttributeUsage(AttributeTargets.Field, Inherited = false)]
public sealed class OptionalFieldAttribute : Attribute
{
	private int versionAdded;

	public int VersionAdded
	{
		set
		{
		}
	}
}

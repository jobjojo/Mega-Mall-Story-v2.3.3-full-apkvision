using System.ComponentModel;

namespace System.Diagnostics;

public class ProcessModule : Component
{
	private IntPtr baseaddr;

	private IntPtr entryaddr;

	private string filename;

	private FileVersionInfo version_info;

	private int memory_size;

	private string modulename;

	[MonitoringDescription("The name of this module")]
	public string ModuleName => null;

	public override string ToString()
	{
		return null;
	}

	internal ProcessModule()
	{
	}
}

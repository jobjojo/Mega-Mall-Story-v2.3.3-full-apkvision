using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Diagnostics;

[StructLayout((LayoutKind)0)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ProcessStartInfo
{
	private string fileName;

	private string arguments;

	private string directory;

	private string verb;

	private ProcessWindowStyle windowStyle;

	private bool errorDialog;

	private IntPtr errorDialogParentHandle;

	private bool useShellExecute;

	private string userName;

	private string domain;

	private SecureString password;

	private string passwordInClearText;

	private bool loadUserProfile;

	private bool redirectStandardInput;

	private bool redirectStandardOutput;

	private bool redirectStandardError;

	private Encoding standardOutputEncoding;

	private Encoding standardErrorEncoding;

	private bool createNoWindow;

	private WeakReference weakParentProcess;

	internal StringDictionary environmentVariables;

	private static readonly string[] empty;

	private Collection<string> _argumentList;

	private IDictionary<string, string> environment;

	public Collection<string> ArgumentList => null;

	[SettingsBindable(true)]
	[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[NotifyParentProperty(true)]
	[DefaultValue(null)]
	public string Arguments
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[NotifyParentProperty(true)]
	[DefaultValue(null)]
	[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
	public StringDictionary EnvironmentVariables => null;

	[NotifyParentProperty(true)]
	[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
	[DefaultValue(false)]
	public bool RedirectStandardInput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[DefaultValue(false)]
	[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
	[NotifyParentProperty(true)]
	public bool RedirectStandardOutput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
	[NotifyParentProperty(true)]
	[DefaultValue(false)]
	public bool RedirectStandardError => false;

	public Encoding StandardErrorEncoding => null;

	public Encoding StandardOutputEncoding => null;

	[MonitoringDescription("Whether to use the operating system shell to start the process.")]
	[NotifyParentProperty(true)]
	[DefaultValue(true)]
	public bool UseShellExecute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NotifyParentProperty(true)]
	public string UserName => null;

	public SecureString Password => null;

	[NotifyParentProperty(true)]
	public string Domain => null;

	[NotifyParentProperty(true)]
	public bool LoadUserProfile => false;

	[SettingsBindable(true)]
	[NotifyParentProperty(true)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The name of the application, document or URL to start.")]
	public string FileName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[SettingsBindable(true)]
	[NotifyParentProperty(true)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue(null)]
	[MonitoringDescription("The initial working directory for the process.")]
	public string WorkingDirectory => null;

	internal bool HaveEnvVars => false;

	public Encoding StandardInputEncoding { get; }

	public ProcessStartInfo()
	{
	}

	internal ProcessStartInfo(Process parent)
	{
	}

	public ProcessStartInfo(string fileName)
	{
	}
}

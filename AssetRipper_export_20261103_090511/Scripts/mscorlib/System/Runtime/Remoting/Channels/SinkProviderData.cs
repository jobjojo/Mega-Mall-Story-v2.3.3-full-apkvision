using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels;

[ComVisible(true)]
public class SinkProviderData
{
	private string sinkName;

	private ArrayList children;

	private Hashtable properties;

	public IList Children => null;

	public IDictionary Properties => null;

	public SinkProviderData(string name)
	{
	}
}

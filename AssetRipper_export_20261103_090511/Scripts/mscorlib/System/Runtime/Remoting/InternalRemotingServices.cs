using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class InternalRemotingServices
{
	private static Hashtable _soapAttributes;

	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
	{
		return null;
	}
}

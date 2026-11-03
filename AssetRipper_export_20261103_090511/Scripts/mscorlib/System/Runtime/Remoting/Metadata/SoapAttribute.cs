using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

[ComVisible(true)]
public class SoapAttribute : Attribute
{
	private bool _useAttribute;

	protected string ProtXmlNamespace;

	protected object ReflectInfo;

	public virtual bool UseAttribute => false;

	public virtual string XmlNamespace => null;

	internal virtual void SetReflectionObject(object reflectionObject)
	{
	}
}

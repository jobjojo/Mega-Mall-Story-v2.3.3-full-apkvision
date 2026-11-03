using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

[ComVisible(true)]
[AttributeUsage(AttributeTargets.Field)]
public sealed class SoapFieldAttribute : SoapAttribute
{
	private string _elementName;

	private bool _isElement;

	public string XmlElementName => null;

	public bool IsInteropXmlElement()
	{
		return false;
	}

	internal override void SetReflectionObject(object reflectionObject)
	{
	}
}

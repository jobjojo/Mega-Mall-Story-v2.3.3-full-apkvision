using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

[ComVisible(true)]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class SoapTypeAttribute : SoapAttribute
{
	private bool _useAttribute;

	private string _xmlElementName;

	private string _xmlNamespace;

	private string _xmlTypeName;

	private string _xmlTypeNamespace;

	private bool _isType;

	private bool _isElement;

	public override bool UseAttribute => false;

	public string XmlElementName => null;

	public override string XmlNamespace => null;

	public string XmlTypeName => null;

	public string XmlTypeNamespace => null;

	internal bool IsInteropXmlElement => false;

	internal bool IsInteropXmlType => false;

	internal override void SetReflectionObject(object reflectionObject)
	{
	}
}

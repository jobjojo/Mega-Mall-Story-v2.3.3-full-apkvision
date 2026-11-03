using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets.Method)]
[ComVisible(true)]
public sealed class SoapMethodAttribute : SoapAttribute
{
	private string _responseElement;

	private string _responseNamespace;

	private string _returnElement;

	private string _soapAction;

	private bool _useAttribute;

	private string _namespace;

	public override bool UseAttribute => false;

	public override string XmlNamespace => null;

	internal override void SetReflectionObject(object reflectionObject)
	{
	}
}

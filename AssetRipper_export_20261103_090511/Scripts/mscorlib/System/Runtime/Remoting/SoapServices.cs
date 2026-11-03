using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public class SoapServices
{
	private class TypeInfo
	{
		public Hashtable Attributes;

		public Hashtable Elements;
	}

	private static Hashtable _xmlTypes;

	private static Hashtable _xmlElements;

	private static Hashtable _soapActions;

	private static Hashtable _soapActionsMethods;

	private static Hashtable _typeInfos;

	public static string XmlNsForClrTypeWithAssembly => null;

	public static string XmlNsForClrTypeWithNs => null;

	public static string XmlNsForClrTypeWithNsAndAssembly => null;

	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
	{
		return null;
	}

	private static string GetNameKey(string name, string namspace)
	{
		return null;
	}

	private static string GetAssemblyName(MethodBase mb)
	{
		return null;
	}

	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace)
	{
		xmlElement = null;
		xmlNamespace = null;
		return false;
	}

	public static string GetXmlNamespaceForMethodCall(MethodBase mb)
	{
		return null;
	}

	public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
	{
		return null;
	}

	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace)
	{
		xmlType = null;
		xmlTypeNamespace = null;
		return false;
	}

	public static void PreLoad(Assembly assembly)
	{
	}

	public static void PreLoad(Type type)
	{
	}

	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
	{
	}

	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
	{
	}

	private static string EncodeNs(string ns)
	{
		return null;
	}
}

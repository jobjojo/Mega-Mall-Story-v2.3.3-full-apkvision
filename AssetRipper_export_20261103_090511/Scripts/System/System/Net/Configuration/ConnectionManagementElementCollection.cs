using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration;

[DefaultMember("Item")]
[ConfigurationCollection(typeof(ConnectionManagementElement))]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{
}

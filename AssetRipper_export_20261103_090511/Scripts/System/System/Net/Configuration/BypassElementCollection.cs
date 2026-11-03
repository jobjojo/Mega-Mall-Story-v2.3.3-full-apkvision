using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration;

[DefaultMember("Item")]
[ConfigurationCollection(typeof(BypassElement))]
public sealed class BypassElementCollection : ConfigurationElementCollection
{
}

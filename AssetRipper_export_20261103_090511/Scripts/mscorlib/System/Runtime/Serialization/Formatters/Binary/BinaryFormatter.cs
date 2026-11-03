using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary;

[ComVisible(true)]
public sealed class BinaryFormatter
{
	internal ISurrogateSelector m_surrogates;

	internal StreamingContext m_context;

	internal SerializationBinder m_binder;

	internal FormatterTypeStyle m_typeFormat;

	internal FormatterAssemblyStyle m_assemblyFormat;

	internal TypeFilterLevel m_securityLevel;

	internal object[] m_crossAppDomainArray;

	private static Dictionary<Type, TypeInformation> typeNameCache;

	public FormatterAssemblyStyle AssemblyFormat
	{
		set
		{
		}
	}

	public ISurrogateSelector SurrogateSelector
	{
		set
		{
		}
	}

	public BinaryFormatter()
	{
	}

	public BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
	{
	}

	public object Deserialize(Stream serializationStream)
	{
		return null;
	}

	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
	{
		return null;
	}

	public object Deserialize(Stream serializationStream, HeaderHandler handler)
	{
		return null;
	}

	public void Serialize(Stream serializationStream, object graph)
	{
	}

	public void Serialize(Stream serializationStream, object graph, Header[] headers)
	{
	}

	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck)
	{
	}

	internal static TypeInformation GetTypeInformation(Type type)
	{
		return null;
	}
}

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Resources;

[Serializable]
[ComVisible(true)]
public class ResourceManager
{
	internal class CultureNameResourceSetPair
	{
	}

	internal class ResourceManagerMediator
	{
		private ResourceManager _rm;

		internal ResourceManagerMediator(ResourceManager rm)
		{
		}
	}

	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets;

	[NonSerialized]
	private Dictionary<string, ResourceSet> _resourceSets;

	protected Assembly MainAssembly;

	private CultureInfo _neutralResourcesCulture;

	[NonSerialized]
	private CultureNameResourceSetPair _lastUsedResourceCache;

	private bool UseManifest;

	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem;

	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc;

	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly;

	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly;

	[NonSerialized]
	private IResourceGroveler resourceGroveler;

	public static readonly int MagicNumber;

	public static readonly int HeaderVersionNumber;

	private static readonly Type _minResourceSet;

	internal static readonly string ResReaderTypeName;

	internal static readonly string ResSetTypeName;

	internal static readonly string MscorlibName;

	internal static readonly int DEBUG;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
	}

	protected ResourceManager()
	{
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
	}

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
	{
		return false;
	}
}

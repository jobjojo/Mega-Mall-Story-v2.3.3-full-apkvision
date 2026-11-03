using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Mono;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(true)]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
{
	private string name;

	private string codebase;

	private int major;

	private int minor;

	private int build;

	private int revision;

	private CultureInfo cultureinfo;

	private AssemblyNameFlags flags;

	private AssemblyHashAlgorithm hashalg;

	private StrongNameKeyPair keypair;

	private byte[] publicKey;

	private byte[] keyToken;

	private AssemblyVersionCompatibility versioncompat;

	private Version version;

	private ProcessorArchitecture processor_architecture;

	private AssemblyContentType contentType;

	public string Name => null;

	public CultureInfo CultureInfo => null;

	public AssemblyNameFlags Flags => AssemblyNameFlags.None;

	public string FullName => null;

	public Version Version
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool IsPublicKeyValid => false;

	public AssemblyName()
	{
	}

	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined)
	{
		aname = default;
		is_version_definited = default;
		is_token_defined = default;
		return false;
	}

	public AssemblyName(string assemblyName)
	{
	}

	internal AssemblyName(SerializationInfo si, StreamingContext sc)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public byte[] GetPublicKeyToken()
	{
		return null;
	}

	private byte[] InternalGetPublicKeyToken()
	{
		return null;
	}

	private unsafe static void get_public_token(byte* token, byte* pubkey, int len)
	{
	}

	private byte[] ComputePublicKeyToken()
	{
		return null;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public object Clone()
	{
		return null;
	}

	public void OnDeserialization(object sender)
	{
	}

	private unsafe static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr)
	{
		return null;
	}

	internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef)
	{
	}

	internal static AssemblyName Create(Assembly assembly, bool fillCodebase)
	{
		return null;
	}
}

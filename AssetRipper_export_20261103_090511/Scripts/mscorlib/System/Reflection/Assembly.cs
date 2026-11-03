using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Policy;

namespace System.Reflection;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.None)]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	internal class ResolveEventHolder
	{
	}

	public virtual string CodeBase => null;

	public virtual string FullName => null;

	internal virtual IntPtr MonoAssembly => (IntPtr)0;

	public virtual string Location => null;

	[MonoTODO]
	public bool IsFullyTrusted => false;

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	public virtual Stream GetManifestResourceStream(string name)
	{
		return null;
	}

	internal virtual Type[] GetTypes(bool exportedOnly)
	{
		return null;
	}

	public virtual Type[] GetTypes()
	{
		return null;
	}

	public virtual Type[] GetExportedTypes()
	{
		return null;
	}

	public virtual Type GetType(string name)
	{
		return null;
	}

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	public virtual AssemblyName GetName(bool copiedName)
	{
		return null;
	}

	public virtual AssemblyName GetName()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public static Assembly GetAssembly(Type type)
	{
		return null;
	}

	public static Assembly Load(string assemblyString)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Assembly ReflectionOnlyLoad(string assemblyString)
	{
		return null;
	}

	private static Assembly load_with_partial_name(string name, Evidence e)
	{
		return null;
	}

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
	{
		return null;
	}

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior)
	{
		return null;
	}

	internal virtual Module[] GetModulesInternal()
	{
		return null;
	}

	public static Assembly GetExecutingAssembly()
	{
		return null;
	}

	public static Assembly GetCallingAssembly()
	{
		return null;
	}

	public virtual string[] GetManifestResourceNames()
	{
		return null;
	}

	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	private static Exception CreateNIE()
	{
		return null;
	}

	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
	{
		return null;
	}

	public virtual Module GetModule(string name)
	{
		return null;
	}

	public virtual Module[] GetModules(bool getResourceModules)
	{
		return null;
	}

	public static bool operator ==(Assembly left, Assembly right)
	{
		return false;
	}

	public static bool operator !=(Assembly left, Assembly right)
	{
		return false;
	}
}

using System.Reflection;

namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
[ComVisible(true)]
public sealed class DllImportAttribute : Attribute
{
	internal string _val;

	public string EntryPoint;

	public CharSet CharSet;

	public bool SetLastError;

	public bool ExactSpelling;

	public bool PreserveSig;

	public CallingConvention CallingConvention;

	public bool BestFitMapping;

	public bool ThrowOnUnmappableChar;

	public string Value => null;

	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method)
	{
		return null;
	}

	internal static bool IsDefined(RuntimeMethodInfo method)
	{
		return false;
	}

	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
	{
	}

	public DllImportAttribute(string dllName)
	{
	}
}

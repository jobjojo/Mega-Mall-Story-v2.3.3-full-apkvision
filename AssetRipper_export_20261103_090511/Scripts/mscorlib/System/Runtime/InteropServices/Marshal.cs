using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Runtime.InteropServices;

public static class Marshal
{
	internal class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>>
	{
		public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
		{
			return false;
		}

		public int GetHashCode(ValueTuple<Type, string> key)
		{
			return 0;
		}
	}

	public static readonly int SystemMaxDBCSCharSize;

	public static readonly int SystemDefaultCharSize;

	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache;

	internal static readonly object MarshalerInstanceCacheLock;

	private static bool skip_fixed(Array array, int startIndex)
	{
		return false;
	}

	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
	{
	}

	private unsafe static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element)
	{
	}

	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
	{
	}

	public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
	{
	}

	public static void FreeBSTR(IntPtr ptr)
	{
	}

	private static void ClearBSTR(IntPtr ptr)
	{
	}

	public static void ZeroFreeBSTR(IntPtr s)
	{
	}

	public static int GetHRForException(Exception e)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int GetLastWin32Error()
	{
		return 0;
	}

	public static IntPtr OffsetOf(Type t, string fieldName)
	{
		return (IntPtr)0;
	}

	public static string PtrToStringAnsi(IntPtr ptr)
	{
		return null;
	}

	public static string PtrToStringUni(IntPtr ptr, int len)
	{
		return null;
	}

	[ComVisible(true)]
	public static object PtrToStructure(IntPtr ptr, Type structureType)
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int ReadInt32(IntPtr ptr, int ofs)
	{
		return 0;
	}

	public static int SizeOf(Type t)
	{
		return 0;
	}

	public static int SizeOf<T>(T structure)
	{
		return 0;
	}

	public static IntPtr SecureStringToBSTR(SecureString s)
	{
		return (IntPtr)0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[ComVisible(true)]
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld)
	{
	}

	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
	{
	}

	private unsafe static IntPtr BufferToBSTR(char* ptr, int slen)
	{
		return (IntPtr)0;
	}

	public static void WriteByte(IntPtr ptr, int ofs, byte val)
	{
	}

	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
	{
		return (IntPtr)0;
	}

	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
	{
		return (IntPtr)0;
	}

	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
	{
		return null;
	}
}

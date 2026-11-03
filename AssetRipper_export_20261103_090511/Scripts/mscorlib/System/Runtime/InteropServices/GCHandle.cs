namespace System.Runtime.InteropServices;

[ComVisible(true)]
public struct GCHandle
{
	private IntPtr handle = (IntPtr)0;

	public bool IsAllocated => false;

	public object Target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private GCHandle(IntPtr h)
	{
	}

	private GCHandle(object obj)
	{
	}

	internal GCHandle(object value, GCHandleType type)
	{
	}

	public IntPtr AddrOfPinnedObject()
	{
		return (IntPtr)0;
	}

	public static GCHandle Alloc(object value)
	{
		return default;
	}

	public static GCHandle Alloc(object value, GCHandleType type)
	{
		return default;
	}

	public void Free()
	{
	}

	public static explicit operator IntPtr(GCHandle value)
	{
		return (IntPtr)0;
	}

	public static explicit operator GCHandle(IntPtr value)
	{
		return default;
	}

	private static bool CheckCurrentDomain(IntPtr handle)
	{
		return false;
	}

	private static object GetTarget(IntPtr handle)
	{
		return null;
	}

	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type)
	{
		return (IntPtr)0;
	}

	private static void FreeHandle(IntPtr handle)
	{
	}

	private static IntPtr GetAddrOfPinnedObject(IntPtr handle)
	{
		return (IntPtr)0;
	}

	public static bool operator ==(GCHandle a, GCHandle b)
	{
		return false;
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static GCHandle FromIntPtr(IntPtr value)
	{
		return default;
	}

	public static IntPtr ToIntPtr(GCHandle value)
	{
		return (IntPtr)0;
	}
}

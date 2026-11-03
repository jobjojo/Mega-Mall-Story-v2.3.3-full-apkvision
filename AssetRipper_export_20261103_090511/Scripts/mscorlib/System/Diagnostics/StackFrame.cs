using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics;

[Serializable]
[StructLayout((LayoutKind)0)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[ComVisible(true)]
public class StackFrame
{
	public const int OFFSET_UNKNOWN = -1;

	private int ilOffset;

	private int nativeOffset;

	private long methodAddress;

	private uint methodIndex;

	private MethodBase methodBase;

	private string fileName;

	private int lineNumber;

	private int columnNumber;

	private string internalMethodName;

	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column)
	{
		method = null;
		iloffset = default;
		native_offset = default;
		file = null;
		line = default;
		column = default;
		return false;
	}

	public StackFrame()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackFrame(int skipFrames)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StackFrame(int skipFrames, bool fNeedFileInfo)
	{
	}

	public virtual int GetFileLineNumber()
	{
		return 0;
	}

	public virtual string GetFileName()
	{
		return null;
	}

	internal string GetSecureFileName()
	{
		return null;
	}

	public virtual int GetILOffset()
	{
		return 0;
	}

	public virtual MethodBase GetMethod()
	{
		return null;
	}

	public virtual int GetNativeOffset()
	{
		return 0;
	}

	internal long GetMethodAddress()
	{
		return 0L;
	}

	internal uint GetMethodIndex()
	{
		return 0u;
	}

	internal string GetInternalMethodName()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}

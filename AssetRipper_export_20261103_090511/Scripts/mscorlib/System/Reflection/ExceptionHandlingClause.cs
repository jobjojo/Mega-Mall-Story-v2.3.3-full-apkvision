using System.Runtime.InteropServices;

namespace System.Reflection;

[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class ExceptionHandlingClause
{
	internal Type catch_type;

	internal int filter_offset;

	internal ExceptionHandlingClauseOptions flags;

	internal int try_offset;

	internal int try_length;

	internal int handler_offset;

	internal int handler_length;

	protected ExceptionHandlingClause()
	{
	}

	public override string ToString()
	{
		return null;
	}
}

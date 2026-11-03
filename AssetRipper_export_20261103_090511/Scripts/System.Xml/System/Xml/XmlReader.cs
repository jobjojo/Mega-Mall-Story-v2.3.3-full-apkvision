using System.Diagnostics;
using System.Reflection;

namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlReader
{
	private static uint IsTextualNodeBitmap;

	private static uint CanReadContentAsBitmap;

	private static uint HasValueBitmap;
}

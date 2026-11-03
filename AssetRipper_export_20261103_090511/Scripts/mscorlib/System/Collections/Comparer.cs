using System.Globalization;
using System.Runtime.Serialization;

namespace System.Collections;

[Serializable]
public sealed class Comparer : IComparer, ISerializable
{
	private CompareInfo _compareInfo;

	public static readonly Comparer Default;

	public static readonly Comparer DefaultInvariant;

	public Comparer(CultureInfo culture)
	{
	}

	private Comparer(SerializationInfo info, StreamingContext context)
	{
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public int Compare(object a, object b)
	{
		return 0;
	}
}

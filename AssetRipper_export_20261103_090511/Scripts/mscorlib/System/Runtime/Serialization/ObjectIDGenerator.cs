using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[Serializable]
[ComVisible(true)]
public class ObjectIDGenerator
{
	internal int m_currentCount;

	internal int m_currentSize;

	internal long[] m_ids;

	internal object[] m_objs;

	private static readonly int[] sizes;

	private int FindElement(object obj, out bool found)
	{
		found = default;
		return 0;
	}

	public virtual long GetId(object obj, out bool firstTime)
	{
		firstTime = default;
		return 0L;
	}

	public virtual long HasId(object obj, out bool firstTime)
	{
		firstTime = default;
		return 0L;
	}

	private void Rehash()
	{
	}
}

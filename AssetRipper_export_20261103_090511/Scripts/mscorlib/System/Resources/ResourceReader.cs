using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Resources;

[ComVisible(true)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
{
	internal sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ResourceReader _reader;

		private bool _currentIsValid;

		private int _currentName;

		private int _dataPosition;

		public object Key => null;

		public object Current => null;

		internal int DataPosition => 0;

		public DictionaryEntry Entry => default;

		public object Value => null;

		internal ResourceEnumerator(ResourceReader reader)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private BinaryReader _store;

	internal Dictionary<string, ResourceLocator> _resCache;

	private long _nameSectionOffset;

	private long _dataSectionOffset;

	private int[] _nameHashes;

	private unsafe int* _nameHashesPtr;

	private int[] _namePositions;

	private unsafe int* _namePositionsPtr;

	private RuntimeType[] _typeTable;

	private int[] _typeNamePositions;

	private BinaryFormatter _objFormatter;

	private int _numResources;

	private UnmanagedMemoryStream _ums;

	private int _version;

	internal ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
	{
	}

	public void Close()
	{
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	internal unsafe static int ReadUnalignedI4(int* p)
	{
		return 0;
	}

	private void SkipString()
	{
	}

	private int GetNameHash(int index)
	{
		return 0;
	}

	private int GetNamePosition(int index)
	{
		return 0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	internal ResourceEnumerator GetEnumeratorInternal()
	{
		return null;
	}

	internal int FindPosForResource(string name)
	{
		return 0;
	}

	private bool CompareStringEqualsName(string name)
	{
		return false;
	}

	private string AllocateStringForNameIndex(int index, out int dataOffset)
	{
		dataOffset = default;
		return null;
	}

	private object GetValueForNameIndex(int index)
	{
		return null;
	}

	internal string LoadString(int pos)
	{
		return null;
	}

	internal object LoadObject(int pos)
	{
		return null;
	}

	internal object LoadObject(int pos, out ResourceTypeCode typeCode)
	{
		typeCode = default;
		return null;
	}

	internal object LoadObjectV1(int pos)
	{
		return null;
	}

	private object _LoadObjectV1(int pos)
	{
		return null;
	}

	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
	{
		typeCode = default;
		return null;
	}

	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
	{
		typeCode = default;
		return null;
	}

	private object DeserializeObject(int typeIndex)
	{
		return null;
	}

	private void ReadResources()
	{
	}

	private void _ReadResources()
	{
	}

	private RuntimeType FindType(int typeIndex)
	{
		return null;
	}
}

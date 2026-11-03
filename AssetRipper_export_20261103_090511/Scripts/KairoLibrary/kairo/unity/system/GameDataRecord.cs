using java.io;
using java.util;
using kairo.unity.util;

namespace kairo.unity.system;

public class GameDataRecord
{
	public class Data
	{
		internal SecureString name_;

		internal SecureByteArray value_;

		internal bool toset_;

		internal bool acquired_;

		public Data()
		{
		}

		public Data(string name, byte[] value, bool toset)
		{
		}

		public Data Clone()
		{
			return null;
		}

		public void Serialize(OutputStream os)
		{
		}

		public void Deserialize(InputStream stream)
		{
		}
	}

	internal SecureInt userId_;

	internal SecureInt friendId_;

	internal SecureInt number_;

	internal Vector dataSet_;

	internal bool exist_;

	internal bool isInsert_;

	public GameDataRecord()
	{
	}

	public GameDataRecord(int number, bool insert = true)
	{
	}

	public GameDataRecord(int friendId, int number, bool insert = true)
	{
	}

	public GameDataRecord(int number, string list, bool insert = true)
	{
	}

	public GameDataRecord(int friendId, int number, string list, bool insert = true)
	{
	}

	public void Add(string name)
	{
	}

	public void Add(string name, string value)
	{
	}

	public void Add(string name, long value)
	{
	}

	public void Add(string name, byte[] data)
	{
	}

	internal void Acquire(string name, byte[] data)
	{
	}

	public void AddList(string list)
	{
	}

	public bool Contains(string name)
	{
		return false;
	}

	public bool TryGetInteger(string name, out int to, int def = 0)
	{
		to = default;
		return false;
	}

	public bool TryGetValue(string name, out long to, long def = 0L)
	{
		to = default;
		return false;
	}

	public bool TryGetString(string name, out string to, string def = null)
	{
		to = null;
		return false;
	}

	public bool TryGetData(string name, out byte[] to, byte[] def = null)
	{
		to = null;
		return false;
	}

	public int GetInteger(string name)
	{
		return 0;
	}

	public long GetValue(string name)
	{
		return 0L;
	}

	public string GetString(string name)
	{
		return null;
	}

	public byte[] GetData(string name)
	{
		return null;
	}

	public void Pack(OutputStream os)
	{
	}

	public GameDataRecord Copy(bool to_set)
	{
		return null;
	}

	public GameDataRecord Copy()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public GameDataRecord Clone()
	{
		return null;
	}

	public int GetUserId()
	{
		return 0;
	}

	public int GetFriendId()
	{
		return 0;
	}

	public int GetNumber()
	{
		return 0;
	}

	public bool Exist()
	{
		return false;
	}

	public string[] GetNames()
	{
		return null;
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

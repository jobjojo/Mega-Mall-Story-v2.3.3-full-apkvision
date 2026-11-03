using System;

namespace kairo.unity.io;

public class RecordStore : IDisposable
{
	private const int ADDR_EXIST_FLAG = -4;

	private const int ADDR_NUM_RECORDS = -8;

	private const int RSTORE_MAX = 5;

	private const int RINFO_SIZE = 25;

	private const int RSINFO_SIZE = 8;

	private const int CRC_SIZE = 8;

	private static RecordStore[] recordStores_;

	private static RecordStoreListener listener_;

	private int rsId_;

	private static string[] resourceFiles_;

	private static Storage rootStorage_;

	private static bool usePreference_;

	private Storage storage_;

	private byte[] encryptionKey_;

	private static bool testDataDialog_;

	public RecordStore(int rsId)
	{
	}

	public RecordStore(int rsId, string assemblyName, byte[] encryptionKey)
	{
	}

	public static void SetPreferenceMode(bool use)
	{
	}

	public static bool Setup()
	{
		return false;
	}

	public static void PreferencesToFile()
	{
	}

	public static void FileToPreferences()
	{
	}

	public static void CreateRecordStore()
	{
	}

	public int AddRecord(int size)
	{
		return 0;
	}

	public int AddRecord(byte[] data)
	{
		return 0;
	}

	public void WriteRecord(int rcId, byte[] data)
	{
	}

	public void WriteRecord(int rcId, byte[][] data)
	{
	}

	public bool ExistRecord(int rcId)
	{
		return false;
	}

	public byte[] ReadRecord(int rcId)
	{
		return null;
	}

	public void RemoveLastRecord()
	{
	}

	public void RemoveAllRecord()
	{
	}

	public int GetRecordSize(int rcId)
	{
		return 0;
	}

	public int GetNumRecords()
	{
		return 0;
	}

	public static RecordStore OpenRecordStore(int rsId)
	{
		return null;
	}

	public static RecordStore OpenRecordStore(int rsId, string assemblyName, byte[] encryptionKey)
	{
		return null;
	}

	public static void WriteRecord(int rsId, int rcId, byte[] data)
	{
	}

	public static byte[] ReadRecord(int rsId, int rcId)
	{
		return null;
	}

	public void CloseRecordStore()
	{
	}

	public int GetSizeAvailable()
	{
		return 0;
	}

	public int GetCapacity()
	{
		return 0;
	}

	public int GetSize()
	{
		return 0;
	}

	public static int GetRecordInfoSize()
	{
		return 0;
	}

	private int GetDataWriteSize(int size)
	{
		return 0;
	}

	public static void SetListener(RecordStoreListener listener)
	{
	}

	public static string GetFileName(int rsId, int rcId)
	{
		return null;
	}

	public static void SetResourceFiles(string[] files)
	{
	}

	public static int CreateResource(string file)
	{
		return 0;
	}

	public static void RegistResource(int id, string file)
	{
	}

	public static string GetResourceFile(int id)
	{
		return null;
	}

	public void Dispose()
	{
	}

	public static byte[] ReadAllRecords(int[] exclude = null, bool compress = true)
	{
		return null;
	}

	public static void WriteAllRecords(byte[] data)
	{
	}

	public static bool Backup(int rsId, int rcId)
	{
		return false;
	}

	public static bool Restore(int rsId, int rcId)
	{
		return false;
	}

	public static bool ExistBackup(int rsId, int rcId)
	{
		return false;
	}

	private static string GetBackupFileName(int rsId, int rcId)
	{
		return null;
	}

	private static bool IsSupportsBackup()
	{
		return false;
	}
}

using System;
using System.Collections.Generic;
using java.io;
using java.lang;
using java.util;
using kairo.unity.io;
using kairo.unity.system.appli;
using kairo.unity.system.payment;
using kairo.unity.system.tapjoy.ui;
using kairo.unity.util;

namespace kairo.unity.system;

public abstract class KairoBase
{
	protected class AccessCount
	{
		public string name_;

		public long value_;

		public AccessCount()
		{
		}

		public AccessCount(string name, long value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	protected class ConnectTask
	{
		public SecureString url_;

		public byte[] send_;

		public long time_;

		public int count_;

		public int dayMax_;

		public int countMax_;

		public void Serialize(OutputStream os)
		{
		}

		public void Deserialize(InputStream stream)
		{
		}
	}

	public delegate byte[] BackupDelegate();

	private class KairoDummy : KairoBase
	{
		public override void Save()
		{
		}

		public override void SaveAll()
		{
		}

		public override void OnSaveGameBegin()
		{
		}

		public override void OnSaveGameEnd()
		{
		}
	}

	public class ConnectObject : HttpObject, IDisposable
	{
		internal JThread thread_;

		internal KairoBase base_;

		internal ConnectObject(KairoBase kb)
		{
		}

		public void Dispose()
		{
		}
	}

	private class StartProcess
	{
		public string Name;

		public int Weight;

		public int TaskIndex;

		public int TaskCount;

		public StartProcess(string name, int taskCount = 1)
		{
		}

		public StartProcess(string name, int taskCount, int weight)
		{
		}
	}

	private class ConnectCommand
	{
		public string url_;

		public string decodeUrl_;

		public byte[] send_;

		public byte[] result_;

		public ConnectCommand(string url, string decodeUrl, byte[] send)
		{
		}

		public bool Equals(string url, byte[] send)
		{
			return false;
		}
	}

	private struct SpTask(byte[] data, string file, int position)
	{
		public string File = null;

		public byte[] Data = null;

		public int Position = 0;
	}

	private static Dictionary<string, KairoBase> instanceTable_;

	protected static KairoBase instance_;

	public int reserveSave;

	public bool reserveSaveEnable;

	protected SecureString host_;

	protected SecureString pubHost_;

	protected int appliVersion_;

	protected int latestVersion_;

	protected SecureString userId_;

	protected SecureString friendId_;

	protected int pkgId_;

	protected int networkLevel_;

	protected bool rootBan_;

	protected bool login_;

	protected int startCount_;

	protected SecureInt flag_;

	protected bool init_;

	protected bool start_;

	protected Vector accessCounter_;

	protected Vector userCounter_;

	protected long cheat_;

	protected int accountType_;

	protected bool illegalPackage_;

	protected bool illegalCountry_;

	protected string[] arguments_;

	protected int[] argumentsInt_;

	protected string gcmId_;

	protected bool isPlaying_;

	protected bool reliableUser_;

	protected SecureString netUserId_;

	private static bool offlineMode_;

	protected Dictionary<string, int> cgiLogLevel_;

	public const int NETLEVEL_LOW = 0;

	public const int NETLEVEL_MIDDLE = 1;

	public const int NETLEVEL_HIGH = 2;

	public const int ACCESSCOUNT_COMMON = 0;

	public const int ACCESSCOUNT_USER = 1;

	protected Vector connectTaskList_;

	private object ExecuteConnectTask_Lock;

	public const int MIGRATION_NONE = -1;

	public const int MIGRATION_START = 0;

	public const int MIGRATION_COMPLETE = 1;

	private const string APPLIST_FILE = "app/list.bin";

	private const string APPLIST_RESOURCE = "applist.txt";

	private GameAppli[] appList_;

	private int appListDate_;

	private string COMMON_SERVER;

	private const string COM_PUB = "https://appli.kairogame.jp/";

	private const string COM_DEV = "https://kairoServiceDev.kairogame.jp/";

	private string publicHost_;

	private string developHost_;

	private const string SAVE_PUB = "https://bakmas.kairogame.jp/";

	private const string SAVE_DEV = "https://kairoServiceDev.kairogame.jp/";

	private const string BACKUP_RESERVE_PREF = "BACKUP_RESERVE";

	private const string BACKUP_LASTTIME_PREF = "BACKUP_LASTTIME";

	private const string BACKUP_INTERVAL_PREF = "BACKUP_INTERVAL";

	private const string BACKUP_LASTDATE_PREF = "BACKUP_LASTDATE";

	private const string BACKUP_AUTO_PREF = "BACKUP_AUTO";

	private const string PREF_RESET = "_ks_reset";

	private const string PREF_RELIABLE_USER = "RELIABLE_USER";

	private static long lastCoinTime_;

	private long autoBackupInterval_;

	private BackupDelegate backupMethod_;

	private static KairoDummy dummy_;

	private int[] prgStart_;

	private List<ConnectObject> connects_;

	private object connectsLock_;

	private int processNow_;

	private List<StartProcess> processList_;

	private bool processProgressOn_;

	private static string[][] HTTP_TO_HTTPS;

	private static List<ConnectCommand> connectBatching_;

	private static List<ConnectCommand> connectBatchingNew_;

	private static List<string> connectBatchingCgi_;

	private static bool isStartConnectBatching_;

	private static List<KeyValuePair<int, string>> connectBatchingCgiList_;

	private JThread thBackupThread_;

	private int failedBackupCount_;

	private List<PaymentDataRecord> paymemtList_;

	private const int PAY_MODE_GET = 1;

	private const int PAY_MODE_ADD = 2;

	private const int PAY_MODE_USE = 3;

	private static readonly int[] CONNECT_TRY;

	private const int CONNECT_TRY_SLEEP = 100;

	private const bool NEXT_STARTUP_ASYSC = false;

	private const string PAY_ASYNC_TAG = "startUpSync";

	private const string PAY_ASYNC_TAG_S = "sus";

	private const string PAYMENT_CGI = "virtual_currency.php";

	public List<string> connectPaymemtMoneyResponse_;

	public static bool OfflineMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsUpdateAppList { get; set; }

	public static bool IsUpdateLineup { get; set; }

	public bool IsAutoBackup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string URL_SP => null;

	public static KairoBase GetInstance()
	{
		return null;
	}

	public void Reset()
	{
	}

	public void Restart()
	{
	}

	public void Restart(string userId)
	{
	}

	public void Init(int ver, string devHost, string pubHost, byte[] data, int networkLevel, bool rootBan)
	{
	}

	public void Reboot()
	{
	}

	public void Start()
	{
	}

	protected void Load(byte[] data)
	{
	}

	public byte[] Write()
	{
		return null;
	}

	public void NewGame(bool take)
	{
	}

	public void LoadGame(byte[] data)
	{
	}

	public byte[] WriteGame()
	{
		return null;
	}

	protected virtual void OnInit()
	{
	}

	public virtual void OnStart()
	{
	}

	public virtual void OnStart(string processName)
	{
	}

	protected virtual void OnLoad(InputStream stream)
	{
	}

	protected virtual void OnWrite(OutputStream os)
	{
	}

	protected virtual void OnNewGame(bool take)
	{
	}

	protected virtual void OnLoadGame(InputStream stream)
	{
	}

	protected virtual void OnWriteGame(OutputStream os)
	{
	}

	public virtual void Finish()
	{
	}

	public virtual bool ConnectLogin(bool enforce = false, bool retry = false)
	{
		return false;
	}

	public void AccessCounter(int type, string name)
	{
	}

	public void AccessCounter(int type, string name, int up)
	{
	}

	public void AccessCounter(int type, string name, int up, bool save)
	{
	}

	public virtual void ConnectAccessCounter()
	{
	}

	public string[] ConnectGift(string pw)
	{
		return null;
	}

	public GameDataRecord ConnectGameData(GameDataRecord gameData)
	{
		return null;
	}

	public GameDataRecord ConnectGameData(string tbname, GameDataRecord gameData)
	{
		return null;
	}

	public GameDataRecord[] ConnectGameData(GameDataRecord[] dataList)
	{
		return null;
	}

	public GameDataRecord[] ConnectGameData(string tbname, GameDataRecord[] dataList)
	{
		return null;
	}

	public int[] ConnectGameDataNumbers(string tbname = null)
	{
		return null;
	}

	public GameDataRecord[] ConnectGameDataSearch(string get, string where, string order, string count, int logic)
	{
		return null;
	}

	public GameDataRecord[] ConnectGameDataSearch(string tbname, string get, string where, string order, string count, int logic)
	{
		return null;
	}

	public GameDataRecord[] ConnectGameDataSearch(string get, string where, string order, string column, long value, long low, long high, string count, int logic)
	{
		return null;
	}

	public GameDataRecord[] ConnectGameDataSearch(string tbname, string get, string where, string order, string column, long value, long low, long high, string count, int logic)
	{
		return null;
	}

	public GameDataRecord[][] ConnectGameDataRanking(string friendId, string get, string where, string column, string top, bool self, string order)
	{
		return null;
	}

	public GameDataRecord[][] ConnectGameDataRanking(string tbname, string friendId, string get, string where, string column, string top, bool self, string order)
	{
		return null;
	}

	private string CorrectGetGameData(string get)
	{
		return null;
	}

	private string CorrectWhereGameData(string where)
	{
		return null;
	}

	public byte[][] ConnectLineupList(string time)
	{
		return null;
	}

	public byte[][] ConnectLineupImage(string files)
	{
		return null;
	}

	public byte[] ConnectRegistScore(string m, string s, string r, string all = "0")
	{
		return null;
	}

	public byte[] ConnectGetScore(string m)
	{
		return null;
	}

	public byte[] ConnectRanking(string m, string r, string p)
	{
		return null;
	}

	public void StartConnectBatching(string[] extCgiList = null)
	{
	}

	private byte[][] CgiBatch(byte[] post)
	{
		return null;
	}

	public byte[] RegistConnectBatching(string url, byte[] send, bool check)
	{
		return null;
	}

	public byte[][] RegistConnectBatching(string url, byte[] send, bool check, bool split)
	{
		return null;
	}

	public void EndConnectBatching()
	{
	}

	private string DecodeUrl(string url)
	{
		return null;
	}

	public void ConnectTime()
	{
	}

	public void ConnectVersion()
	{
	}

	private string ConnectSaveServer()
	{
		return null;
	}

	private void ConnectSaveSet(byte[] data)
	{
	}

	public void SetBackupMethod(BackupDelegate method)
	{
	}

	public void SetBackupMethod(BackupDelegate method, long autoBackupInterval)
	{
	}

	public bool BackupUpload()
	{
		return false;
	}

	public void BackupUploadReserve()
	{
	}

	private void UpdateBackupReserve()
	{
	}

	public long GetLastBackupTime()
	{
		return 0L;
	}

	protected byte[] FromDBValue(string table, string name, byte[] value)
	{
		return null;
	}

	internal byte[] ToDBValue(string table, string name, byte[] value)
	{
		return null;
	}

	protected int GetColumnType(string table, string column)
	{
		return 0;
	}

	private string[] CgiLogin(string userid, string c, string pkg, string r, byte[] signature)
	{
		return null;
	}

	private string CgiTime()
	{
		return null;
	}

	private string CgiVersion()
	{
		return null;
	}

	public static string MakeQuery(string query, int param)
	{
		return null;
	}

	public static string MakeQuery(string query, string param)
	{
		return null;
	}

	public string MakeUrl(string cgi)
	{
		return null;
	}

	public string MakeUrl(string cgi, byte[] send)
	{
		return null;
	}

	private static string MakeUrl(KairoBase ks, int appliVersion, string userId, string host, string cgi, byte[] send)
	{
		return null;
	}

	public static byte[] Connect(string cgi)
	{
		return null;
	}

	public static byte[][] Connect(string cgi, bool split)
	{
		return null;
	}

	public static byte[] Connect(string cgi, byte[] send)
	{
		return null;
	}

	public static byte[][] Connect(string cgi, byte[] send, bool split, bool autoLogin = true)
	{
		return null;
	}

	public static void ExecuteAsyncConnects()
	{
	}

	protected virtual void Connected(string cgi, byte[] send, bool split)
	{
	}

	public static void ConnectAsync(string cgi, byte[] send)
	{
	}

	public static void ConnectAsync(string cgi, byte[] send, int count, int day)
	{
	}

	public string GetUserId()
	{
		return null;
	}

	public int GetUserIdInt()
	{
		return 0;
	}

	public bool CheckUserId()
	{
		return false;
	}

	public string GetFriendId()
	{
		return null;
	}

	public int GetFriendIdInt()
	{
		return 0;
	}

	public bool CheckFriendId()
	{
		return false;
	}

	public int GetPackageId()
	{
		return 0;
	}

	protected static string GetSignature()
	{
		return null;
	}

	protected void ExecuteConnectTask()
	{
	}

	public int GetAsyncConnectNum()
	{
		return 0;
	}

	public bool CheckNetwork()
	{
		return false;
	}

	public int GetStartCount()
	{
		return 0;
	}

	public int GetLatestVersion()
	{
		return 0;
	}

	public int GetAppliVersion()
	{
		return 0;
	}

	public virtual void Update()
	{
	}

	public static long GetHackingCount()
	{
		return 0L;
	}

	public abstract void Save();

	public abstract void SaveAll();

	public bool CheckRoot()
	{
		return false;
	}

	private string Encode(string src)
	{
		return null;
	}

	private string Decode(int[] src)
	{
		return null;
	}

	public bool IsLogin()
	{
		return false;
	}

	public bool IsStart()
	{
		return false;
	}

	public bool Check(int bit)
	{
		return false;
	}

	public void On(int bit)
	{
	}

	public void Off(int bit)
	{
	}

	public bool IsInit()
	{
		return false;
	}

	public void SetReserveSave(bool all)
	{
	}

	public void SetReserveSaveEnable(bool enable)
	{
	}

	public virtual bool HandleActivityResult(int requestCode, int resultCode, object data)
	{
		return false;
	}

	public void SetLogLevel(string cgi, int send, int recv, int query)
	{
	}

	public long GetCheatCount()
	{
		return 0L;
	}

	public bool IsCheater()
	{
		return false;
	}

	public bool IsIllegalPackage()
	{
		return false;
	}

	public bool IsIllegalCountry()
	{
		return false;
	}

	public void SetCheater(bool cheat = true)
	{
	}

	public virtual void OnSaveGameBegin()
	{
	}

	public virtual void OnSaveGameEnd()
	{
	}

	public bool AddPaymentMoney(string product_id, string order_code, string purchaseToken, int amount, int action, bool async = false)
	{
		return false;
	}

	public bool UsePaymentMoney(List<PaymentDataRecord> payList, bool async = false)
	{
		return false;
	}

	public bool UsePaymentMoney(int use_amount, int action)
	{
		return false;
	}

	public bool UsePaymentMoney(int use_amount, int action, List<PaymentDataRecord> payList, bool async = false)
	{
		return false;
	}

	public int GetPaymentMoney()
	{
		return 0;
	}

	public int ConnectPaymemtMoney(int mode, List<PaymentDataRecord> paymemtListData, bool async = false)
	{
		return 0;
	}

	public string VerificationReceipt(string product_id, string order_code, string purchaseToken, bool subs)
	{
		return null;
	}

	private string GetPaymentHost()
	{
		return null;
	}

	public string ConnectMigrationStart(byte[] data)
	{
		return null;
	}

	public byte[] ConnectMigrationRead(string pw)
	{
		return null;
	}

	public int ConnectMigrationComplete(string pw)
	{
		return 0;
	}

	public int ConnectMigrationCancel(string pw)
	{
		return 0;
	}

	public long ConnectMigrationCheck(string pw, int backUserid = -1)
	{
		return 0L;
	}

	public int ConnectMigrationState(string pw)
	{
		return 0;
	}

	public byte[] ConnectAppList(int localFileDate)
	{
		return null;
	}

	private void ConnectNotificationRegist(string gcmId)
	{
	}

	public void ConnectNotificationSend(string friendId, string text, string key = null)
	{
	}

	public bool ConnectLangPackCheck(string file, int ver, int hash)
	{
		return false;
	}

	public void ConnectLangPackSet(string file, int ver, int hash, string data)
	{
	}

	public void ConnectLangPackWeb(string file, string copyFile = null)
	{
	}

	public byte[][] ConnectLangPackLib()
	{
		return null;
	}

	public byte[][] ConnectLangPackLib(string fromLang, string toLang)
	{
		return null;
	}

	private bool ConnectCoinLog(byte[] send, bool async)
	{
		return false;
	}

	public bool ConnectUser(string operation_mode, string other = null)
	{
		return false;
	}

	public int GetArgumentsNum()
	{
		return 0;
	}

	public string GetArgument(int index)
	{
		return null;
	}

	public int GetArgumentInt(int index)
	{
		return 0;
	}

	private void LoadAppList()
	{
	}

	private GameAppli[] LoadAppList(byte[] data, out int date)
	{
		date = default;
		return null;
	}

	public GameAppli[] GetAppList(bool languageOnly = true, bool releaseOnly = true)
	{
		return null;
	}

	public ConnectObject ReadyConnection()
	{
		return null;
	}

	private byte[] HttpConnect(string url, byte[] send, bool check)
	{
		return null;
	}

	private byte[][] HttpConnect(string url, byte[] send, bool check, bool split)
	{
		return null;
	}

	public ITapjoy GetTapjoy()
	{
		return null;
	}

	internal void SetGameState(bool playing)
	{
	}

	public bool IsGamePlaying()
	{
		return false;
	}

	public int GetStartProgress()
	{
		return 0;
	}

	protected void SetOnStartProgress(int progress)
	{
	}

	private void SetSystemStartProgress(int progress)
	{
	}

	private string GetCommonServer()
	{
		return null;
	}

	public virtual string Proc_changeUrl(string url, string cgi)
	{
		return null;
	}

	public static byte[] Compress(byte[] data, bool verify = true)
	{
		return null;
	}

	public static byte[] Expand(byte[] data)
	{
		return null;
	}

	public void AddStartProcess(string name)
	{
	}

	private void AddStartProcess(string name, int taskCount)
	{
	}

	private void AddStartProcess(string name, int taskCount, int weight)
	{
	}

	protected virtual void OnPreConnection(ref string url, ref byte[] send)
	{
	}

	protected virtual void OnPostConnection(string url, byte[] send, byte[] recv)
	{
	}

	public static byte[] SConnect(string host, string cgi, byte[] send)
	{
		return null;
	}

	public static void SpOut(byte[] data, string name = null, string infomation = null, Exception error = null)
	{
	}

	public static void SpOut(Progress progress, byte[] data, string name = null, string infomation = null, Exception error = null)
	{
	}

	public static byte[] SpIn(string code = null)
	{
		return null;
	}

	public static byte[] SpIn(Progress progress, string code = null)
	{
		return null;
	}

	private static SpTask[] MakeSendDataTask(byte[] data, string infomation, Exception error)
	{
		return null;
	}

	public void SetOfflineMode(bool offline)
	{
	}

	public void SendCoinLog(long[][] log, bool async)
	{
	}

	public void SetReliableUser(bool ok)
	{
	}

	public bool IsReliableUser()
	{
		return false;
	}

	public string GetNetUserId()
	{
		return null;
	}

	public int GetNetUserIdInt()
	{
		return 0;
	}

	public bool CheckNetUserId()
	{
		return false;
	}

	public void SetNetUserId(string id)
	{
	}
}

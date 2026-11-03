namespace analytics;

public class AnalyticsSender
{
	public delegate void OnSendInstallReferrerCompleted(bool successful);

	public enum HitType
	{
		PageView = 0,
		ScreenView = 1,
		Event = 2,
		Transaction = 3,
		Item = 4,
		Social = 5,
		Exception = 6,
		Timing = 7
	}

	private const string INSTALL_REFERRER_KEY = "_InstallReferrer";

	private static readonly string[] HIT_TYPES;

	public static string MakeQuery(string query, string param)
	{
		return null;
	}

	public static string MakeQuery(string query, int param)
	{
		return null;
	}

	public static string Encode(string url)
	{
		return null;
	}

	private static string MakeClientId()
	{
		return null;
	}

	private static string GetApplicationName()
	{
		return null;
	}

	public static bool SendData(HitType hitType, string id, params string[] param)
	{
		return false;
	}

	public static bool SendReferrer(string referrer)
	{
		return false;
	}

	private static void SaveInstallReferrer(string referrer)
	{
	}

	private static string LoadInstallReferrer()
	{
		return null;
	}

	private static void DeleteInstallReferrer()
	{
	}

	public static bool RetrySendInstallReferrer()
	{
		return false;
	}

	public static void RetrySendInstallReferrerAsync(OnSendInstallReferrerCompleted method = null)
	{
	}

	public static void OnReceiveReferrer(string referrer)
	{
	}
}

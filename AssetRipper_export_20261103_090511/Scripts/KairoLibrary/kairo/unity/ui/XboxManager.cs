using System.Threading;
using kairo.unity.type;

namespace kairo.unity.ui;

public class XboxManager
{
	private static Thread dispatchJob_;

	private static bool stopExecution_;

	private static string sandboxId_;

	private static string serviceConfigId_;

	private static uint titleId_;

	private static bool networkInitialize_;

	private static bool signIn_;

	internal static bool initialized_;

	private XboxManager()
	{
	}

	internal static void Create()
	{
	}

	internal static void Initialize()
	{
	}

	private static void ShowErrorDialog(string title, int code)
	{
	}

	internal static void Update()
	{
	}

	internal static void Finish()
	{
	}

	public static void DrawGamerTag(Graphics g)
	{
	}

	public static void DrawGamerTag(Graphics g, Point offset)
	{
	}
}

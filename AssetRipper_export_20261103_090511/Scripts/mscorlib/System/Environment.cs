using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
public static class Environment
{
	[ComVisible(true)]
	public enum SpecialFolder
	{
		MyDocuments = 5,
		Desktop = 0,
		MyComputer = 17,
		Programs = 2,
		Personal = MyDocuments,
		Favorites = 6,
		Startup = 7,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		MyMusic = 13,
		DesktopDirectory = 16,
		Templates = 21,
		ApplicationData = 26,
		LocalApplicationData = 28,
		InternetCache = 32,
		Cookies = 33,
		History = 34,
		CommonApplicationData = 35,
		System = 37,
		ProgramFiles = 38,
		MyPictures = 39,
		CommonProgramFiles = 43,
		MyVideos = 14,
		NetworkShortcuts = 19,
		Fonts = 20,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		PrinterShortcuts = 27,
		Windows = 36,
		UserProfile = 40,
		SystemX86 = 41,
		ProgramFilesX86 = 42,
		CommonProgramFilesX86 = 44,
		CommonTemplates = 45,
		CommonDocuments = 46,
		CommonAdminTools = 47,
		AdminTools = 48,
		CommonMusic = 53,
		CommonPictures = 54,
		CommonVideos = 55,
		Resources = 56,
		LocalizedResources = 57,
		CommonOemLinks = 58,
		CDBurning = 59
	}

	public enum SpecialFolderOption
	{
		None = 0,
		DoNotVerify = 0x4000,
		Create = 0x8000
	}

	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

	private static string nl;

	private static OperatingSystem os;

	public static string CurrentDirectory => null;

	public static int CurrentManagedThreadId => 0;

	public static bool HasShutdownStarted => false;

	public static string MachineName => null;

	public static string NewLine => null;

	internal static PlatformID Platform
	{
		[CompilerGenerated]
		get
		{
			return PlatformID.Win32S;
		}
	}

	public static OperatingSystem OSVersion => null;

	public static string StackTrace => null;

	public static int TickCount => 0;

	public static int ProcessorCount => 0;

	internal static bool IsRunningOnWindows => false;

	internal static string GetResourceString(string key)
	{
		return null;
	}

	internal static string GetResourceString(string key, params object[] values)
	{
		return null;
	}

	internal static string GetResourceStringEncodingName(int codePage)
	{
		return null;
	}

	private static string GetNewLine()
	{
		return null;
	}

	internal static string GetOSVersionString()
	{
		return null;
	}

	internal static Version CreateVersionFromString(string info)
	{
		return null;
	}

	public static void Exit(int exitCode)
	{
	}

	internal static string internalGetEnvironmentVariable_native(IntPtr variable)
	{
		return null;
	}

	internal static string internalGetEnvironmentVariable(string variable)
	{
		return null;
	}

	public static string GetEnvironmentVariable(string variable)
	{
		return null;
	}

	public static IDictionary GetEnvironmentVariables()
	{
		return null;
	}

	public static string GetFolderPath(SpecialFolder folder)
	{
		return null;
	}

	private static string GetWindowsFolderPath(int folder)
	{
		return null;
	}

	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		return null;
	}

	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
	{
		return null;
	}

	internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		return null;
	}

	public static void FailFast(string message, Exception exception)
	{
	}

	internal static void FailFast(string message, Exception exception, string errorSource)
	{
	}

	private static string[] GetEnvironmentVariableNames()
	{
		return null;
	}

	internal static string GetMachineConfigPath()
	{
		return null;
	}

	internal static string internalGetHome()
	{
		return null;
	}

	internal static int GetPageSize()
	{
		return 0;
	}

	internal static string GetStackTrace(Exception e, bool needFileInfo)
	{
		return null;
	}
}

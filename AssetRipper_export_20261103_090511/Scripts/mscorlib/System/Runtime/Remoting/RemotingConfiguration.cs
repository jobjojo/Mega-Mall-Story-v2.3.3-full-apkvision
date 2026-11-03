using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public static class RemotingConfiguration
{
	private static string applicationID;

	private static string applicationName;

	private static string processGuid;

	private static bool defaultConfigRead;

	private static bool defaultDelayedConfigRead;

	private static CustomErrorsModes _errorMode;

	private static Hashtable wellKnownClientEntries;

	private static Hashtable activatedClientEntries;

	private static Hashtable wellKnownServiceEntries;

	private static Hashtable activatedServiceEntries;

	private static Hashtable channelTemplates;

	private static Hashtable clientProviderTemplates;

	private static Hashtable serverProviderTemplates;

	public static string ApplicationName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string ProcessId => null;

	internal static void LoadDefaultDelayedChannels()
	{
	}

	public static bool IsActivationAllowed(Type svrType)
	{
		return false;
	}

	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
	{
		return null;
	}

	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
	{
		return null;
	}

	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
	{
	}

	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
	{
	}

	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
	{
	}

	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
	{
	}

	internal static void RegisterChannelTemplate(ChannelData channel)
	{
	}

	internal static void RegisterClientProviderTemplate(ProviderData prov)
	{
	}

	internal static void RegisterServerProviderTemplate(ProviderData prov)
	{
	}

	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed)
	{
	}

	internal static void RegisterTypes(ArrayList types)
	{
	}

	public static bool CustomErrorsEnabled(bool isLocalRequest)
	{
		return false;
	}

	internal static void SetCustomErrorsMode(string mode)
	{
	}
}

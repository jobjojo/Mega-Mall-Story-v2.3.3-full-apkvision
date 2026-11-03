using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels;

[ComVisible(true)]
public sealed class ChannelServices
{
	private static ArrayList registeredChannels;

	private static ArrayList delayedClientChannels;

	private static CrossContextChannel _crossContextSink;

	internal static string CrossContextUrl;

	private static IList oldStartModeTypes;

	internal static CrossContextChannel CrossContextChannel => null;

	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri)
	{
		objectUri = null;
		return null;
	}

	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri)
	{
		objectUri = null;
		return null;
	}

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	public static void RegisterChannel(IChannel chnl)
	{
	}

	public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
	{
	}

	internal static void RegisterChannelConfig(ChannelData channel)
	{
	}

	private static object CreateProvider(ProviderData prov)
	{
		return null;
	}

	public static IMessage SyncDispatchMessage(IMessage msg)
	{
		return null;
	}

	private static ReturnMessage CheckIncomingMessage(IMessage msg)
	{
		return null;
	}

	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
	{
		return null;
	}

	private static bool IsLocalCall(IMessage callMsg)
	{
		return false;
	}

	internal static object[] GetCurrentChannelInfo()
	{
		return null;
	}
}

using System.Net.Sockets;

namespace System.Net;

[Serializable]
public class IPAddress
{
	private sealed class ReadOnlyIPAddress : IPAddress
	{
		public ReadOnlyIPAddress(long newAddress)
			: base(0L)
		{
		}
	}

	public static readonly IPAddress Any;

	public static readonly IPAddress Loopback;

	public static readonly IPAddress Broadcast;

	public static readonly IPAddress None;

	internal const long LoopbackMask = 255L;

	public static readonly IPAddress IPv6Any;

	public static readonly IPAddress IPv6Loopback;

	public static readonly IPAddress IPv6None;

	private uint _addressOrScopeId;

	private readonly ushort[] _numbers;

	private string _toString;

	private int _hashCode;

	internal const int NumberOfLabels = 8;

	private bool IsIPv4 => false;

	private bool IsIPv6 => false;

	private uint PrivateAddress
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private uint PrivateScopeId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public AddressFamily AddressFamily => AddressFamily.Unspecified;

	public IPAddress(long newAddress)
	{
	}

	public IPAddress(byte[] address, long scopeid)
	{
	}

	public IPAddress(ReadOnlySpan<byte> address, long scopeid)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static long HostToNetworkOrder(long host)
	{
		return 0L;
	}

	public static int HostToNetworkOrder(int host)
	{
		return 0;
	}

	public static short HostToNetworkOrder(short host)
	{
		return 0;
	}

	public static long NetworkToHostOrder(long network)
	{
		return 0L;
	}

	public static int NetworkToHostOrder(int network)
	{
		return 0;
	}

	public static short NetworkToHostOrder(short network)
	{
		return 0;
	}

	internal bool Equals(object comparandObj, bool compareScopeId)
	{
		return false;
	}

	public override bool Equals(object comparand)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private static byte[] ThrowAddressNullException()
	{
		return null;
	}
}

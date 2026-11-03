using System.Text;

namespace System.Net;

internal class IPAddressParser
{
	internal static string IPv4AddressToString(uint address)
	{
		return null;
	}

	internal static void IPv4AddressToString(uint address, StringBuilder destination)
	{
	}

	private unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
	{
		return 0;
	}

	internal static string IPv6AddressToString(ushort[] address, uint scopeId)
	{
		return null;
	}

	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId)
	{
		return null;
	}

	private unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
	{
	}

	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer)
	{
	}

	private static void AppendHex(ushort value, StringBuilder buffer)
	{
	}

	private static uint ExtractIPv4Address(ushort[] address)
	{
		return 0u;
	}

	private static ushort Reverse(ushort number)
	{
		return 0;
	}
}

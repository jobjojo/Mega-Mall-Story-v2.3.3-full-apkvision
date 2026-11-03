using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class CryptoConfig
{
	private static readonly object lockObject;

	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms => false;

	public static byte[] EncodeOID(string str)
	{
		return null;
	}

	private static byte[] EncodeLongNumber(long x)
	{
		return null;
	}
}

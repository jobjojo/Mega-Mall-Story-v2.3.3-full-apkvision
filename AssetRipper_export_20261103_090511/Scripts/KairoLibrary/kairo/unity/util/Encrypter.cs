using System.Collections.Generic;

namespace kairo.unity.util;

public class Encrypter
{
	private static byte[] key_;

	private static byte[] storedKey_;

	private static Stack<byte[]> keyStack_;

	private Encrypter()
	{
	}

	public static void SetEncryptionKey(byte[] key)
	{
	}

	public static void SetEncryptionKey(sbyte[] key)
	{
	}

	public static void PushEncryptionKey(byte[] key)
	{
	}

	public static void PushEncryptionKey(sbyte[] key)
	{
	}

	public static void PopEncryptionKey()
	{
	}

	public static void BackupKey()
	{
	}

	public static void RestoreKey()
	{
	}

	public static void Encode(byte[] src)
	{
	}

	public static void Encode(byte[] src, byte[] key)
	{
	}

	public static void Decode(byte[] src)
	{
	}

	public static void Decode(byte[] src, byte[] key)
	{
	}

	public static void Encode(byte[] src, sbyte[] key)
	{
	}

	public static void Decode(byte[] src, sbyte[] key)
	{
	}
}

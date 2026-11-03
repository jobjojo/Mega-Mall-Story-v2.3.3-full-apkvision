using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class SHA256Managed : SHA256
{
	private byte[] _buffer;

	private long _count;

	private uint[] _stateSHA256;

	private uint[] _W;

	private static readonly uint[] _K;

	public override void Initialize()
	{
	}

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
	{
	}

	protected override byte[] HashFinal()
	{
		return null;
	}

	private void InitializeState()
	{
	}

	private void _HashData(byte[] partIn, int ibStart, int cbSize)
	{
	}

	private byte[] _EndHash()
	{
		return null;
	}

	private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
	{
	}

	private static uint RotateRight(uint x, int n)
	{
		return 0u;
	}

	private static uint Ch(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint Maj(uint x, uint y, uint z)
	{
		return 0u;
	}

	private static uint sigma_0(uint x)
	{
		return 0u;
	}

	private static uint sigma_1(uint x)
	{
		return 0u;
	}

	private static uint Sigma_0(uint x)
	{
		return 0u;
	}

	private static uint Sigma_1(uint x)
	{
		return 0u;
	}

	private unsafe static void SHA256Expand(uint* x)
	{
	}
}

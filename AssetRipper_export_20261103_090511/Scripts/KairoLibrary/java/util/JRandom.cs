using System;

namespace java.util;

public class JRandom
{
	protected class Xorshift128 : Random
	{
		private uint _x;

		private uint _y;

		private uint _z;

		private uint _w;

		public Xorshift128()
		{
		}

		public Xorshift128(int seed)
		{
		}

		private void SetSeed(int seed)
		{
		}

		private void SetSeed(uint seedX, uint seedY, uint seedZ, uint seedW)
		{
		}

		public override int Next()
		{
			return 0;
		}
	}

	protected class Random2018 : Random
	{
		public Random2018()
		{
		}

		public Random2018(int seed)
		{
		}

		private void Init()
		{
		}
	}

	public enum Logics
	{
		Default = 0,
		Unity2018 = 1,
		Xorshift128 = 2
	}

	protected Random random_;

	protected Random2018 random2018_;

	protected Xorshift128 randomXor_;

	internal static bool fix_;

	public static Logics Logic { get; set; }

	public JRandom()
	{
	}

	public JRandom(long seed)
	{
	}

	public int NextInt()
	{
		return 0;
	}

	public int NextInt(int n)
	{
		return 0;
	}

	public long NextLong()
	{
		return 0L;
	}

	public void SetSeed(long seed)
	{
	}
}

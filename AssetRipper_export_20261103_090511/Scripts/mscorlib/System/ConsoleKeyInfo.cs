namespace System;

[Serializable]
public readonly struct ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
{
	private readonly char _keyChar = '\0';

	private readonly ConsoleKey _key = (ConsoleKey)0;

	private readonly ConsoleModifiers _mods = (ConsoleModifiers)0;

	public char KeyChar => '\0';

	public ConsoleKey Key => (ConsoleKey)0;

	public override bool Equals(object value)
	{
		return false;
	}

	public bool Equals(ConsoleKeyInfo obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

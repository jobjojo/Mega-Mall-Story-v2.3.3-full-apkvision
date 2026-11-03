using System.Collections;
using System.Collections.Generic;

namespace System;

[Serializable]
public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable
{
	private string _str;

	private int _index;

	private char _currentElement;

	object IEnumerator.Current => null;

	public char Current => '\0';

	internal CharEnumerator(string str)
	{
	}

	public object Clone()
	{
		return null;
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Dispose()
	{
	}

	public void Reset()
	{
	}

	internal CharEnumerator()
	{
	}
}

using System.Globalization;
using System.Runtime.CompilerServices;

namespace System;

internal ref struct __DTString
{
	internal ReadOnlySpan<char> Value = default;

	internal int Index = 0;

	internal char m_current = '\0';

	private CompareInfo m_info = null;

	private bool m_checkDigitToken = false;

	private static readonly char[] WhiteSpaceChecks;

	internal int Length => 0;

	internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi)
	{
	}

	internal bool GetNext()
	{
		return false;
	}

	internal bool AtEnd()
	{
		return false;
	}

	internal bool Advance(int count)
	{
		return false;
	}

	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
	{
		tokenType = default;
		tokenValue = default;
	}

	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
	{
		indexBeforeSeparator = default;
		charBeforeSeparator = default;
		return (TokenType)0;
	}

	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
	{
		return false;
	}

	internal bool Match(char ch)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal bool GetNextDigit()
	{
		return false;
	}

	internal char GetChar()
	{
		return '\0';
	}

	internal int GetDigit()
	{
		return 0;
	}

	internal void SkipWhiteSpaces()
	{
	}

	internal bool SkipWhiteSpaceCurrent()
	{
		return false;
	}

	internal DTSubString GetSubString()
	{
		return default;
	}

	internal void ConsumeSubString(DTSubString sub)
	{
	}
}

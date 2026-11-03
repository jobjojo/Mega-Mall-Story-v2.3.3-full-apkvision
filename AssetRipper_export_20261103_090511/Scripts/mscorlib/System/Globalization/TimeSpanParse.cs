using System.Text;

namespace System.Globalization;

internal static class TimeSpanParse
{
	private enum ParseFailureKind : byte
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4
	}

	[Flags]
	private enum TimeSpanStandardStyles : byte
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = Invariant | Localized
	}

	private enum TTT : byte
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4
	}

	private ref struct TimeSpanToken
	{
		internal TTT _ttt = TTT.None;

		internal int _num = 0;

		internal int _zeroes = 0;

		internal ReadOnlySpan<char> _sep = default;

		public TimeSpanToken(TTT type)
		{
		}

		public TimeSpanToken(int number)
		{
		}

		public TimeSpanToken(int number, int leadingZeroes)
		{
		}

		public TimeSpanToken(TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator)
		{
		}

		public bool IsInvalidFraction()
		{
			return false;
		}
	}

	private ref struct TimeSpanTokenizer
	{
		private ReadOnlySpan<char> _value = default;

		private int _pos = 0;

		internal bool EOL => false;

		internal char NextChar => '\0';

		internal TimeSpanTokenizer(ReadOnlySpan<char> input)
		{
		}

		internal TimeSpanTokenizer(ReadOnlySpan<char> input, int startPosition)
		{
		}

		internal TimeSpanToken GetNextToken()
		{
			return default;
		}

		internal void BackOne()
		{
		}
	}

	private ref struct TimeSpanRawInfo
	{
		internal TTT _lastSeenTTT;

		internal int _tokenCount;

		internal int _sepCount;

		internal int _numCount;

		private TimeSpanFormat.FormatLiterals _posLoc;

		private TimeSpanFormat.FormatLiterals _negLoc;

		private bool _posLocInit;

		private bool _negLocInit;

		private string _fullPosPattern;

		private string _fullNegPattern;

		private const int MaxTokens = 11;

		private const int MaxLiteralTokens = 6;

		private const int MaxNumericTokens = 5;

		internal TimeSpanToken _numbers0;

		internal TimeSpanToken _numbers1;

		internal TimeSpanToken _numbers2;

		internal TimeSpanToken _numbers3;

		internal TimeSpanToken _numbers4;

		internal ReadOnlySpan<char> _literals0;

		internal ReadOnlySpan<char> _literals1;

		internal ReadOnlySpan<char> _literals2;

		internal ReadOnlySpan<char> _literals3;

		internal ReadOnlySpan<char> _literals4;

		internal ReadOnlySpan<char> _literals5;

		internal TimeSpanFormat.FormatLiterals PositiveInvariant => default;

		internal TimeSpanFormat.FormatLiterals NegativeInvariant => default;

		internal TimeSpanFormat.FormatLiterals PositiveLocalized => default;

		internal TimeSpanFormat.FormatLiterals NegativeLocalized => default;

		internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal void Init(DateTimeFormatInfo dtfi)
		{
		}

		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result)
		{
			return false;
		}

		private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanResult result)
		{
			return false;
		}

		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result)
		{
			return false;
		}
	}

	private struct TimeSpanResult
	{
		internal TimeSpan parsedTimeSpan = default;

		private readonly bool _throwOnFailure = false;

		internal TimeSpanResult(bool throwOnFailure)
		{
		}

		internal bool SetFailure(ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null)
		{
			return false;
		}
	}

	private ref struct StringParser
	{
		private ReadOnlySpan<char> _str;

		private char _ch;

		private int _pos;

		private int _len;

		internal void NextChar()
		{
		}

		internal char NextNonDigit()
		{
			return '\0';
		}

		internal bool TryParse(ReadOnlySpan<char> input, ref TimeSpanResult result)
		{
			return false;
		}

		internal bool ParseInt(int max, out int i, ref TimeSpanResult result)
		{
			i = default;
			return false;
		}

		internal bool ParseTime(out long time, ref TimeSpanResult result)
		{
			time = default;
			return false;
		}

		internal void SkipBlanks()
		{
		}
	}

	private const int MaxFractionDigits = 7;

	private const int MaxDays = 10675199;

	private const int MaxHours = 23;

	private const int MaxMinutes = 59;

	private const int MaxSeconds = 59;

	private const int MaxFraction = 9999999;

	internal static long Pow10(int pow)
	{
		return 0L;
	}

	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result)
	{
		result = default;
		return false;
	}

	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider)
	{
		return default;
	}

	internal static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result)
	{
		result = default;
		return false;
	}

	internal static TimeSpan ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles)
	{
		return default;
	}

	internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
	{
		result = default;
		return false;
	}

	internal static TimeSpan ParseExactMultiple(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
	{
		return default;
	}

	internal static bool TryParseExactMultiple(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
	{
		result = default;
		return false;
	}

	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ParseExactDigits(ref TimeSpanTokenizer tokenizer, int minDigitLength, out int result)
	{
		result = default;
		return false;
	}

	private static bool ParseExactDigits(ref TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result)
	{
		zeroes = default;
		result = default;
		return false;
	}

	private static bool ParseExactLiteral(ref TimeSpanTokenizer tokenizer, StringBuilder enquotedString)
	{
		return false;
	}

	private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool TryParseExactMultipleTimeSpan(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanResult result)
	{
		return false;
	}

	internal static void ValidateStyles(TimeSpanStyles style, string parameterName)
	{
	}
}

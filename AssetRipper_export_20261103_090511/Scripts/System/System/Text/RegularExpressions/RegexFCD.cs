using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal ref struct RegexFCD
{
	private readonly List<RegexFC> _fcStack = null;

	private ValueListBuilder<int> _intStack = default;

	private bool _skipAllChildren = false;

	private bool _skipchild = false;

	private bool _failed = false;

	private RegexFCD(Span<int> intStack)
	{
	}

	public static RegexPrefix? FirstChars(RegexTree t)
	{
		return null;
	}

	public static RegexPrefix Prefix(RegexTree tree)
	{
		return default;
	}

	public static int Anchors(RegexTree tree)
	{
		return 0;
	}

	private static int AnchorFromType(int type)
	{
		return 0;
	}

	private void PushInt(int i)
	{
	}

	private bool IntIsEmpty()
	{
		return false;
	}

	private int PopInt()
	{
		return 0;
	}

	private void PushFC(RegexFC fc)
	{
	}

	private bool FCIsEmpty()
	{
		return false;
	}

	private RegexFC PopFC()
	{
		return null;
	}

	private RegexFC TopFC()
	{
		return null;
	}

	public void Dispose()
	{
	}

	private RegexFC RegexFCFromRegexTree(RegexTree tree)
	{
		return null;
	}

	private void SkipChild()
	{
	}

	private void CalculateFC(int NodeType, RegexNode node, int CurIndex)
	{
	}
}

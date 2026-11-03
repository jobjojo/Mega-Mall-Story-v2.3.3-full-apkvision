using System.Collections;
using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal ref struct RegexWriter
{
	private ValueListBuilder<int> _emitted = default;

	private ValueListBuilder<int> _intStack = default;

	private readonly Dictionary<string, int> _stringHash = null;

	private readonly List<string> _stringTable = null;

	private Hashtable _caps = null;

	private int _trackCount = 0;

	private RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan)
	{
	}

	public static RegexCode Write(RegexTree tree)
	{
		return null;
	}

	public void Dispose()
	{
	}

	public RegexCode RegexCodeFromRegexTree(RegexTree tree)
	{
		return null;
	}

	private void PatchJump(int offset, int jumpDest)
	{
	}

	private void Emit(int op)
	{
	}

	private void Emit(int op, int opd1)
	{
	}

	private void Emit(int op, int opd1, int opd2)
	{
	}

	private int StringCode(string str)
	{
		return 0;
	}

	private int MapCapnum(int capnum)
	{
		return 0;
	}

	private void EmitFragment(int nodetype, RegexNode node, int curIndex)
	{
	}
}

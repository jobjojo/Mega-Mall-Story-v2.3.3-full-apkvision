using System.Diagnostics.CodeAnalysis;

namespace System.Dynamic.Utils;

internal static class ContractUtils
{
	[ExcludeFromCodeCoverage]
	public static Exception Unreachable => null;
}

using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

public abstract class Expression
{
	internal class LambdaExpressionProxy
	{
	}

	internal class MemberExpressionProxy
	{
	}

	internal class UnaryExpressionProxy
	{
	}

	private class ExtensionInfo
	{
		internal readonly ExpressionType NodeType;
	}

	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache;

	private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable;

	public virtual ExpressionType NodeType => ExpressionType.Add;
}
public class Expression<TDelegate> : LambdaExpression
{
}

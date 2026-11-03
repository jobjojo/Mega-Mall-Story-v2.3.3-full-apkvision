using System.Diagnostics;

namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression
{
	private readonly Expression _body;

	public Expression Body => null;
}

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading;

[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
public readonly struct CancellationToken
{
	private readonly CancellationTokenSource _source = null;

	private static readonly Action<object> s_actionToActionObjShunt;

	public static CancellationToken None => default;

	public bool IsCancellationRequested => false;

	public bool CanBeCanceled => false;

	internal CancellationToken(CancellationTokenSource source)
	{
	}

	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
	{
		return default;
	}

	public bool Equals(CancellationToken other)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(CancellationToken left, CancellationToken right)
	{
		return false;
	}

	public static bool operator !=(CancellationToken left, CancellationToken right)
	{
		return false;
	}

	public void ThrowIfCancellationRequested()
	{
	}

	private void ThrowOperationCanceledException()
	{
	}
}

namespace System.Runtime.CompilerServices;

public interface ICriticalNotifyCompletion
{
	void UnsafeOnCompleted(Action continuation);
}

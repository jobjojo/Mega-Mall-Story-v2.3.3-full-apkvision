namespace System.Threading;

public readonly struct AsyncLocalValueChangedArgs<T>
{
	private readonly T PreviousValue;

	private readonly bool ThreadContextChanged;

	public T CurrentValue { get; } = default;

	internal AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
	{
		this.PreviousValue__BackingField = default;
		this.ThreadContextChanged__BackingField = false;
	}
}

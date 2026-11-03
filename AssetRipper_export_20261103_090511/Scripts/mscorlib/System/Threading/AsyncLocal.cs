namespace System.Threading;

public sealed class AsyncLocal<T> : IAsyncLocal
{
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;

	public T Value
	{
		set
		{
		}
	}

	public AsyncLocal()
	{
	}

	public AsyncLocal(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
	{
	}

	void IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged)
	{
	}
}

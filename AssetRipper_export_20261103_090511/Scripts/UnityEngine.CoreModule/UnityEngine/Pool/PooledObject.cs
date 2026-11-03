using System;

namespace UnityEngine.Pool;

public struct PooledObject<T>(T value, IObjectPool<T> pool) : IDisposable where T : class
{
	private readonly T m_ToReturn = null;

	private readonly IObjectPool<T> m_Pool = null;

	void IDisposable.Dispose()
	{
	}
}

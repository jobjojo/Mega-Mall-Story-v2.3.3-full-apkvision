using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class WeakReference : ISerializable
{
	private bool isLongReference;

	private GCHandle gcHandle;

	public virtual bool IsAlive => false;

	public virtual object Target => null;

	public virtual bool TrackResurrection => false;

	private void AllocateHandle(object target)
	{
	}

	protected WeakReference()
	{
	}

	public WeakReference(object target)
	{
	}

	public WeakReference(object target, bool trackResurrection)
	{
	}

	protected WeakReference(SerializationInfo info, StreamingContext context)
	{
	}

	~WeakReference()
	{
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
[Serializable]
public sealed class WeakReference<T> : ISerializable where T : class
{
	private GCHandle handle;

	private bool trackResurrection;

	public WeakReference(T target)
	{
	}

	public WeakReference(T target, bool trackResurrection)
	{
	}

	private WeakReference(SerializationInfo info, StreamingContext context)
	{
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public void SetTarget(T target)
	{
	}

	public bool TryGetTarget(out T target)
	{
		target = null;
		return false;
	}

	~WeakReference()
	{
	}
}

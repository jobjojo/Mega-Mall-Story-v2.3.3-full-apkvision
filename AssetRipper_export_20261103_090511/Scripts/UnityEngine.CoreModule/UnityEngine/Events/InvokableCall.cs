using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UnityAction m_Delegate;

	private event UnityAction Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public void Invoke()
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1> : BaseInvokableCall
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UnityAction<T1> m_Delegate;

	protected event UnityAction<T1> Delegate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public InvokableCall(UnityAction<T1> action)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public virtual void Invoke(T1 args0)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1, T2> : BaseInvokableCall
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UnityAction<T1, T2> Delegate;

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UnityAction<T1, T2, T3> Delegate;

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}
internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UnityAction<T1, T2, T3, T4> Delegate;

	public InvokableCall(object target, MethodInfo theFunction)
	{
	}

	public override void Invoke(object[] args)
	{
	}

	public override bool Find(object targetObj, MethodInfo method)
	{
		return false;
	}
}

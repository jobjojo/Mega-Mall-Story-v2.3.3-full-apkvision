using System.Runtime.InteropServices;
using System.Runtime.Remoting;

namespace System;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class MarshalByRefObject
{
	[NonSerialized]
	private object _identity;

	internal ServerIdentity ObjectIdentity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual ObjRef CreateObjRef(Type requestedType)
	{
		return null;
	}

	public virtual object InitializeLifetimeService()
	{
		return null;
	}
}

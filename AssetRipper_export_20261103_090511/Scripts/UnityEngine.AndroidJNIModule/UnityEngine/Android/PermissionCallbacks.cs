using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Android;

public class PermissionCallbacks : AndroidJavaProxy
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<string> m_PermissionGranted;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> m_PermissionDenied;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<string> m_PermissionDeniedAndDontAskAgain;

	public event Action<string> PermissionGranted
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

	public event Action<string> PermissionDenied
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

	public event Action<string> PermissionDeniedAndDontAskAgain
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

	public PermissionCallbacks()
		: base((string)null)
	{
	}

	[Preserve]
	private void onPermissionGranted(string permissionName)
	{
	}

	[Preserve]
	private void onPermissionDenied(string permissionName)
	{
	}

	[Preserve]
	private void onPermissionDeniedAndDontAskAgain(string permissionName)
	{
	}
}

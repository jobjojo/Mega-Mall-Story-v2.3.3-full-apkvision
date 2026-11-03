using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace kairo.unity.system;

public class KairoAccount
{
	[CompilerGenerated]
	private sealed class _003CUpdUsrObjIdFromSrv_003Ed__15 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdUsrObjIdFromSrv_003Ed__15(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003COpenLoginPageCoroutine_003Ed__17 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private string _003Ckey_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003COpenLoginPageCoroutine_003Ed__17(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string PREF_USROBJID = "USR_OBJ_ID";

	private const string PREF_KEY = "KEY";

	private static string userObjectId_;

	private static Exception error_;

	private const string ENC_KEY_0 = "0";

	private const string ENC_KEY_1 = "1";

	private const string ENC_KEY_2 = "2";

	private const string ENC_KEY_3 = "3";

	private const string ENC_KEY_4 = "4";

	private const string ENC_PID_ERR_01 = "E101";

	private const string ENC_PID_ERR_02 = "E102";

	private const string ENC_USRID_ERR_01 = "E111";

	private const string ENC_FRIID_ERR_01 = "E121";

	private const string ENC_FRIID_ERR_02 = "E122";

	internal static bool IsOpendLoginPage { get; private set; }

	private static string Key => null;

	public static string UserObjectId => null;

	public static bool IsLogined => false;

	private static void UpdateUserObjectId()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdUsrObjIdFromSrv_003Ed__15))]
	private static IEnumerator UpdUsrObjIdFromSrv()
	{
		return null;
	}

	public static bool OpenLoginPage()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003COpenLoginPageCoroutine_003Ed__17))]
	private static IEnumerator OpenLoginPageCoroutine()
	{
		return null;
	}

	internal static void Resume()
	{
	}
}

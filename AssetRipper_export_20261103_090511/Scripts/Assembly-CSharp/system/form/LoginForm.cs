using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using form;
using kairo.unity.surface;
using kairo.unity.ui;
using main;

namespace system.form;

public class LoginForm : MyFormBase
{
	[CompilerGenerated]
	private sealed class _003CCheckOpenPage_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoginForm _003C_003E4__this;

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
		public _003CCheckOpenPage_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CGetUsrObjIdFromSrv_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string key;

		public LoginForm _003C_003E4__this;

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
		public _003CGetUsrObjIdFromSrv_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003COpenFriendSearch_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoginForm _003C_003E4__this;

		private string _003Ckey_003E5__2;

		private string _003CencUsrObjId_003E5__3;

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
		public _003COpenFriendSearch_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003COpenLoginPage_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoginForm _003C_003E4__this;

		private string _003Ckey_003E5__2;

		private string _003CencPid_003E5__3;

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
		public _003COpenLoginPage_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003COpenMyPage_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoginForm _003C_003E4__this;

		private string _003Ckey_003E5__2;

		private string _003CencUsrObjId_003E5__3;

		private string _003CencPid_003E5__4;

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
		public _003COpenMyPage_003Ed__39(int _003C_003E1__state)
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

	public const int FORMID_LOGIN = 911;

	public const int TYPE_MYPAGE = 0;

	public const int TYPE_LOGIN = 1;

	public const int TYPE_RESET = 0;

	public const int TYPE_CANCEL = 1;

	private const int FILL_MARGIN_W = 4;

	private const int FILL_MARGIN_H = 1;

	public const string ENC_KEY_0 = "0";

	public const string ENC_KEY_1 = "1";

	public const string ENC_KEY_2 = "2";

	public const string ENC_KEY_3 = "3";

	public const string ENC_KEY_4 = "4";

	public const string ENC_PID_ERR_01 = "E101";

	public const string ENC_PID_ERR_02 = "E102";

	public const string ENC_USRID_ERR_01 = "E111";

	public const string ENC_USRID_ERR_02 = "E112";

	public const string ENC_FRIID_ERR_01 = "E121";

	public const string ENC_FRIID_ERR_02 = "E122";

	internal new IApplication app_;

	internal Main main_;

	internal new FormManager formMan_;

	private int select_;

	public const int WND_TYPE_MYPAGE_RELOGIN = 0;

	public const int WND_TYPE_RESET_CANCEL = 1;

	private int type_;

	private string[][] selectButtons_;

	private static long touchBegin_;

	private static string msg_;

	private static bool flgLogin;

	public override string ToString()
	{
		return null;
	}

	public LoginForm(int type = -1)
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public override bool Update()
	{
		return false;
	}

	public static void DrawButton(Graphics g, int x, int y)
	{
	}

	public new static bool OnTouchEvent(TouchEvent e)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCheckOpenPage_003Ed__35))]
	public IEnumerator CheckOpenPage()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenLoginPage_003Ed__38))]
	public IEnumerator OpenLoginPage()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenMyPage_003Ed__39))]
	public IEnumerator OpenMyPage()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenFriendSearch_003Ed__40))]
	public IEnumerator OpenFriendSearch()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetUsrObjIdFromSrv_003Ed__41))]
	public IEnumerator GetUsrObjIdFromSrv(string key)
	{
		return null;
	}

	public static string GetUsrObjId()
	{
		return null;
	}

	public void ResetUsrObjId()
	{
	}

	public static bool IsLogined()
	{
		return false;
	}

	public static bool isOpenLoginPage()
	{
		return false;
	}

	public static string GetKey()
	{
		return null;
	}

	public static void SetKey()
	{
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}
}

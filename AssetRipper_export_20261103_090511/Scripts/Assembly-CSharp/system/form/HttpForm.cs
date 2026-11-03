using System;
using System.Collections;
using System.Collections.Generic;
using form;
using java.lang;
using kairo.unity.ui;

namespace system.form;

public class HttpForm : MyFormBase, JRunnable
{
	public class ResultData : IEnumerable
	{
		private Dictionary<string, object> data_;

		public Exception Exception { get; set; }

		public string Error { get; set; }

		public bool Succeed { get; set; }

		public void Add(string key, object data)
		{
		}

		public object Get(string key)
		{
			return null;
		}

		public bool HasKey(string key)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public delegate void HttpMethod(HttpForm form, ResultData data);

	public const int FORMID_HTTP = 909;

	private HttpMethod connectMethod_;

	private HttpMethod resultMethod_;

	private static int THSTATE_NONE;

	private static int THSTATE_RUN;

	private static int THSTATE_SUCCESS;

	private static int THSTATE_FAILURE;

	private int threadState_;

	private JThread thread_;

	private ResultData resultData_;

	private Dictionary<string, object> commonData_;

	public bool ProcessError { get; set; }

	public bool IsCancelable { get; set; }

	public override string ToString()
	{
		return null;
	}

	public HttpForm(HttpMethod connectMethod = null, HttpMethod resultMethod = null)
		: base(0)
	{
	}

	public void SetConnectMethod(HttpMethod method)
	{
	}

	public void SetResultMethod(HttpMethod method)
	{
	}

	public override bool Init()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	public static void DrawConnect(Graphics g)
	{
	}

	public override bool Update()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
	}

	public override bool CheckMainWindow()
	{
		return false;
	}

	public void Run()
	{
	}
}

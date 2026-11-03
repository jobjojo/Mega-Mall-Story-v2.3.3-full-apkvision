using System;
using UnityEngine;

namespace kairo.unity.io;

public class HttpObject
{
	protected WWW http_;

	protected string errorUrl_;

	protected int errorCode_;

	protected string errorText_;

	protected string errorTextOrg_;

	protected Exception error_;

	protected bool askRetry_;

	protected bool interrupted_;

	internal bool IsRetryEnable { get; set; }

	public HttpObject(bool retryEnable = false)
	{
	}

	public byte[] Connect(string url, byte[] send, bool check)
	{
		return null;
	}

	public byte[][] Connect(string url, byte[] send, bool check, bool split)
	{
		return null;
	}

	private byte[][] _connect(string url, byte[] send, bool check, bool split)
	{
		return null;
	}

	public void Interrupt()
	{
	}

	public bool IsConnect()
	{
		return false;
	}

	public int GetErrorCode()
	{
		return 0;
	}

	public string GetErrorText()
	{
		return null;
	}

	public string GetErrorText2()
	{
		return null;
	}

	public string GetErrorUrl()
	{
		return null;
	}

	public int PopErrorCode()
	{
		return 0;
	}

	public string PopErrorText()
	{
		return null;
	}

	public string PopErrorUrl()
	{
		return null;
	}

	private string GetTimeStampParam()
	{
		return null;
	}
}

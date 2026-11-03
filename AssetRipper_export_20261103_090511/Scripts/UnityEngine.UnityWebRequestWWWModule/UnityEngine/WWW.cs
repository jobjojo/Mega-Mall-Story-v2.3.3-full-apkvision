using System;
using UnityEngine.Networking;

namespace UnityEngine;

[Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
public class WWW : CustomYieldInstruction, IDisposable
{
	private UnityWebRequest _uwr;

	public byte[] bytes => null;

	public string error => null;

	public bool isDone => false;

	public string text => null;

	public string url => null;

	public override bool keepWaiting => false;

	public WWW(string url)
	{
	}

	public WWW(string url, WWWForm form)
	{
	}

	public WWW(string url, byte[] postData)
	{
	}

	public void Dispose()
	{
	}

	private bool WaitUntilDoneIfPossible()
	{
		return false;
	}
}

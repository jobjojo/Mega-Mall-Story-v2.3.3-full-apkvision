using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace kairo.unity.util;

public static class SNSShareUtil
{
	public delegate void OnCaptureCompleted();

	private class ShareBehaviour : MonoBehaviour
	{
	}

	[CompilerGenerated]
	private sealed class _003CShare_003Ed__6 : IEnumerator<object>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string imagePath;

		public string text;

		public string url;

		public GameObject obj;

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
		public _003CShare_003Ed__6(int _003C_003E1__state)
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

	public static void ShareText(string text, string url)
	{
	}

	public static void ShareScreenshot(string text, string url, OnCaptureCompleted method = null)
	{
	}

	private static void ShareScreenshot2(string text, string url, OnCaptureCompleted method = null)
	{
	}

	private static void Share(string text, string url, string imagePath = null)
	{
	}

	[IteratorStateMachine(typeof(_003CShare_003Ed__6))]
	private static IEnumerator Share(GameObject obj, string text, string url, string imagePath = null)
	{
		return null;
	}

	private static string[] GetCaptureTables()
	{
		return null;
	}
}

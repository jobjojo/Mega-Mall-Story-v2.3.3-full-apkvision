using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout((LayoutKind)0, Size = 1)]
public struct InputEventListener : IObservable<InputEventPtr>
{
	internal class ObserverState
	{
		public InlinedArray<IObserver<InputEventPtr>> observers;

		public Action<InputEventPtr, InputDevice> onEventDelegate;
	}

	private class DisposableObserver : IDisposable
	{
		public IObserver<InputEventPtr> observer;

		public void Dispose()
		{
		}
	}

	internal static ObserverState s_ObserverState;

	public static InputEventListener operator +(InputEventListener _, Action<InputEventPtr, InputDevice> callback)
	{
		return default;
	}

	public static InputEventListener operator -(InputEventListener _, Action<InputEventPtr, InputDevice> callback)
	{
		return default;
	}

	public IDisposable Subscribe(IObserver<InputEventPtr> observer)
	{
		return null;
	}
}

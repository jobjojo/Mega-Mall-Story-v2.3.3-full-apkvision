using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities;

public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IEnumerable, IDisposable
{
	public struct ActionEventPtr
	{
		internal InputActionState m_State;

		internal unsafe ActionEvent* m_Ptr;

		public InputAction action => null;

		public InputActionPhase phase => InputActionPhase.Disabled;

		public InputControl control => null;

		public IInputInteraction interaction => null;

		public double time => 0.0;

		public double startTime => 0.0;

		public double duration => 0.0;

		public int valueSizeInBytes => 0;

		public object ReadValueAsObject()
		{
			return null;
		}

		public unsafe void ReadValue(void* buffer, int bufferSize)
		{
		}

		public TValue ReadValue<TValue>() where TValue : struct
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}

	private unsafe struct Enumerator(InputActionTrace trace) : IEnumerator<ActionEventPtr>, IEnumerator, IDisposable
	{
		private readonly InputActionTrace m_Trace = null;

		private unsafe readonly ActionEvent* m_Buffer = null;

		private readonly int m_EventCount = 0;

		private unsafe ActionEvent* m_CurrentEvent = null;

		private int m_CurrentIndex = 0;

		public ActionEventPtr Current => default;

		object IEnumerator.Current => null;

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	private bool m_SubscribedToAll;

	private bool m_OnActionChangeHooked;

	private InlinedArray<InputAction> m_SubscribedActions;

	private InlinedArray<InputActionMap> m_SubscribedActionMaps;

	private InputEventBuffer m_EventBuffer;

	private InlinedArray<InputActionState> m_ActionMapStates;

	private InlinedArray<InputActionState> m_ActionMapStateClones;

	private Action<InputAction.CallbackContext> m_CallbackDelegate;

	private Action<object, InputActionChange> m_ActionChangeDelegate;

	public InputEventBuffer buffer => default;

	public int count => 0;

	public InputActionTrace()
	{
	}

	public InputActionTrace(InputAction action)
	{
	}

	public InputActionTrace(InputActionMap actionMap)
	{
	}

	public void SubscribeToAll()
	{
	}

	public void UnsubscribeFromAll()
	{
	}

	public void SubscribeTo(InputAction action)
	{
	}

	public void SubscribeTo(InputActionMap actionMap)
	{
	}

	public void UnsubscribeFrom(InputAction action)
	{
	}

	public void UnsubscribeFrom(InputActionMap actionMap)
	{
	}

	public void RecordAction(InputAction.CallbackContext context)
	{
	}

	public void Clear()
	{
	}

	~InputActionTrace()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void Dispose()
	{
	}

	private void DisposeInternal()
	{
	}

	public IEnumerator<ActionEventPtr> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private void HookOnActionChange()
	{
	}

	private void UnhookOnActionChange()
	{
	}

	private void OnActionChange(object actionOrMapOrAsset, InputActionChange change)
	{
	}

	private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap)
	{
	}
}

using System;
using System.Reflection;
using UnityEngine.Serialization;

namespace UnityEngine.Events;

[Serializable]
internal class PersistentCall : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("instance")]
	[SerializeField]
	private Object m_Target;

	[SerializeField]
	private string m_TargetAssemblyTypeName;

	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName;

	[SerializeField]
	[FormerlySerializedAs("mode")]
	private PersistentListenerMode m_Mode;

	[SerializeField]
	[FormerlySerializedAs("arguments")]
	private ArgumentCache m_Arguments;

	[FormerlySerializedAs("m_Enabled")]
	[FormerlySerializedAs("enabled")]
	[SerializeField]
	private UnityEventCallState m_CallState;

	public Object target => null;

	public string targetAssemblyTypeName => null;

	public string methodName => null;

	public PersistentListenerMode mode => PersistentListenerMode.EventDefined;

	public ArgumentCache arguments => null;

	public bool IsValid()
	{
		return false;
	}

	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
	{
		return null;
	}

	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
	{
		return null;
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}

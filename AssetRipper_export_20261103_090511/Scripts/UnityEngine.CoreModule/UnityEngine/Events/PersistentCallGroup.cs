using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events;

[Serializable]
internal class PersistentCallGroup
{
	[SerializeField]
	[FormerlySerializedAs("m_Listeners")]
	private List<PersistentCall> m_Calls;

	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
	{
	}
}

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Transform/Transform.h")]
[RequiredByNativeCode]
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer;

		private int currentIndex;

		public object Current => null;

		internal Enumerator(Transform outer)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 localPosition
	{
		set
		{
		}
	}

	public Quaternion rotation => default;

	public Quaternion localRotation
	{
		set
		{
		}
	}

	public Transform parent
	{
		set
		{
		}
	}

	internal Transform parentInternal
	{
		set
		{
		}
	}

	public int childCount
	{
		[NativeMethod("GetChildrenCount")]
		get
		{
			return 0;
		}
	}

	protected Transform()
	{
	}

	public void SetParent(Transform p)
	{
	}

	[FreeFunction("SetParent", HasExplicitThis = true)]
	public void SetParent(Transform parent, bool worldPositionStays)
	{
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[FreeFunction("GetChild", HasExplicitThis = true)]
	[NativeThrows]
	public Transform GetChild(int index)
	{
		return null;
	}

	[SpecialName]
	private void get_position_Injected(out Vector3 ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_position_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void set_localPosition_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_rotation_Injected(out Quaternion ret)
	{
		ret = default;
	}

	[SpecialName]
	private void set_localRotation_Injected(ref Quaternion value)
	{
	}
}

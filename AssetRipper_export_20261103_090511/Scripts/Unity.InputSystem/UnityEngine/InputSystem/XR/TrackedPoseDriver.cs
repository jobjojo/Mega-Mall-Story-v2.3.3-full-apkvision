using System;

namespace UnityEngine.InputSystem.XR;

[Serializable]
[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
{
	public enum TrackingType
	{
		RotationAndPosition = 0,
		RotationOnly = 1,
		PositionOnly = 2
	}

	public enum UpdateType
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2
	}

	[SerializeField]
	private TrackingType m_TrackingType;

	[SerializeField]
	private UpdateType m_UpdateType;

	[SerializeField]
	private InputActionProperty m_PositionInput;

	[SerializeField]
	private InputActionProperty m_RotationInput;

	private Vector3 m_CurrentPosition;

	private Quaternion m_CurrentRotation;

	private bool m_RotationBound;

	private bool m_PositionBound;

	[SerializeField]
	[HideInInspector]
	[Obsolete]
	private InputAction m_PositionAction;

	[HideInInspector]
	[SerializeField]
	[Obsolete]
	private InputAction m_RotationAction;

	[HideInInspector]
	[SerializeField]
	private bool m_HasMigratedActions;

	public TrackingType trackingType
	{
		get
		{
			return TrackingType.RotationAndPosition;
		}
		set
		{
		}
	}

	public UpdateType updateType
	{
		get
		{
			return UpdateType.UpdateAndBeforeRender;
		}
		set
		{
		}
	}

	public InputActionProperty positionInput
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public InputActionProperty rotationInput
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public InputAction positionAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public InputAction rotationAction
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void BindActions()
	{
	}

	private void BindPosition()
	{
	}

	private void BindRotation()
	{
	}

	private void UnbindActions()
	{
	}

	private void UnbindPosition()
	{
	}

	private void UnbindRotation()
	{
	}

	private void OnPositionPerformed(InputAction.CallbackContext context)
	{
	}

	private void OnPositionCanceled(InputAction.CallbackContext context)
	{
	}

	private void OnRotationPerformed(InputAction.CallbackContext context)
	{
	}

	private void OnRotationCanceled(InputAction.CallbackContext context)
	{
	}

	protected virtual void Awake()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected void UpdateCallback()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	protected virtual void OnBeforeRender()
	{
	}

	protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation)
	{
	}

	private bool HasStereoCamera()
	{
		return false;
	}

	protected virtual void PerformUpdate()
	{
	}

	protected void Reset()
	{
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}
}

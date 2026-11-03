using System;

namespace UnityEngine.InputSystem;

public static class InputActionSetupExtensions
{
	public struct BindingSyntax
	{
		private readonly InputActionMap m_ActionMap = null;

		private readonly InputAction m_Action = null;

		internal readonly int m_BindingIndexInMap = 0;

		public bool valid => false;

		public int bindingIndex => 0;

		public InputBinding binding => default;

		internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null)
		{
		}

		public BindingSyntax WithName(string name)
		{
			return default;
		}

		public BindingSyntax WithPath(string path)
		{
			return default;
		}

		public BindingSyntax WithGroup(string group)
		{
			return default;
		}

		public BindingSyntax WithGroups(string groups)
		{
			return default;
		}

		public BindingSyntax WithInteraction(string interaction)
		{
			return default;
		}

		public BindingSyntax WithInteractions(string interactions)
		{
			return default;
		}

		public BindingSyntax WithInteraction<TInteraction>() where TInteraction : IInputInteraction
		{
			return default;
		}

		public BindingSyntax WithProcessor(string processor)
		{
			return default;
		}

		public BindingSyntax WithProcessors(string processors)
		{
			return default;
		}

		public BindingSyntax WithProcessor<TProcessor>()
		{
			return default;
		}

		public BindingSyntax Triggering(InputAction action)
		{
			return default;
		}

		public BindingSyntax To(InputBinding binding)
		{
			return default;
		}

		public BindingSyntax NextBinding()
		{
			return default;
		}

		public BindingSyntax PreviousBinding()
		{
			return default;
		}

		public BindingSyntax NextPartBinding(string partName)
		{
			return default;
		}

		public BindingSyntax PreviousPartBinding(string partName)
		{
			return default;
		}

		public BindingSyntax NextCompositeBinding(string compositeName = null)
		{
			return default;
		}

		public BindingSyntax PreviousCompositeBinding(string compositeName = null)
		{
			return default;
		}

		private BindingSyntax Iterate(bool next)
		{
			return default;
		}

		private BindingSyntax IterateCompositeBinding(bool next, string compositeName)
		{
			return default;
		}

		private BindingSyntax IteratePartBinding(bool next, string partName)
		{
			return default;
		}

		public void Erase()
		{
		}

		public BindingSyntax InsertPartBinding(string partName, string path)
		{
			return default;
		}
	}

	public struct CompositeSyntax
	{
		private readonly InputAction m_Action = null;

		private readonly InputActionMap m_ActionMap = null;

		private int m_BindingIndexInMap = 0;

		public int bindingIndex => 0;

		internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex)
		{
		}

		public CompositeSyntax With(string name, string binding, string groups = null, string processors = null)
		{
			return default;
		}
	}

	public struct ControlSchemeSyntax
	{
		private readonly InputActionAsset m_Asset = null;

		private readonly int m_ControlSchemeIndex = 0;

		private InputControlScheme m_ControlScheme = default;

		internal ControlSchemeSyntax(InputActionAsset asset, int index)
		{
		}

		internal ControlSchemeSyntax(InputControlScheme controlScheme)
		{
		}

		public ControlSchemeSyntax WithBindingGroup(string bindingGroup)
		{
			return default;
		}

		public ControlSchemeSyntax WithRequiredDevice<TDevice>() where TDevice : InputDevice
		{
			return default;
		}

		public ControlSchemeSyntax WithOptionalDevice<TDevice>() where TDevice : InputDevice
		{
			return default;
		}

		public ControlSchemeSyntax OrWithRequiredDevice<TDevice>() where TDevice : InputDevice
		{
			return default;
		}

		public ControlSchemeSyntax OrWithOptionalDevice<TDevice>() where TDevice : InputDevice
		{
			return default;
		}

		public ControlSchemeSyntax WithRequiredDevice(string controlPath)
		{
			return default;
		}

		public ControlSchemeSyntax WithOptionalDevice(string controlPath)
		{
			return default;
		}

		public ControlSchemeSyntax OrWithRequiredDevice(string controlPath)
		{
			return default;
		}

		public ControlSchemeSyntax OrWithOptionalDevice(string controlPath)
		{
			return default;
		}

		private string DeviceTypeToControlPath<TDevice>() where TDevice : InputDevice
		{
			return null;
		}

		public InputControlScheme Done()
		{
			return default;
		}

		private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags)
		{
		}
	}

	public static InputActionMap AddActionMap(this InputActionAsset asset, string name)
	{
		return null;
	}

	public static void AddActionMap(this InputActionAsset asset, InputActionMap map)
	{
	}

	public static void RemoveActionMap(this InputActionAsset asset, InputActionMap map)
	{
	}

	public static void RemoveActionMap(this InputActionAsset asset, string nameOrId)
	{
	}

	public static InputAction AddAction(this InputActionMap map, string name, InputActionType type = InputActionType.Value, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null)
	{
		return null;
	}

	public static void RemoveAction(this InputAction action)
	{
	}

	public static void RemoveAction(this InputActionAsset asset, string nameOrId)
	{
	}

	public static BindingSyntax AddBinding(this InputAction action, string path, string interactions = null, string processors = null, string groups = null)
	{
		return default;
	}

	public static BindingSyntax AddBinding(this InputAction action, InputControl control)
	{
		return default;
	}

	public static BindingSyntax AddBinding(this InputAction action, InputBinding binding = default(InputBinding))
	{
		return default;
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null)
	{
		return default;
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null)
	{
		return default;
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null)
	{
		return default;
	}

	public static BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding)
	{
		return default;
	}

	public static CompositeSyntax AddCompositeBinding(this InputAction action, string composite, string interactions = null, string processors = null)
	{
		return default;
	}

	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1)
	{
		return 0;
	}

	public static BindingSyntax ChangeBinding(this InputAction action, int index)
	{
		return default;
	}

	public static BindingSyntax ChangeBinding(this InputAction action, string name)
	{
		return default;
	}

	public static BindingSyntax ChangeBinding(this InputActionMap actionMap, int index)
	{
		return default;
	}

	public static BindingSyntax ChangeBindingWithId(this InputAction action, string id)
	{
		return default;
	}

	public static BindingSyntax ChangeBindingWithId(this InputAction action, Guid id)
	{
		return default;
	}

	public static BindingSyntax ChangeBindingWithGroup(this InputAction action, string group)
	{
		return default;
	}

	public static BindingSyntax ChangeBindingWithPath(this InputAction action, string path)
	{
		return default;
	}

	public static BindingSyntax ChangeBinding(this InputAction action, InputBinding match)
	{
		return default;
	}

	public static BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName)
	{
		return default;
	}

	public static void Rename(this InputAction action, string newName)
	{
	}

	public static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme)
	{
	}

	public static ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name)
	{
		return default;
	}

	public static void RemoveControlScheme(this InputActionAsset asset, string name)
	{
	}

	public static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup)
	{
		return default;
	}

	public static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required)
	{
		return default;
	}

	public static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath)
	{
		return default;
	}

	public static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath)
	{
		return default;
	}

	public static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath)
	{
		return default;
	}

	public static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath)
	{
		return default;
	}
}

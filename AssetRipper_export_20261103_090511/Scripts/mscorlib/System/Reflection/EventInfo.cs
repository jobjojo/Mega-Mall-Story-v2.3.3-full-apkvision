using Mono;

namespace System.Reflection;

[Serializable]
public abstract class EventInfo : MemberInfo
{
	private delegate void AddEventAdapter(object _this, Delegate dele);

	private AddEventAdapter cached_add_event;

	public override MemberTypes MemberType => (MemberTypes)0;

	public virtual Type EventHandlerType => null;

	public abstract MethodInfo GetAddMethod(bool nonPublic);

	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(EventInfo left, EventInfo right)
	{
		return false;
	}

	public static bool operator !=(EventInfo left, EventInfo right)
	{
		return false;
	}

	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
	{
		return null;
	}

	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
	{
		return null;
	}
}

using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[ComVisible(true)]
public class ObjectManager
{
	private DeserializationEventHandler m_onDeserializationHandler;

	private SerializationEventHandler m_onDeserializedHandler;

	internal ObjectHolder[] m_objects;

	internal object m_topObject;

	internal ObjectHolderList m_specialFixupObjects;

	internal long m_fixupCount;

	internal ISurrogateSelector m_selector;

	internal StreamingContext m_context;

	internal object TopObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ObjectHolderList SpecialFixupObjects => null;

	internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
	{
	}

	private bool CanCallGetType(object obj)
	{
		return false;
	}

	internal ObjectHolder FindObjectHolder(long objectID)
	{
		return null;
	}

	internal ObjectHolder FindOrCreateObjectHolder(long objectID)
	{
		return null;
	}

	private void AddObjectHolder(ObjectHolder holder)
	{
	}

	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing)
	{
		holder = null;
		member = null;
		return false;
	}

	private void FixupSpecialObject(ObjectHolder holder)
	{
	}

	private bool ResolveObjectReference(ObjectHolder holder)
	{
		return false;
	}

	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value)
	{
		return false;
	}

	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
	{
	}

	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
	{
	}

	public virtual object GetObject(long objectID)
	{
		return null;
	}

	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
	{
	}

	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex)
	{
	}

	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context)
	{
	}

	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t)
	{
		return null;
	}

	public virtual void DoFixups()
	{
	}

	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
	{
	}

	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
	{
	}

	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
	{
	}

	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
	{
	}

	public virtual void RaiseDeserializationEvent()
	{
	}

	internal virtual void AddOnDeserialization(DeserializationEventHandler handler)
	{
	}

	internal virtual void AddOnDeserialized(object obj)
	{
	}

	internal virtual void RaiseOnDeserializedEvent(object obj)
	{
	}

	public void RaiseOnDeserializingEvent(object obj)
	{
	}
}

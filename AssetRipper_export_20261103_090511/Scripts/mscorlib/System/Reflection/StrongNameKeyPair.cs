using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback
{
	private byte[] _publicKey;

	private string _keyPairContainer;

	private bool _keyPairExported;

	private byte[] _keyPairArray;

	protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}
}

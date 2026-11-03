using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security;

[Serializable]
[ComVisible(true)]
public class SecurityException : SystemException
{
	private string permissionState;

	public SecurityException()
	{
	}

	public SecurityException(string message)
	{
	}

	protected SecurityException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

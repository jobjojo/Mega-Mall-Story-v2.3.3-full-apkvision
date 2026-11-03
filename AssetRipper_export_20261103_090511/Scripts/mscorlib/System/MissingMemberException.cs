using System.Runtime.Serialization;

namespace System;

[Serializable]
public class MissingMemberException : MemberAccessException
{
	protected string ClassName;

	protected string MemberName;

	protected byte[] Signature;

	public override string Message => null;

	public MissingMemberException()
	{
	}

	public MissingMemberException(string message)
	{
	}

	protected MissingMemberException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static string FormatSignature(byte[] signature)
	{
		return null;
	}
}

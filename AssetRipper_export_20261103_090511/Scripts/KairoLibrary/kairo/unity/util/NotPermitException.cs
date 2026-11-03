using System;

namespace kairo.unity.util;

public class NotPermitException : KairoException
{
	public enum PermissionType
	{
		Storage = 0
	}

	private PermissionType type_;

	public PermissionType Type => PermissionType.Storage;

	public NotPermitException(PermissionType type, string message, string displayMessage, Exception exception)
		: base(null)
	{
	}

	public NotPermitException(PermissionType type, string message, Exception exception)
		: base(null)
	{
	}

	public override string ToString()
	{
		return null;
	}
}

using System;

namespace kairo.unity.util;

public class KairoException : Exception
{
	protected string displayMessage_;

	public string DisplayMessage => null;

	public KairoException(string displayMessage)
	{
	}

	public KairoException(string message, string displayMessage, Exception exception)
	{
	}
}

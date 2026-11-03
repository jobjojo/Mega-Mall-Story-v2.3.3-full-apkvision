using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
public class CultureNotFoundException : ArgumentException
{
	private string _invalidCultureName;

	private int? _invalidCultureId;

	public virtual int? InvalidCultureId => null;

	public virtual string InvalidCultureName => null;

	private static string DefaultMessage => null;

	private string FormatedInvalidCultureId => null;

	public override string Message => null;

	public CultureNotFoundException()
	{
	}

	public CultureNotFoundException(string message)
	{
	}

	public CultureNotFoundException(string paramName, string message)
	{
	}

	public CultureNotFoundException(string message, Exception innerException)
	{
	}

	public CultureNotFoundException(string paramName, string invalidCultureName, string message)
	{
	}

	public CultureNotFoundException(string message, string invalidCultureName, Exception innerException)
	{
	}

	public CultureNotFoundException(string message, int invalidCultureId, Exception innerException)
	{
	}

	public CultureNotFoundException(string paramName, int invalidCultureId, string message)
	{
	}

	protected CultureNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}

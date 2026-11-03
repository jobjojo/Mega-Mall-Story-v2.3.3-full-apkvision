using System.Collections;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class Exception : ISerializable
{
	internal enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3
	}

	[OptionalField]
	private static object s_EDILock;

	private string _className;

	internal string _message;

	private IDictionary _data;

	private Exception _innerException;

	private string _helpURL;

	private object _stackTrace;

	private string _stackTraceString;

	private string _remoteStackTraceString;

	private int _remoteStackIndex;

	private object _dynamicMethods;

	internal int _HResult;

	private string _source;

	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager;

	internal StackTrace[] captured_traces;

	private IntPtr[] native_trace_ips;

	private int caught_in_unmanaged;

	private const int _COMPlusExceptionCode = -532462766;

	public virtual string Message => null;

	public virtual IDictionary Data => null;

	public Exception InnerException => null;

	public virtual string StackTrace => null;

	public virtual string Source => null;

	public int HResult
	{
		get
		{
			return 0;
		}
		protected set
		{
		}
	}

	private void Init()
	{
	}

	public Exception()
	{
	}

	public Exception(string message)
	{
	}

	public Exception(string message, Exception innerException)
	{
	}

	protected Exception(SerializationInfo info, StreamingContext context)
	{
	}

	private string GetClassName()
	{
		return null;
	}

	private string GetStackTrace(bool needFileInfo)
	{
		return null;
	}

	internal void SetErrorCode(int hr)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private string ToString(bool needFileLineInfo, bool needMessage)
	{
		return null;
	}

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
	}

	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
	{
		return null;
	}

	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
	{
	}

	public new Type GetType()
	{
		return null;
	}

	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind)
	{
		return null;
	}

	internal Exception FixRemotingException()
	{
		return null;
	}

	internal static void ReportUnhandledException(Exception exception)
	{
	}
}

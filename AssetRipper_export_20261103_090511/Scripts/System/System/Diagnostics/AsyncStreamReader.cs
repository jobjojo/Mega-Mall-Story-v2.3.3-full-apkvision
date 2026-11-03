using System.Collections;
using System.IO;
using System.Text;
using System.Threading;

namespace System.Diagnostics;

internal class AsyncStreamReader : IDisposable
{
	internal const int DefaultBufferSize = 1024;

	private const int MinBufferSize = 128;

	private Stream stream;

	private Encoding encoding;

	private Decoder decoder;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private int _maxCharsPerBuffer;

	private Process process;

	private UserCallBack userCallBack;

	private bool cancelOperation;

	private ManualResetEvent eofEvent;

	private Queue messageQueue;

	private StringBuilder sb;

	private bool bLastCarriageReturn;

	private int currentLinePos;

	private object syncObject;

	private IAsyncResult asyncReadResult;

	public virtual void Close()
	{
	}

	void IDisposable.Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal void CancelOperation()
	{
	}

	internal void WaitUtilEOF()
	{
	}
}

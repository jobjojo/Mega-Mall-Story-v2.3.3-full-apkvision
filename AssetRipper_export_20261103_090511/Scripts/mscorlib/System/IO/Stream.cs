using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable
{
	private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
	{
		internal readonly bool _isRead;

		internal readonly bool _apm;

		internal Stream _stream;

		internal byte[] _buffer;

		internal readonly int _offset;

		internal readonly int _count;

		private AsyncCallback _callback;

		private ExecutionContext _context;

		private static ContextCallback s_invokeAsyncCallback;

		bool ITaskCompletionAction.InvokeMayRunArbitraryCode => false;

		internal void ClearBeginState()
		{
		}

		public ReadWriteTask(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback)
		{
		}

		private static void InvokeAsyncCallback(object completedTask)
		{
		}

		void ITaskCompletionAction.Invoke(Task completingTask)
		{
		}
	}

	private sealed class NullStream : Stream
	{
		private static readonly Task<int> s_zeroTask;

		public override bool CanRead => false;

		public override bool CanWrite => false;

		public override bool CanSeek => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal NullStream()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override int Read(Span<byte> buffer)
		{
			return 0;
		}

		public override int ReadByte()
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Write(ReadOnlySpan<byte> buffer)
		{
		}

		public override void WriteByte(byte value)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long length)
		{
		}
	}

	private sealed class SynchronousAsyncResult : IAsyncResult
	{
		private readonly object _stateObject;

		private readonly bool _isWrite;

		private ManualResetEvent _waitHandle;

		private ExceptionDispatchInfo _exceptionInfo;

		private bool _endXxxCalled;

		private int _bytesRead;

		public bool IsCompleted => false;

		public WaitHandle AsyncWaitHandle => null;

		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
		{
		}

		internal SynchronousAsyncResult(object asyncStateObject)
		{
		}

		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite)
		{
		}

		internal void ThrowIfError()
		{
		}

		internal static int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		internal static void EndWrite(IAsyncResult asyncResult)
		{
		}
	}

	public static readonly Stream Null;

	private const int DefaultCopyBufferSize = 81920;

	[NonSerialized]
	private ReadWriteTask _activeReadWriteTask;

	[NonSerialized]
	private SemaphoreSlim _asyncActiveSemaphore;

	public abstract bool CanRead { get; }

	public abstract bool CanSeek { get; }

	public abstract bool CanWrite { get; }

	public abstract long Length { get; }

	public abstract long Position { get; set; }

	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
	{
		return null;
	}

	public virtual void Close()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public abstract void Flush();

	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
	{
		return null;
	}

	public virtual int EndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
	{
		return null;
	}

	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask)
	{
	}

	private void RunReadWriteTask(ReadWriteTask readWriteTask)
	{
	}

	private void FinishTrackingAsyncOperation()
	{
	}

	public virtual void EndWrite(IAsyncResult asyncResult)
	{
	}

	public abstract long Seek(long offset, SeekOrigin origin);

	public abstract void SetLength(long value);

	public abstract int Read(byte[] buffer, int offset, int count);

	public virtual int Read(Span<byte> buffer)
	{
		return 0;
	}

	public virtual int ReadByte()
	{
		return 0;
	}

	public abstract void Write(byte[] buffer, int offset, int count);

	public virtual void Write(ReadOnlySpan<byte> buffer)
	{
	}

	public virtual void WriteByte(byte value)
	{
	}

	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal static int BlockingEndRead(IAsyncResult asyncResult)
	{
		return 0;
	}

	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	internal static void BlockingEndWrite(IAsyncResult asyncResult)
	{
	}
}

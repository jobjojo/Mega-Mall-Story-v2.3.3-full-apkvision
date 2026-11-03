using System.Runtime.CompilerServices;

namespace System.IO;

[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable
{
	[Serializable]
	private sealed class NullTextReader : TextReader
	{
		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		public override string ReadLine()
		{
			return null;
		}
	}

	[Serializable]
	internal sealed class SyncTextReader : TextReader
	{
		internal readonly TextReader _in;

		internal SyncTextReader(TextReader t)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override void Close()
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		protected override void Dispose(bool disposing)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Peek()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Read()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override string ReadLine()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public override string ReadToEnd()
		{
			return null;
		}
	}

	public static readonly TextReader Null;

	public virtual void Close()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public virtual int Peek()
	{
		return 0;
	}

	public virtual int Read()
	{
		return 0;
	}

	public virtual int Read(char[] buffer, int index, int count)
	{
		return 0;
	}

	public virtual string ReadToEnd()
	{
		return null;
	}

	public virtual string ReadLine()
	{
		return null;
	}

	public static TextReader Synchronized(TextReader reader)
	{
		return null;
	}
}

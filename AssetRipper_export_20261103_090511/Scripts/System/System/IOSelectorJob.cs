using System.Runtime.InteropServices;

namespace System;

[StructLayout((LayoutKind)0)]
internal class IOSelectorJob
{
	private IOOperation operation;

	private IOAsyncCallback callback;

	private IOAsyncResult state;
}

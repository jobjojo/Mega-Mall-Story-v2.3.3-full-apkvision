using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static class Interop
{
	internal enum Error
	{
		SUCCESS = 0,
		E2BIG = 65537,
		EACCES = 65538,
		EADDRINUSE = 65539,
		EADDRNOTAVAIL = 65540,
		EAFNOSUPPORT = 65541,
		EAGAIN = 65542,
		EALREADY = 65543,
		EBADF = 65544,
		EBADMSG = 65545,
		EBUSY = 65546,
		ECANCELED = 65547,
		ECHILD = 65548,
		ECONNABORTED = 65549,
		ECONNREFUSED = 65550,
		ECONNRESET = 65551,
		EDEADLK = 65552,
		EDESTADDRREQ = 65553,
		EDOM = 65554,
		EDQUOT = 65555,
		EEXIST = 65556,
		EFAULT = 65557,
		EFBIG = 65558,
		EHOSTUNREACH = 65559,
		EIDRM = 65560,
		EILSEQ = 65561,
		EINPROGRESS = 65562,
		EINTR = 65563,
		EINVAL = 65564,
		EIO = 65565,
		EISCONN = 65566,
		EISDIR = 65567,
		ELOOP = 65568,
		EMFILE = 65569,
		EMLINK = 65570,
		EMSGSIZE = 65571,
		EMULTIHOP = 65572,
		ENAMETOOLONG = 65573,
		ENETDOWN = 65574,
		ENETRESET = 65575,
		ENETUNREACH = 65576,
		ENFILE = 65577,
		ENOBUFS = 65578,
		ENODEV = 65580,
		ENOENT = 65581,
		ENOEXEC = 65582,
		ENOLCK = 65583,
		ENOLINK = 65584,
		ENOMEM = 65585,
		ENOMSG = 65586,
		ENOPROTOOPT = 65587,
		ENOSPC = 65588,
		ENOSYS = 65591,
		ENOTCONN = 65592,
		ENOTDIR = 65593,
		ENOTEMPTY = 65594,
		ENOTSOCK = 65596,
		ENOTSUP = 65597,
		ENOTTY = 65598,
		ENXIO = 65599,
		EOVERFLOW = 65600,
		EPERM = 65602,
		EPIPE = 65603,
		EPROTO = 65604,
		EPROTONOSUPPORT = 65605,
		EPROTOTYPE = 65606,
		ERANGE = 65607,
		EROFS = 65608,
		ESPIPE = 65609,
		ESRCH = 65610,
		ESTALE = 65611,
		ETIMEDOUT = 65613,
		ETXTBSY = 65614,
		EXDEV = 65615,
		ESOCKTNOSUPPORT = 65630,
		EPFNOSUPPORT = 65632,
		ESHUTDOWN = 65644,
		EHOSTDOWN = 65648,
		ENODATA = 65649,
		EOPNOTSUPP = ENOTSUP,
		EWOULDBLOCK = EAGAIN
	}

	internal struct ErrorInfo
	{
		private Error _error = Error.SUCCESS;

		private int _rawErrno = 0;

		internal Error Error => Error.SUCCESS;

		internal int RawErrno => 0;

		internal ErrorInfo(int errno)
		{
		}

		internal ErrorInfo(Error error)
		{
		}

		internal string GetErrorMessage()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}

	internal static class Sys
	{
		internal enum NodeType
		{
			DT_UNKNOWN = 0,
			DT_FIFO = 1,
			DT_CHR = 2,
			DT_DIR = 4,
			DT_BLK = 6,
			DT_REG = 8,
			DT_LNK = 10,
			DT_SOCK = 12,
			DT_WHT = 14
		}

		internal struct DirectoryEntry
		{
			internal unsafe byte* Name;

			internal int NameLength;

			internal NodeType InodeType;

			internal ReadOnlySpan<char> GetName(Span<char> buffer)
			{
				return default;
			}
		}

		internal struct FileStatus
		{
			internal FileStatusFlags Flags;

			internal int Mode;

			internal uint Uid;

			internal uint Gid;

			internal long Size;

			internal long ATime;

			internal long ATimeNsec;

			internal long MTime;

			internal long MTimeNsec;

			internal long CTime;

			internal long CTimeNsec;

			internal long BirthTime;

			internal long BirthTimeNsec;

			internal long Dev;

			internal long Ino;

			internal uint UserFlags;
		}

		[Flags]
		internal enum FileStatusFlags
		{
			None = 0,
			HasBirthTime = 1
		}

		[Flags]
		internal enum Permissions
		{
			Mask = 0x1FF,
			S_IRWXU = 0x1C0,
			S_IRUSR = 0x100,
			S_IWUSR = 0x80,
			S_IXUSR = 0x40,
			S_IRWXG = 0x38,
			S_IRGRP = 0x20,
			S_IWGRP = 0x10,
			S_IXGRP = 8,
			S_IRWXO = 7,
			S_IROTH = 4,
			S_IWOTH = 2,
			S_IXOTH = 1
		}

		internal static readonly bool CanSetHiddenFlag;

		internal static ErrorInfo GetLastErrorInfo()
		{
			return default;
		}

		internal static string StrError(int platformErrno)
		{
			return null;
		}

		[PreserveSig]
		internal static extern Error ConvertErrorPlatformToPal(int platformErrno);

		[PreserveSig]
		internal static extern int ConvertErrorPalToPlatform(Error error);

		[PreserveSig]
		private unsafe static extern byte* StrErrorR(int platformErrno, byte* buffer, int bufferSize);

		[PreserveSig]
		internal unsafe static extern void GetNonCryptographicallySecureRandomBytes(byte* buffer, int length);

		[PreserveSig]
		internal static extern IntPtr OpenDir(string path);

		[PreserveSig]
		internal static extern int GetReadDirRBufferSize();

		[PreserveSig]
		internal unsafe static extern int ReadDirR(IntPtr dir, byte* buffer, int bufferSize, out DirectoryEntry outputEntry);

		[PreserveSig]
		internal static extern int CloseDir(IntPtr dir);

		[PreserveSig]
		private static extern int ReadLink(string path, byte[] buffer, int bufferSize);

		public static string ReadLink(string path)
		{
			return null;
		}

		[PreserveSig]
		internal static extern int Stat(string path, out FileStatus output);

		[PreserveSig]
		internal static extern int LStat(string path, out FileStatus output);

		[PreserveSig]
		internal static extern int Symlink(string target, string linkPath);

		[PreserveSig]
		internal static extern int CopyFile(SafeFileHandle source, SafeFileHandle destination);

		[PreserveSig]
		internal static extern uint GetEGid();

		[PreserveSig]
		internal static extern uint GetEUid();

		[PreserveSig]
		private static extern int LChflagsCanSetHiddenFlag();

		[PreserveSig]
		internal static extern int MkDir(string path, int mode);

		[PreserveSig]
		internal static extern int RmDir(string path);

		[PreserveSig]
		internal static extern int Stat(ref byte path, out FileStatus output);

		internal static int Stat(ReadOnlySpan<char> path, out FileStatus output)
		{
			output = default;
			return 0;
		}

		[PreserveSig]
		internal static extern int LStat(ref byte path, out FileStatus output);

		internal static int LStat(ReadOnlySpan<char> path, out FileStatus output)
		{
			output = default;
			return 0;
		}

		[PreserveSig]
		internal static extern int Unlink(string pathname);

		internal unsafe static int DoubleToString(double value, byte* format, byte* buffer, int bufferLength)
		{
			return 0;
		}
	}

	private static void ThrowExceptionForIoErrno(ErrorInfo errorInfo, string path, bool isDirectory, Func<ErrorInfo, ErrorInfo> errorRewriter)
	{
	}

	internal static long CheckIo(long result, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
	{
		return 0L;
	}

	internal static int CheckIo(int result, string path = null, bool isDirectory = false, Func<ErrorInfo, ErrorInfo> errorRewriter = null)
	{
		return 0;
	}

	internal static Exception GetExceptionForIoErrno(ErrorInfo errorInfo, string path = null, bool isDirectory = false)
	{
		return null;
	}

	internal static Exception GetIOException(ErrorInfo errorInfo)
	{
		return null;
	}

	internal unsafe static void GetRandomBytes(byte* buffer, int length)
	{
	}
}

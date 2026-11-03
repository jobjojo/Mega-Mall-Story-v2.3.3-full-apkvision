using System.Collections.Generic;
using System.Text;

namespace System.Globalization;

internal static class EncodingTable
{
	internal static InternalEncodingDataItem[] encodingDataPtr;

	internal static InternalCodePageDataItem[] codePageDataPtr;

	private const int MIMECONTF_MAILNEWS = 1;

	private const int MIMECONTF_BROWSER = 2;

	private const int MIMECONTF_MINIMAL = 4;

	private const int MIMECONTF_IMPORT = 8;

	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;

	private const int MIMECONTF_SAVABLE_BROWSER = 512;

	private const int MIMECONTF_EXPORT = 1024;

	private const int MIMECONTF_PRIVCONVERTER = 65536;

	private const int MIMECONTF_VALID = 131072;

	private const int MIMECONTF_VALID_NLS = 262144;

	private const int MIMECONTF_MIME_IE4 = 268435456;

	private const int MIMECONTF_MIME_LATEST = 536870912;

	private const int MIMECONTF_MIME_REGISTRY = 1073741824;

	private static int lastEncodingItem;

	private static int lastCodePageItem;

	private static Dictionary<string, int> hashByName;

	private static Dictionary<int, CodePageDataItem> hashByCodePage;

	private static int GetNumEncodingItems()
	{
		return 0;
	}

	private static InternalEncodingDataItem ENC(string name, ushort cp)
	{
		return default;
	}

	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
	{
		return default;
	}

	static EncodingTable()
	{
	}

	private static int internalGetCodePageFromName(string name)
	{
		return 0;
	}

	internal static EncodingInfo[] GetEncodings()
	{
		return null;
	}

	internal static int GetCodePageFromName(string name)
	{
		return 0;
	}

	internal static CodePageDataItem GetCodePageDataItem(int codepage)
	{
		return null;
	}
}

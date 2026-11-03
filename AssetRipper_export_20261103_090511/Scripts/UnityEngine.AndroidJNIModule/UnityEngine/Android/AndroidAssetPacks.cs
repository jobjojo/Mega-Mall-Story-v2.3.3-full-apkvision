using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Android;

[StaticAccessor("AndroidAssetPacksBindingsHelpers", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
public static class AndroidAssetPacks
{
	private class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
	{
		private Action<AndroidAssetPackInfo> m_Callback;

		private string[] m_AssetPacks;

		public AssetPackManagerDownloadStatusCallback(Action<AndroidAssetPackInfo> callback, string[] assetPacks)
			: base((string)null)
		{
		}

		[Preserve]
		private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode)
		{
		}
	}

	private class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
	{
		private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback;

		public AssetPackManagerMobileDataConfirmationCallback(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
			: base((string)null)
		{
		}

		[Preserve]
		private void onMobileDataConfirmationResult(bool allowed)
		{
		}
	}

	private class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
	{
		private Action<ulong, AndroidAssetPackState[]> m_Callback;

		private List<string> m_AssetPackNames;

		private List<AndroidAssetPackState> m_States;

		private long m_Size;

		public AssetPackManagerStatusQueryCallback(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks)
			: base((string)null)
		{
		}

		[Preserve]
		private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes)
		{
		}
	}

	private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;

	private static bool s_ApiMissing;

	private static AndroidJavaObject GetAssetPackManager()
	{
		return null;
	}
}

using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine;

internal static class BeforeRenderHelper
{
	private struct OrderBlock
	{
		internal int order;

		internal UnityAction callback;
	}

	private static List<OrderBlock> s_OrderBlocks;

	private static int GetUpdateOrder(UnityAction callback)
	{
		return 0;
	}

	public static void RegisterCallback(UnityAction callback)
	{
	}

	public static void UnregisterCallback(UnityAction callback)
	{
	}

	public static void Invoke()
	{
	}
}

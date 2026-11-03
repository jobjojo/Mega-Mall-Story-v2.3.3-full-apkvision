using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics.Contracts;

public static class Contract
{
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
	{
		return false;
	}
}

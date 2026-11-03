using System.Collections.Generic;
using System.Collections.Specialized;

namespace System.Diagnostics;

public abstract class Switch
{
	private object switchSettings;

	private readonly string description;

	private readonly string displayName;

	private int switchSetting;

	private bool initialized;

	private bool initializing;

	private string switchValueString;

	private StringDictionary attributes;

	private string defaultValue;

	private object m_intializedLock;

	private static List<WeakReference> switches;

	private static int s_LastCollectionCount;
}

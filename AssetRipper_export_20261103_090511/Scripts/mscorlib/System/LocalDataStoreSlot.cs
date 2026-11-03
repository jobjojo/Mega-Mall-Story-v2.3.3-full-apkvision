using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
public sealed class LocalDataStoreSlot
{
	private LocalDataStoreMgr m_mgr;

	private int m_slot;

	private long m_cookie;

	internal LocalDataStoreMgr Manager => null;

	internal int Slot => 0;

	internal long Cookie => 0L;

	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie)
	{
	}

	~LocalDataStoreSlot()
	{
	}

	internal LocalDataStoreSlot()
	{
	}
}

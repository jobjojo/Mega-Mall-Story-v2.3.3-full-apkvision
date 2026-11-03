using System.Collections.Generic;
using java.lang;
using kairo.unity.form;
using kairo.unity.util;

namespace kairo.unity.ui;

public abstract class SaveRecorder : SaveRecorderBase
{
	public delegate void PreSaveMethod();

	public delegate void PostSaveMethod(byte[] save);

	public delegate void PrePackMethod();

	public delegate void PostPackMethod(byte[][] data);

	public delegate byte[] PackMethod(int id);

	private struct AutoSaveLogData
	{
		public long LockTotalTime;

		public long LockTime;

		public int TryCount;

		public int[] DataIds;

		public int[] DataMis;
	}

	private bool existAutoSave_;

	private long[] lastSaveTime_;

	private bool[] saveReserve_;

	private JThread lockThread_;

	private int lockThreadCount_;

	private PropertyBase asProperty_;

	private PackMethod asPackMethod_;

	private PreSaveMethod asPreSaveMethod_;

	private PostSaveMethod asPostSaveMethod_;

	private PrePackMethod asPrePackMethod_;

	private PostPackMethod asPostPackMethod_;

	private bool asRedo_;

	private bool asCancel_;

	private bool asLog_;

	private JThread asThread_;

	private List<FormBase> asForms_;

	private bool asCheckSaveForm_;

	private object SaveGame_lock;

	protected SaveRecorder(bool existAutoSave)
	{
	}

	public void SaveGame(bool auto = false, bool immediate = true)
	{
	}

	public void SaveSystem()
	{
	}

	public abstract void OnSaveGame(bool auto);

	public abstract void OnSaveSystem();

	internal override void Lock()
	{
	}

	public void Unlock()
	{
	}

	internal override void Unlock(bool forced)
	{
	}

	protected void SaveGame(bool auto, PropertyBase property, PackMethod packMethod, PreSaveMethod preSaveMethod, PostSaveMethod postSaveMethod, PrePackMethod prePackMethod, PostPackMethod postPackMethod, bool log)
	{
	}

	private void AutoSaveRun()
	{
	}

	private Property MakeSaveData(PropertyBase src, out AutoSaveLogData log)
	{
		log = default;
		return null;
	}

	private void WaitSaveForm()
	{
	}

	private bool CheckSaveForm()
	{
		return false;
	}

	private bool IsBreak()
	{
		return false;
	}

	private void CopyProperty(Property dst, PropertyBase srcobj)
	{
	}

	private Property SetBin(Property dst, byte[][] src)
	{
		return null;
	}

	public bool IsAutoSaving()
	{
		return false;
	}

	public void CancelAutoSave()
	{
	}

	protected virtual void PreSaveGame()
	{
	}

	protected virtual void PostSaveGame()
	{
	}
}

using UnityEngine;
using java.util;

namespace kairo.unity.ui;

public class SoundPlayer
{
	internal class Port
	{
		internal AudioSource component;

		internal SoundBase sound;
	}

	internal enum JingleState
	{
		None = 0,
		Play = 1,
		End = 2
	}

	public const int MAX_VOLUME = 255;

	public const int MAX_PRIO = 255;

	public const int TYPE_BGM = 0;

	public const int TYPE_SE = 1;

	public const int TYPE_MAX = 2;

	public const int LOOP_NONE = 0;

	public const int LOOP_INFINITY = -1;

	public const int LOOP_MAX = 255;

	private static SoundPlayer instance_;

	private int[] volume_;

	private bool[] mute_;

	private Vector playingList_;

	internal Port[] port_;

	private bool suspend_;

	private SoundBase[] suspendSoundList_;

	private bool suspend2_;

	private bool isSilentMode_;

	private bool isOtherAudioPlay_;

	private int[] masterVolume_;

	internal JingleState jingleState_;

	private SoundBase jingle_;

	private long jingleEndTime_;

	private int jingleBgmVolume_;

	internal SoundBase jinglePauseBgm_;

	private int jingleAfterWait_;

	private static bool viaUpdateOtherAudioPlay_;

	internal bool playJingleNow_;

	private SoundPlayer()
	{
	}

	protected void Init()
	{
	}

	internal void AddPlayingList(SoundBase sb)
	{
	}

	protected Vector GetPlayingList()
	{
		return null;
	}

	internal void RemovePlayingList(SoundBase sb)
	{
	}

	public void Dispose()
	{
	}

	public static SoundPlayer GetInstance()
	{
		return null;
	}

	public static void Init(bool usePort)
	{
	}

	public void SetVolume(int type, int volume)
	{
	}

	public int GetVolume(int type)
	{
		return 0;
	}

	public void SetMute(int type, bool mute)
	{
	}

	public bool IsMute(int type)
	{
		return false;
	}

	public void ReflectVolumeAndMute()
	{
	}

	public void Play(SoundBase s)
	{
	}

	public void Stop(SoundBase s)
	{
	}

	public void StopAll()
	{
	}

	public void Resume()
	{
	}

	public void Suspend()
	{
	}

	internal int GetPort(int priority)
	{
		return 0;
	}

	internal AudioSource GetAudioSource(SoundBase sound)
	{
		return null;
	}

	internal void RemovePort(int port)
	{
	}

	internal void RemovePort(SoundBase sound)
	{
	}

	internal void SetPort(int port, SoundBase sound)
	{
	}

	public bool IsSilentMode()
	{
		return false;
	}

	public void OnReceive(object context, object intent)
	{
	}

	internal void SetMasterVolume(int type, int vol)
	{
	}

	public bool IsOtherAudioPlay()
	{
		return false;
	}

	public void UpdateOtherAudioPlay()
	{
	}

	public void SetPortMax(int max)
	{
	}

	public int GetPortMax()
	{
		return 0;
	}

	public void PlayJingle(SoundBase sound)
	{
	}

	public void PlayJingle(SoundBase sound, int afterWait)
	{
	}

	internal void UpdateJingle()
	{
	}
}

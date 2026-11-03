using UnityEngine;
using java.util;

namespace kairo.unity.ui;

public abstract class SoundBase
{
	protected const int MAX_VOLUME_SPF = 127;

	protected const int EVENT_END = -1;

	protected const int EVENT_LOOP = -2;

	protected const int EVENT_PAUSE = -3;

	public const int NO_DATA = 0;

	public const int READY = 1;

	public const int PLAYING = 2;

	public const int PAUSED = 3;

	protected static Vector soundList_;

	internal string name_;

	internal AudioClip data_;

	internal int type_;

	internal int loop_;

	internal int priority_;

	internal float pitch_;

	internal int baseVolume_;

	internal float playTimeReserve_;

	public const int MIN_PRIORITY = 0;

	public const int NORM_PRIORITY = 1;

	public const int MAX_PRIORITY = 2;

	protected AudioSource track_ => null;

	protected int state_ => 0;

	public SoundBase(AudioClip data, int type, int loop)
	{
	}

	public void SetName(string name)
	{
	}

	public string GetName()
	{
		return null;
	}

	public abstract void Play(int volume, bool mute);

	public abstract void SetVolume(int volume, bool mute);

	public abstract void Stop();

	public virtual void Dispose()
	{
	}

	public abstract int GetState();

	public int GetSoundType()
	{
		return 0;
	}

	public void SetSoundType(int type)
	{
	}

	public int GetLoop()
	{
		return 0;
	}

	public void SetLoop(int loop)
	{
	}

	public void SetPitch(float pitch)
	{
	}

	public float GetPitch()
	{
		return 0f;
	}

	public object GetData()
	{
		return null;
	}

	public void SetBaseVolume(int volume = 255)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public float GetTime()
	{
		return 0f;
	}

	public void SetTime(float time)
	{
	}
}

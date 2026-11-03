using UnityEngine;
using java.io;

namespace kairo.unity.ui;

public class SoundOGG : SoundBase
{
	private SoundOGG(AudioClip p, int type, int loop)
		: base(null, 0, 0)
	{
	}

	public static SoundOGG Load(InputStream stream)
	{
		return null;
	}

	public static SoundOGG Load(byte[] data)
	{
		return null;
	}

	public static SoundOGG Load(string file)
	{
		return null;
	}

	public override void Play(int volume, bool mute)
	{
	}

	public override void SetVolume(int volume, bool mute)
	{
	}

	public override void Stop()
	{
	}

	public override void Dispose()
	{
	}

	public override int GetState()
	{
		return 0;
	}
}

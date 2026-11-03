using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
public sealed class AudioSource : AudioBehaviour
{
	public float volume
	{
		set
		{
		}
	}

	public float pitch
	{
		set
		{
		}
	}

	[NativeProperty("SecPosition")]
	public float time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("AudioClip")]
	public AudioClip clip
	{
		set
		{
		}
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		get
		{
			return false;
		}
	}

	public bool loop
	{
		set
		{
		}
	}

	public bool playOnAwake
	{
		set
		{
		}
	}

	private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch)
	{
	}

	private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay)
	{
	}

	private void Stop(bool stopOneShots)
	{
	}

	[ExcludeFromDocs]
	public void Play()
	{
	}

	public void Stop()
	{
	}
}

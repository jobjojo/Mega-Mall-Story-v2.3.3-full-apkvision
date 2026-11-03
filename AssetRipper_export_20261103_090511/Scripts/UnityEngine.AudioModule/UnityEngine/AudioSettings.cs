using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
public sealed class AudioSettings
{
	public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

	public static class Mobile
	{
		private static bool _stopAudioOutputOnMute;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> OnMuteStateChanged;

		public static bool muteState { get; private set; }

		public static bool stopAudioOutputOnMute => false;

		[RequiredByNativeCode]
		internal static void InvokeOnMuteStateChanged(bool mute)
		{
		}

		[RequiredByNativeCode]
		internal static bool InvokeIsStopAudioOutputOnMuteEnabled()
		{
			return false;
		}

		public static void StartAudioOutput()
		{
		}

		public static void StopAudioOutput()
		{
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action OnAudioSystemShuttingDown;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action OnAudioSystemStartedUp;

	[NativeMethod(Name = "AudioSettings::SetConfiguration", IsFreeFunction = true)]
	[NativeThrows]
	private static bool SetConfiguration(AudioConfiguration config)
	{
		return false;
	}

	public static AudioConfiguration GetConfiguration()
	{
		return default;
	}

	public static bool Reset(AudioConfiguration config)
	{
		return false;
	}

	[RequiredByNativeCode]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemShuttingDown()
	{
	}

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemStartedUp()
	{
	}

	internal static bool StartAudioOutput()
	{
		return false;
	}

	internal static bool StopAudioOutput()
	{
		return false;
	}

	private static bool SetConfiguration_Injected(ref AudioConfiguration config)
	{
		return false;
	}

	private static void GetConfiguration_Injected(out AudioConfiguration ret)
	{
		ret = default;
	}
}

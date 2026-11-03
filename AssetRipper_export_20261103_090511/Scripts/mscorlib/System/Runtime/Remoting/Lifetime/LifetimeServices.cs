using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime;

[ComVisible(true)]
public sealed class LifetimeServices
{
	private static TimeSpan _leaseManagerPollTime;

	private static TimeSpan _leaseTime;

	private static TimeSpan _renewOnCallTime;

	private static TimeSpan _sponsorshipTimeout;

	private static LeaseManager _leaseManager;

	public static TimeSpan LeaseManagerPollTime
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public static TimeSpan LeaseTime
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public static TimeSpan RenewOnCallTime
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public static TimeSpan SponsorshipTimeout
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	static LifetimeServices()
	{
	}

	internal static void TrackLifetime(ServerIdentity identity)
	{
	}
}

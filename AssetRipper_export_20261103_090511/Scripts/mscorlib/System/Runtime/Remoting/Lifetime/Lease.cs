using System.Collections;

namespace System.Runtime.Remoting.Lifetime;

internal class Lease : MarshalByRefObject, ILease
{
	private delegate TimeSpan RenewalDelegate(ILease lease);

	private DateTime _leaseExpireTime;

	private LeaseState _currentState;

	private TimeSpan _initialLeaseTime;

	private TimeSpan _renewOnCallTime;

	private TimeSpan _sponsorshipTimeout;

	private ArrayList _sponsors;

	private Queue _renewingSponsors;

	private RenewalDelegate _renewalDelegate;

	public TimeSpan CurrentLeaseTime => default;

	public LeaseState CurrentState => LeaseState.Null;

	public TimeSpan RenewOnCallTime => default;

	public void Activate()
	{
	}

	public TimeSpan Renew(TimeSpan renewalTime)
	{
		return default;
	}

	public void Unregister(ISponsor obj)
	{
	}

	internal void UpdateState()
	{
	}

	private void CheckNextSponsor()
	{
	}

	private void ProcessSponsorResponse(object state, bool timedOut)
	{
	}
}

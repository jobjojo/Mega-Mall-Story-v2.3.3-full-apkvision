using UnityEngine;
using kairo.unity.system.tapjoy.ui;

namespace system.tapjoy.ui;

public abstract class Tapjoy : MonoBehaviour, ITapjoy
{
	public enum OfferState
	{
		None = 0,
		Start = 1,
		Failed = 2,
		Disp = 3
	}

	protected static Tapjoy instance_;

	private string key_;

	private string offerwallName_;

	private string movieName_;

	private string freeMovieName_;

	private TJPlacement offerwallPlacement_;

	private TJPlacement moviePlacement_;

	private TJPlacement freeMoviePlacement_;

	private bool contentIsReadyForPlacement_;

	private bool initialize_;

	private bool backupMute_;

	private int balance_;

	private bool movieOnly_;

	private bool log_;

	private const string PREFS_KEY = "_Tapjoy";

	private OfferState offerState_;

	protected Tapjoy(string key, string offerwallName, bool log = true)
	{
	}

	protected Tapjoy(string key, string offerwallName, string movieName, string freeMovieName = null, bool log = true)
	{
	}

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static Tapjoy GetInstance()
	{
		return null;
	}

	protected void Init()
	{
	}

	protected void Quit()
	{
	}

	public void CallBalance()
	{
	}

	public bool ShowMovie()
	{
		return false;
	}

	public bool ShowFreeMovie()
	{
		return false;
	}

	public bool ShowOffers()
	{
		return false;
	}

	public OfferState GetOfferState()
	{
		return OfferState.None;
	}

	public int GetBalance()
	{
		return 0;
	}

	public void AddBalance(int add)
	{
	}

	public void SubBalance(int sub)
	{
	}

	protected void Print(string s)
	{
	}
}

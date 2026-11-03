using kairo.unity.form;

namespace kairo.unity.ui;

public class ReviewManager
{
	private const string PREF_STATE = "@REVIEW_MANAGER_STATE";

	private const string PREF_FRAME = "@REVIEW_MANAGER_WAIT";

	internal const int STATE_NONE = 0;

	internal const int STATE_START = 1;

	internal const int STATE_SHOW = 2;

	internal const int STATE_FINISH = 3;

	private static int state_;

	private static int frame_;

	private static int wait_;

	private const int DEFAULT_WAIT = 0;

	private static ReviewForm form_;

	private static bool initialized_;

	internal static void Initialize()
	{
	}

	public static void Start(int wait = 0)
	{
	}

	public static bool Update()
	{
		return false;
	}

	private static void Show()
	{
	}

	public static void Reset()
	{
	}

	internal static void ChangeState(int state, int frame = 0)
	{
	}

	private static void Save()
	{
	}

	public static bool IsFinish()
	{
		return false;
	}
}

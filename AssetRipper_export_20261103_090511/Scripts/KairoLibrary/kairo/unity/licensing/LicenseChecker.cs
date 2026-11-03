namespace kairo.unity.licensing;

public class LicenseChecker
{
	private const string BASE64_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvQMQ1sN8JMmZBnDd+KXYmsIhXz7/be8ubRhbzvBkA7pmhST1JIpdTCG80q0yP7zZNVinIs8xU2osxwMghfN6CuMNltUlLJtffK4RPDkkMVDsz+jry4iSUe81ZnC7YrjSsUp4+omyKzGQyEHyt+6BxgPEcJIGt6omtc1EXUrzx5OeWBUDHBkAUDh64zSdm9/EIJRBzmvxgggJkIPItv9cA/yqnZLHb54Dif8N3tOqtwo8NkYiwUB3dlaCtGoDTBe13I+wpiBSnaaQKhjCf0Lo0dxbEd/hpYZztJ7eDFiZ5PlulowhqhHnmlHz+IoJcyBfTvWgN/tUIQD8wFHVMmCHtwIDAQAB";

	private int mnState;

	private int mnResult;

	private int mnResponseCode;

	private string msErrorCode;

	public const int STATE_CHECKING = 0;

	public const int STATE_RECEIVED = 1;

	public const int RESULT_APPLICATION_ERROR = 0;

	public const int RESULT_ALLOW = 1;

	public const int RESULT_DONT_ALLOW = 2;

	public const int RESULT_LICENSING = 3;

	public const int RESPONSE_LICENSED = 0;

	public const int RESPONSE_NOT_LICENSED = 1;

	public const int RESPONSE_LICENSED_OLD_KEY = 2;

	public const int RESPONSE_ERROR_NOT_MARKET_MANAGED = 3;

	public const int RESPONSE_ERROR_SERVER_FAILURE = 4;

	public const int RESPONSE_ERROR_OVER_QUOTA = 5;

	public const int RESPONSE_ERROR_CONTACTING_SERVER = 257;

	public const int RESPONSE_ERROR_INVALID_PACKAGE_NAME = 258;

	public const int RESPONSE_ERROR_NON_MATCHING_UID = 259;

	public void DoCheck()
	{
	}

	public int GetState()
	{
		return 0;
	}

	public int GetResult()
	{
		return 0;
	}

	public string GetErrorCode()
	{
		return null;
	}

	public int GetResponseCode()
	{
		return 0;
	}

	public void OnDestroy()
	{
	}
}

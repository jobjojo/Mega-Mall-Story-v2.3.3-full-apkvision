namespace kairo.unity.plugin;

public interface IRootPlugin
{
	int GetCoin();

	bool CheckCoin(int num);

	bool UseCoin(int num);
}

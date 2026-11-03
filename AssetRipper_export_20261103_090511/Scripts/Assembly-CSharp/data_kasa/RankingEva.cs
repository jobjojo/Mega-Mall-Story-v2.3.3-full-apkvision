namespace data_kasa;

public class RankingEva : BaseData
{
	public int[] eva_income_;

	public int[] eva_quality;

	public int[] eva_topic;

	public int[] eva_older;

	public int goal_older;

	public int goal_bonus;

	public int monthRankUp_term_income;

	public int monthRankUp_term_tenantRootNum;

	public int monthRankUp_term_regularNum;

	public int monthRankUp_term_tenantId;

	public const int FLAG_INIT = 1;

	public static int FLG_RANKING_WIN;

	public static int FLG_MONTH_RANK_WIN;

	public RankingEva(int no, string src)
	{
	}

	public void Load(int no, string src)
	{
	}
}

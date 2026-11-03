using data_kasa;
using java.io;

namespace game_kasa;

public class Entrance
{
	public int mode;

	public int door_cnt;

	public const int MODE_OPEN = 0;

	public const int MODE_CLOSE = 1;

	public const int MODE_OPEN_C = 2;

	public const int MODE_CLOSE_O = 3;

	public static int MAX_ANIMECNT;

	public static int MAX_TO_CLOSE;

	public Tenant tenant;

	public int frame;

	public int animeF;

	public Entrance(Tenant in_tenant)
	{
	}

	public void Update()
	{
	}

	public void SetAnime()
	{
	}

	public void OpenCommand()
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}

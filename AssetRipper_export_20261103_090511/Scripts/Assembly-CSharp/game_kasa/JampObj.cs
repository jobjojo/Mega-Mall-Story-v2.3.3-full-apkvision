using java.io;

namespace game_kasa;

public class JampObj
{
	public int py;

	public int init_py;

	public int vy;

	public int ay;

	public int DIS;

	public int TIME;

	public int frame;

	public int wait;

	public JampObj(int in_initPy, int in_DIS, int in_TIME, int in_wait)
	{
	}

	public JampObj()
	{
	}

	public void SetInitData(int in_initPy, int in_DIS, int in_TIME, int in_wait)
	{
	}

	private void Init()
	{
	}

	public bool Update()
	{
		return false;
	}

	public int GetAllTime()
	{
		return 0;
	}

	public bool ChAir()
	{
		return false;
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}

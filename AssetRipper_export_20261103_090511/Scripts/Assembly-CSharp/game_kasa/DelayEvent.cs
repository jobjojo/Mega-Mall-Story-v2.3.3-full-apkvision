using java.io;

namespace game_kasa;

public class DelayEvent
{
	public int delayId_;

	public int line_;

	public int wait_;

	public int hour_;

	public int rideChara_;

	public string arg_;

	public DelayEvent()
	{
	}

	public DelayEvent(int delayId, int line, int wait, int hour, int rideChara, string arg)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}

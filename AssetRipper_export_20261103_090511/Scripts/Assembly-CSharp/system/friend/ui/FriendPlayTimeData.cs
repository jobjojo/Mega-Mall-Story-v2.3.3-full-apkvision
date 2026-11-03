using java.io;
using kairo.unity.util;

namespace system.friend.ui;

public class FriendPlayTimeData
{
	public SecureString friendId_;

	public SecureInt minute_;

	public SecureInt state_;

	public FriendPlayTimeData()
	{
	}

	public FriendPlayTimeData(string friendId, int minute, int state)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}

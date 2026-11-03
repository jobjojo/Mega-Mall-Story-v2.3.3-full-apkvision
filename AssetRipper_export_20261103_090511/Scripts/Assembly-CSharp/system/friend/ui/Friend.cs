using java.io;
using kairo.unity.util;

namespace system.friend.ui;

public class Friend
{
	public SecureString friendId_;

	public SecureString name_;

	public SecureInt state_;

	public SecureInt minute_;

	public SecureInt updated_;

	public const int STATE_APPLY = 1;

	public const int STATE_APPLY_WAIT = 2;

	public const int STATE_FRIEND = 3;

	public Friend()
	{
	}

	public Friend(string friendId, string name, int state, int minute, int updated)
	{
	}

	public Friend(byte[] src)
	{
	}

	public Friend(string src)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}
}

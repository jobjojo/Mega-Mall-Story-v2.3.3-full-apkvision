namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header;

	private ContactPair m_Pair;

	private bool m_Flipped;

	private ContactPoint[] m_LegacyContacts;

	internal bool Flipped
	{
		set
		{
		}
	}

	public Collision()
	{
	}

	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped)
	{
	}

	internal void Reuse(in ContactPairHeader header, in ContactPair pair)
	{
	}
}

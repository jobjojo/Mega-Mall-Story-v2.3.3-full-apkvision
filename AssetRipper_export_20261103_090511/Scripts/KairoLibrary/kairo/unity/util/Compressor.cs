namespace kairo.unity.util;

public class Compressor
{
	private class Node
	{
		public Node parent_;

		public Node left_;

		public Node right_;

		public int weight_;

		public int value_;

		public Node()
		{
		}

		public Node(Node parent, Node left, Node right, int weight, int value)
		{
		}
	}

	private static int[] weights_;

	private static Node[] nodeTbl_;

	private static byte[] bits_;

	private static byte[] nullbits_;

	private static int[] _getLowestNode_result;

	private static int bitPoint_;

	private static byte[] bitBuffer_;

	private Compressor()
	{
	}

	public static byte[] Compress(byte[] data)
	{
		return null;
	}

	public static byte[] Expand(byte[] data)
	{
		return null;
	}

	private static void _writeNodeToBitBuffer(Node node)
	{
	}

	private static Node _readNodeFromBitBuffer()
	{
		return null;
	}

	private static int[] _getLowestNode(FastVector list)
	{
		return null;
	}

	private static void _setBitBuffer(byte[] data)
	{
	}

	private static byte[] _getBitBuffer()
	{
		return null;
	}

	private static void _writeBit(int bit)
	{
	}

	private static void _writeByte(int v)
	{
	}

	private static int _readBit()
	{
		return 0;
	}

	private static int _readByte()
	{
		return 0;
	}
}

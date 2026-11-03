namespace kairo.unity.ui;

public class ImageTransform
{
	public int x;

	public int y;

	public float scaleX;

	public float scaleY;

	public float rotate;

	public int localX;

	public int localY;

	protected int imageTransX_;

	protected int imageTransY_;

	protected float imageScaleX_;

	protected float imageScaleY_;

	private static float cacheRotate;

	private static float cacheSin;

	private static float cacheCos;

	protected int[] transform;

	private static int[] getPoint_result;

	private static ImageTransform getPoint_transform;

	public void Init()
	{
	}

	public void Copy(ImageTransform from)
	{
	}

	public void Set(int x, int y, float scaleX, float scaleY, float rotate)
	{
	}

	public void Set(int x, int y, float scaleX, float scaleY, float rotate, int localX, int localY)
	{
	}

	protected void Set(int x, int y, float scaleX, float scaleY, float rotate, int localX, int localY, int imageTransX, int imageTransY, float imageScaleX, float imageScaleY)
	{
	}

	public void SetPosition(int x, int y)
	{
	}

	public void SetScale(float scale)
	{
	}

	public void SetScale(float sx, float sy)
	{
	}

	public void SetRotate(float angle)
	{
	}

	public void SetLocalOffset(int x, int y)
	{
	}

	public int[] GetTransform()
	{
		return null;
	}

	protected int[] GetTransform(bool translate)
	{
		return null;
	}

	public int[] GetPoint()
	{
		return null;
	}

	public static int[] GetPoint(int x, int y, float scaleX, float scaleY, float rotate, int localX, int localY)
	{
		return null;
	}
}

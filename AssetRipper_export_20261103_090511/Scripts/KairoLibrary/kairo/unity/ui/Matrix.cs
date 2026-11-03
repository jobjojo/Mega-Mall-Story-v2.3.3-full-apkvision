namespace kairo.unity.ui;

public class Matrix
{
	private static readonly float[] identityMatrix_;

	private float[] mtx_;

	private float[] mul_;

	private float[] set_;

	private static Matrix RotateTempMatrix_;

	private static Matrix ScaleTemporaryMatrix_;

	private static Matrix TranslateTempMatrix_;

	public Matrix()
	{
	}

	public Matrix(Matrix transform)
	{
	}

	public Matrix Reset()
	{
		return null;
	}

	public Matrix SetValues(float[] matrix)
	{
		return null;
	}

	public Matrix Set(Matrix transform)
	{
		return null;
	}

	public void GetValues(float[] matrix)
	{
	}

	public bool IsIdentity()
	{
		return false;
	}

	public Matrix PostConcat(float[] transform)
	{
		return null;
	}

	public Matrix PreConcat(float[] transform)
	{
		return null;
	}

	public Matrix SetConcat(float[] a, float[] b)
	{
		return null;
	}

	public Matrix PostConcat(Matrix transform)
	{
		return null;
	}

	public Matrix PreConcat(Matrix transform)
	{
		return null;
	}

	public Matrix SetConcat(Matrix a, Matrix b)
	{
		return null;
	}

	public Matrix PostRotate(float angle, float px = 0f, float py = 0f)
	{
		return null;
	}

	public Matrix PreRotate(float angle, float px = 0f, float py = 0f)
	{
		return null;
	}

	public Matrix SetRotate(float angle, float px = 0f, float py = 0f)
	{
		return null;
	}

	public static Matrix Rotate(float angle, float px = 0f, float py = 0f)
	{
		return null;
	}

	public static Matrix RotateTemporary(float angle, float px = 0f, float py = 0f)
	{
		return null;
	}

	public Matrix PostScale(float x, float y, float px = 0f, float py = 0f)
	{
		return null;
	}

	public Matrix PreScale(float x, float y, float px = 0f, float py = 0f)
	{
		return null;
	}

	public Matrix SetScale(float x, float y, float px = 0f, float py = 0f)
	{
		return null;
	}

	public static Matrix Scale(float x, float y, float px = 0f, float py = 0f)
	{
		return null;
	}

	public static Matrix ScaleTemporary(float x, float y, float px = 0f, float py = 0f)
	{
		return null;
	}

	public Matrix PostTranslate(float x, float y)
	{
		return null;
	}

	public Matrix PreTranslate(float x, float y)
	{
		return null;
	}

	public Matrix SetTranslate(float x, float y)
	{
		return null;
	}

	public static Matrix Translate(float x, float y)
	{
		return null;
	}

	public static Matrix TranslateTemporary(float x, float y)
	{
		return null;
	}

	public void MapPoints(ref float x, ref float y)
	{
	}

	public void MapPoints(float[] pts)
	{
	}

	public void MapPoints(float[] src, float[] dst)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}

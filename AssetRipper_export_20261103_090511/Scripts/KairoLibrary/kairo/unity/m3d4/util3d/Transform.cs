namespace kairo.unity.m3d4.util3d;

public class Transform
{
	private static readonly float[] identityMatrix_;

	private float[] mtx_;

	public Transform()
	{
	}

	public Transform(Transform transform)
	{
	}

	public void Get(float[] matrix)
	{
	}

	public float Get(int index)
	{
		return 0f;
	}

	public void Invert()
	{
	}

	public void LookAt(Vector3D position, Vector3D look, Vector3D up)
	{
	}

	public void Multiply(Transform transform)
	{
	}

	public void Rotate(float x, float y, float z, float angle)
	{
	}

	public void Rotate(Vector3D v, float angle)
	{
	}

	public void RotateQuat(float x, float y, float z, float w)
	{
	}

	public void RotateQuat(Vector3D v, float w)
	{
	}

	public void Scale(float x, float y, float z)
	{
	}

	public void Scale(Vector3D v)
	{
	}

	public void Set(float[] matrix)
	{
	}

	public void Set(int index, float value)
	{
	}

	public void Set(Transform transform)
	{
	}

	public void SetIdentity()
	{
	}

	public void Translate(float x, float y, float z)
	{
	}

	public void Translate(Vector3D v)
	{
	}

	public void Transpose()
	{
	}

	public void TransVector(Vector3D v, Vector3D result)
	{
	}

	public void TransVector(ref float x, ref float y, ref float z)
	{
	}

	public void TransVectorXY(ref float x, ref float y)
	{
	}

	public void TransVectorXZ(ref float x, ref float z)
	{
	}

	private static bool _checkArgumentException(float x, float y, float z)
	{
		return false;
	}

	private static bool _checkArgumentException(float v)
	{
		return false;
	}
}

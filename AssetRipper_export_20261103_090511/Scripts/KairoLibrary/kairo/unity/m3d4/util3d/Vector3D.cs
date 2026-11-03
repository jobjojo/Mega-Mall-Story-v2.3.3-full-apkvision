using java.io;
using kairo.unity.util;

namespace kairo.unity.m3d4.util3d;

public class Vector3D : ISerializable
{
	public float x_;

	public float y_;

	public float z_;

	public Vector3D()
	{
	}

	public Vector3D(float x, float y, float z)
	{
	}

	public Vector3D(Vector3D v)
	{
	}

	public void Add(float x, float y, float z)
	{
	}

	public void Add(Vector3D v)
	{
	}

	public void Cross(Vector3D v)
	{
	}

	public void Cross(Vector3D u, Vector3D v)
	{
	}

	public float Dot(Vector3D v)
	{
		return 0f;
	}

	public static float Dot(Vector3D v1, Vector3D v2)
	{
		return 0f;
	}

	public float GetX()
	{
		return 0f;
	}

	public float GetY()
	{
		return 0f;
	}

	public float GetZ()
	{
		return 0f;
	}

	public void Normalize()
	{
	}

	public void Set(float x, float y, float z)
	{
	}

	public void Set(Vector3D v)
	{
	}

	public void SetX(float x)
	{
	}

	public void SetY(float y)
	{
	}

	public void SetZ(float z)
	{
	}

	public void Serialize(OutputStream stream)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public static Vector3D operator +(Vector3D z, Vector3D w)
	{
		return null;
	}

	public static Vector3D operator -(Vector3D z, Vector3D w)
	{
		return null;
	}

	public static Vector3D operator *(Vector3D z, float w)
	{
		return null;
	}

	public static Vector3D operator /(Vector3D z, float w)
	{
		return null;
	}
}

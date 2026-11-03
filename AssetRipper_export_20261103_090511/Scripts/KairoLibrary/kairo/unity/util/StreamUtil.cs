using System;
using System.Collections.Generic;
using java.io;
using kairo.unity.m3d4.util3d;
using kairo.unity.secure;
using kairo.unity.type;

namespace kairo.unity.util;

public class StreamUtil
{
	public class VersionObject : IDisposable
	{
		internal InputStream stream_;

		internal VersionObject(InputStream stream)
		{
		}

		public void Dispose()
		{
		}
	}

	public delegate void FinalDeserialize();

	internal static Dictionary<string, string> translateTable_;

	internal static Dictionary<string, string> translateTableRev_;

	internal static string translatePath_;

	internal static bool TranslateEnable;

	private static byte[] VersionCodeMark;

	private static List<FinalDeserialize> finalDeserializer_;

	private static List<List<FinalDeserialize>> finalDeserializeStack_;

	private StreamUtil()
	{
	}

	public static byte[] Read(InputStream stream, int size)
	{
		return null;
	}

	public static byte[] Read(InputStream stream, byte[] buf, int size)
	{
		return null;
	}

	public static byte[] Read(InputStream stream, bool size)
	{
		return null;
	}

	public static byte[] Read(InputStream stream)
	{
		return null;
	}

	public static sbyte ReadByte(InputStream stream)
	{
		return 0;
	}

	public static byte ReadUnsignedByte(InputStream stream)
	{
		return 0;
	}

	public static short ReadShort(InputStream stream)
	{
		return 0;
	}

	public static short ReadShortLE(InputStream stream)
	{
		return 0;
	}

	public static ushort ReadUnsignedShort(InputStream stream)
	{
		return 0;
	}

	public static int ReadInt(InputStream stream)
	{
		return 0;
	}

	public static int ReadIntLE(InputStream stream)
	{
		return 0;
	}

	public static uint ReadUnsignedInt(InputStream stream)
	{
		return 0u;
	}

	public static long ReadLong(InputStream stream)
	{
		return 0L;
	}

	public static long ReadLongLE(InputStream stream)
	{
		return 0L;
	}

	public static ulong ReadUnsignedLong(InputStream stream)
	{
		return 0uL;
	}

	public static bool ReadBoolean(InputStream stream)
	{
		return false;
	}

	public static float ReadFloat(InputStream stream)
	{
		return 0f;
	}

	public static FixedFloat ReadFixedFloat(InputStream stream)
	{
		return default;
	}

	public static float ReadFloat_iOS_OLD(InputStream stream)
	{
		return 0f;
	}

	public static double ReadDouble(InputStream stream)
	{
		return 0.0;
	}

	public static Vector3D ReadVector3D(InputStream stream)
	{
		return null;
	}

	public static Vector3D ReadVector3D_iOS_OLD(InputStream stream)
	{
		return null;
	}

	public static Point ReadPoint(InputStream stream)
	{
		return default;
	}

	public static PointF ReadPointF(InputStream stream)
	{
		return default;
	}

	public static Location ReadLocation(InputStream stream)
	{
		return default;
	}

	public static Circle ReadCircle(InputStream stream)
	{
		return default;
	}

	public static CircleF ReadCircleF(InputStream stream)
	{
		return default;
	}

	public static Cylinder ReadCylinder(InputStream stream)
	{
		return default;
	}

	public static CylinderF ReadCylinderF(InputStream stream)
	{
		return default;
	}

	public static Rect ReadRect(InputStream stream)
	{
		return default;
	}

	public static RectF ReadRectF(InputStream stream)
	{
		return default;
	}

	public static Size ReadSize(InputStream stream)
	{
		return default;
	}

	public static SizeF ReadSizeF(InputStream stream)
	{
		return default;
	}

	public static string ReadString(InputStream stream)
	{
		return null;
	}

	public static T ReadEnum<T>(InputStream stream) where T : struct
	{
		return default;
	}

	public static T ReadObject<T>(InputStream stream) where T : ISerializable
	{
		return default;
	}

	public static ISerializable ReadObject(InputStream stream, ISerializable obj)
	{
		return null;
	}

	public static T ReadId<T>(InputStream stream)
	{
		return default;
	}

	public static void Write(OutputStream os, byte[] data)
	{
	}

	public static void Write(OutputStream os, byte[] data, bool size)
	{
	}

	public static void WriteByte(OutputStream os, sbyte data)
	{
	}

	public static void WriteByte(OutputStream os, byte data)
	{
	}

	public static void WriteShort(OutputStream os, short data)
	{
	}

	public static void WriteShort(OutputStream os, ushort data)
	{
	}

	public static void WriteInt(OutputStream os, int data)
	{
	}

	public static void WriteInt(OutputStream os, uint data)
	{
	}

	public static void WriteLong(OutputStream os, long data)
	{
	}

	public static void WriteLong(OutputStream os, ulong data)
	{
	}

	public static void WriteBoolean(OutputStream os, bool data)
	{
	}

	public static void WriteFloat(OutputStream os, float data)
	{
	}

	public static void WriteFixedFloat(OutputStream os, FixedFloat data)
	{
	}

	public static void WriteDouble(OutputStream os, double data)
	{
	}

	public static void WriteVector3D(OutputStream os, Vector3D value)
	{
	}

	public static void WritePoint(OutputStream os, Point data)
	{
	}

	public static void WritePointF(OutputStream os, PointF data)
	{
	}

	public static void WriteLocation(OutputStream os, Location data)
	{
	}

	public static void WriteCircle(OutputStream os, Circle data)
	{
	}

	public static void WriteCircleF(OutputStream os, CircleF data)
	{
	}

	public static void WriteCylinder(OutputStream os, Cylinder data)
	{
	}

	public static void WriteCylinderF(OutputStream os, CylinderF data)
	{
	}

	public static void WriteRect(OutputStream os, Rect data)
	{
	}

	public static void WriteRectF(OutputStream os, RectF data)
	{
	}

	public static void WriteSize(OutputStream os, Size data)
	{
	}

	public static void WriteSizeF(OutputStream os, SizeF data)
	{
	}

	public static void WriteString(OutputStream os, SecureString data)
	{
	}

	public static void WriteString(OutputStream os, XString data)
	{
	}

	public static void WriteString(OutputStream os, string data)
	{
	}

	public static void WriteEnum(OutputStream os, Enum data)
	{
	}

	public static void WriteObject(OutputStream os, ISerializable obj)
	{
	}

	public static void WriteId<T>(OutputStream os, T data)
	{
	}

	public static bool WriteObject(OutputStream os, object obj, Type type)
	{
		return false;
	}

	public static object ReadObject(InputStream stream, Type type)
	{
		return null;
	}

	public static void WriteArray(OutputStream os, Array array, int arrayLengthBytes = 4)
	{
	}

	public static T ReadArray<T>(InputStream stream, int arrayLengthBytes = 4)
	{
		return default;
	}

	public static Array ReadArray(InputStream stream, Array array, int arrayLengthBytes = 4)
	{
		return null;
	}

	public static Array ReadArray(InputStream stream, Type type, int arrayLengthBytes = 4)
	{
		return null;
	}

	private static object ReadArray(InputStream stream, Array dst, Type type, int arrayLengthBytes = 4)
	{
		return null;
	}

	public static void WriteDoubleIntArray(OutputStream os, int[][] data)
	{
	}

	internal static string ReadTranslate(string s)
	{
		return null;
	}

	internal static void WriteTranslate(string s)
	{
	}

	public static VersionObject WriteVersion(OutputStream stream, int code)
	{
		return null;
	}

	public static VersionObject ReadVersion(InputStream stream)
	{
		return null;
	}

	public static void ClearFinalDeserialize()
	{
	}

	public static void AddFinalDeserialize(FinalDeserialize method)
	{
	}

	public static void ExecuteFinalDeserialize()
	{
	}

	public static void PushFinalDeserialize()
	{
	}

	public static void PopFinalDeserialize()
	{
	}
}

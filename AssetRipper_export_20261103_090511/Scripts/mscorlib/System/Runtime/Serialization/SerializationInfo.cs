using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[ComVisible(true)]
public sealed class SerializationInfo
{
	private const int defaultSize = 4;

	private const string s_mscorlibAssemblySimpleName = "mscorlib";

	private const string s_mscorlibFileName = "mscorlib.dll";

	internal string[] m_members;

	internal object[] m_data;

	internal Type[] m_types;

	private Dictionary<string, int> m_nameToIndex;

	internal int m_currMember;

	internal IFormatterConverter m_converter;

	private string m_fullTypeName;

	private string m_assemName;

	private Type objectType;

	private bool isFullTypeNameSetExplicit;

	private bool isAssemblyNameSetExplicit;

	private bool requireSameTokenInPartialTrust;

	public string FullTypeName => null;

	public string AssemblyName => null;

	public int MemberCount => 0;

	public Type ObjectType => null;

	public bool IsFullTypeNameSetExplicit => false;

	public bool IsAssemblyNameSetExplicit => false;

	[CLSCompliant(false)]
	public SerializationInfo(Type type, IFormatterConverter converter)
	{
	}

	[CLSCompliant(false)]
	public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
	{
	}

	public void SetType(Type type)
	{
	}

	private static bool Compare(byte[] a, byte[] b)
	{
		return false;
	}

	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
	{
	}

	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
	{
		return false;
	}

	public SerializationInfoEnumerator GetEnumerator()
	{
		return null;
	}

	private void ExpandArrays()
	{
	}

	public void AddValue(string name, object value, Type type)
	{
	}

	public void AddValue(string name, object value)
	{
	}

	public void AddValue(string name, bool value)
	{
	}

	public void AddValue(string name, byte value)
	{
	}

	public void AddValue(string name, short value)
	{
	}

	public void AddValue(string name, int value)
	{
	}

	public void AddValue(string name, long value)
	{
	}

	[CLSCompliant(false)]
	public void AddValue(string name, ulong value)
	{
	}

	public void AddValue(string name, float value)
	{
	}

	public void AddValue(string name, DateTime value)
	{
	}

	internal void AddValueInternal(string name, object value, Type type)
	{
	}

	internal void UpdateValue(string name, object value, Type type)
	{
	}

	private int FindElement(string name)
	{
		return 0;
	}

	private object GetElement(string name, out Type foundType)
	{
		foundType = null;
		return null;
	}

	[ComVisible(true)]
	private object GetElementNoThrow(string name, out Type foundType)
	{
		foundType = null;
		return null;
	}

	public object GetValue(string name, Type type)
	{
		return null;
	}

	[ComVisible(true)]
	internal object GetValueNoThrow(string name, Type type)
	{
		return null;
	}

	public bool GetBoolean(string name)
	{
		return false;
	}

	public int GetInt32(string name)
	{
		return 0;
	}

	public long GetInt64(string name)
	{
		return 0L;
	}

	public float GetSingle(string name)
	{
		return 0f;
	}

	public string GetString(string name)
	{
		return null;
	}
}

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Properties;

internal readonly struct FieldMember(FieldInfo fieldInfo) : IMemberInfo
{
	internal readonly FieldInfo m_FieldInfo = null;

	public string Name { get; } = null;

	public bool IsReadOnly => false;

	public Type ValueType => null;

	public IEnumerable<Attribute> GetCustomAttributes()
	{
		return null;
	}
}

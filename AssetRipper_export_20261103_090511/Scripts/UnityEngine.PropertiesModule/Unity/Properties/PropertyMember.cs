using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Properties;

internal readonly struct PropertyMember : IMemberInfo
{
	internal readonly PropertyInfo m_PropertyInfo = null;

	public string Name { get; } = null;

	public bool IsReadOnly => false;

	public Type ValueType => null;

	public PropertyMember(PropertyInfo propertyInfo)
	{
	}

	public IEnumerable<Attribute> GetCustomAttributes()
	{
		return null;
	}
}

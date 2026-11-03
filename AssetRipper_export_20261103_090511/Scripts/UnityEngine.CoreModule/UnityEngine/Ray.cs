using System;
using System.Runtime.CompilerServices;

namespace UnityEngine;

public struct Ray(Vector3 origin, Vector3 direction) : IFormattable
{
	private Vector3 m_Origin = default;

	private Vector3 m_Direction = default;

	public Vector3 origin
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	public Vector3 direction
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}
}

using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public abstract class InputProcessor
{
	internal static TypeTable s_Processors;

	public abstract object ProcessAsObject(object value, InputControl control);

	public unsafe abstract void Process(void* buffer, int bufferSize, InputControl control);

	internal static Type GetValueTypeFromType(Type processorType)
	{
		return null;
	}
}
public abstract class InputProcessor<TValue> : InputProcessor where TValue : struct
{
	public abstract TValue Process(TValue value, InputControl control);

	public override object ProcessAsObject(object value, InputControl control)
	{
		return null;
	}

	public unsafe override void Process(void* buffer, int bufferSize, InputControl control)
	{
	}
}

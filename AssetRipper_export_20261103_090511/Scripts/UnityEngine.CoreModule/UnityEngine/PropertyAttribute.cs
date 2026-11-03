using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute
{
}

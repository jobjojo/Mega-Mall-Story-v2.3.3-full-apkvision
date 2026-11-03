using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
[RequiredByNativeCode]
public sealed class ContextMenu : Attribute
{
}

using System.Collections.Generic;
using UnityEngine;

namespace kairo.unity.graphics;

public class ShaderManager
{
	private static ShaderManager instance_;

	private Dictionary<string, Shader> shaders_;

	protected ShaderManager()
	{
	}

	public static ShaderManager GetInstance()
	{
		return null;
	}

	public Shader Find(string name)
	{
		return null;
	}

	public void Regist(Shader shader)
	{
	}
}

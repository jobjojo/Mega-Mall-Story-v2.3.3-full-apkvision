using System;
using System.Collections.Generic;
using System.Reflection;
using java.io;

namespace kairo.unity.util;

public class JarInflater : IDisposable
{
	public class FileInfo
	{
		public string Name;

		public int Offset;

		public int Size;

		public byte Flag;
	}

	private Dictionary<string, FileInfo> files_;

	private byte[] data_;

	private string directory_;

	private string customFolder_;

	private const sbyte FLAG_DEFLATE = 1;

	internal bool UseLanguagePack { get; set; }

	public JarInflater(Assembly assembly, string name)
	{
	}

	public JarInflater(byte[] data)
	{
	}

	public JarInflater(InputStream stream)
	{
	}

	public JarInflater(string directory)
	{
	}

	protected void _load(InputStream stream)
	{
	}

	public void Close()
	{
	}

	public InputStream GetInputStream(string name)
	{
		return null;
	}

	public long GetSize(string name)
	{
		return 0L;
	}

	public bool Exist(string name)
	{
		return false;
	}

	public byte[] GetData(string name)
	{
		return null;
	}

	public string GetDirectory()
	{
		return null;
	}

	private FileInfo _search(string name)
	{
		return null;
	}

	protected InputStream GetResourceAsStream(string file)
	{
		return null;
	}

	protected bool CheckResourceAsStream(string file)
	{
		return false;
	}

	public string ConvertExtension(string file)
	{
		return null;
	}

	public string[] GetFiles()
	{
		return null;
	}

	public void Dispose()
	{
	}
}

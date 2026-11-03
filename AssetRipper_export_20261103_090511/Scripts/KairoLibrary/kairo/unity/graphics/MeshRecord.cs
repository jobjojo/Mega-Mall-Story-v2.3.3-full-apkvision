using System.Collections.Generic;

namespace kairo.unity.graphics;

public class MeshRecord
{
	internal List<MeshBuilder.Group> Groups;

	internal List<int[]> Indicies;

	internal void Add(MeshBuilder.Group group, int index, int length)
	{
	}

	internal void Dispose()
	{
	}

	public bool Delete()
	{
		return false;
	}

	public void Combine(MeshRecord record)
	{
	}

	public static MeshRecord Combine(MeshRecord record1, MeshRecord record2)
	{
		return null;
	}
}

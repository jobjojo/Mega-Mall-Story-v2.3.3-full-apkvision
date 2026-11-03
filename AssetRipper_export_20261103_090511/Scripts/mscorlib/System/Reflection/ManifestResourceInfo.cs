namespace System.Reflection;

public class ManifestResourceInfo
{
	public virtual Assembly ReferencedAssembly { get; }

	public virtual string FileName { get; }

	public virtual ResourceLocation ResourceLocation { get; }

	public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
	{
	}
}

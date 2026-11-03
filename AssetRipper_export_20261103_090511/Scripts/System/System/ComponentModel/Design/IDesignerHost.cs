namespace System.ComponentModel.Design;

public interface IDesignerHost : IServiceProvider
{
	IComponent RootComponent { get; }
}

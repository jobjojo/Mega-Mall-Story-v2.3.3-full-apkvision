namespace System.ComponentModel;

public interface IContainer : IDisposable
{
	void Remove(IComponent component);
}

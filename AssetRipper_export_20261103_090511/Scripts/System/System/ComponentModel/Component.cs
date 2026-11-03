using System.Runtime.InteropServices;

namespace System.ComponentModel;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[DesignerCategory("Component")]
public class Component : MarshalByRefObject, IComponent, IDisposable
{
	private static readonly object EventDisposed;

	private ISite site;

	private EventHandlerList events;

	protected virtual bool CanRaiseEvents => false;

	internal bool CanRaiseEventsInternal => false;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual ISite Site => null;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	protected bool DesignMode => false;

	~Component()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	protected virtual object GetService(Type service)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}

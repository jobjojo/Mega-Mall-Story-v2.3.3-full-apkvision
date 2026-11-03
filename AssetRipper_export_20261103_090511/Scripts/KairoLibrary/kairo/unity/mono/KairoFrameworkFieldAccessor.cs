namespace kairo.unity.mono;

public struct KairoFrameworkFieldAccessor
{
	public delegate object GetDelegate();

	public delegate void SetDelegate(object value);

	public string Name;

	public GetDelegate GetMethod;

	public SetDelegate SetMethod;
}

namespace System.Reflection;

public interface ICustomAttributeProvider
{
	object[] GetCustomAttributes(Type attributeType, bool inherit);

	bool IsDefined(Type attributeType, bool inherit);
}

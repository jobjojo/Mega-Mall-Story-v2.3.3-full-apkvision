namespace kairo.unity.util;

public interface ITextSerializable
{
	string Pack();

	void UnPack(string source);
}

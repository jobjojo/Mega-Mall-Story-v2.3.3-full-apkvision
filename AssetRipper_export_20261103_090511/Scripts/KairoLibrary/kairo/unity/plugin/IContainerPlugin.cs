using System.Collections.Generic;
using kairo.unity.util;

namespace kairo.unity.plugin;

public interface IContainerPlugin
{
	Dictionary<string, object> GetGamePlayData(params string[] args);

	SecureByteArray GetEncryptionKey();
}

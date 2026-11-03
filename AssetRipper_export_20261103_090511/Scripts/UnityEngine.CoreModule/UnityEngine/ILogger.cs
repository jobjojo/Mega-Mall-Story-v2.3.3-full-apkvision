namespace UnityEngine;

public interface ILogger : ILogHandler
{
	ILogHandler logHandler { get; }

	bool logEnabled { get; }

	void Log(LogType logType, object message);

	void Log(LogType logType, object message, Object context);

	void LogError(string tag, object message);
}

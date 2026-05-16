// TODO: define the 'LogLevel' enum

using Microsoft.Testing.Platform.Logging;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

public enum  LogLevel { Unknown = 0, Trace = 1, Debug = 2, Info = 4, Warning = 5, Error = 6, Fatal = 42};

static class LogLine
{

    public static LogLevel ParseLogLevel(string logLine)
    {
        int position1 = logLine.IndexOf("[");
        int position2 = logLine.IndexOf("]");
        string substring = logLine.Substring(position1 + 1, position2 - 1);
        Console.WriteLine(substring);

        switch (substring)
        {
            case "TRC":
                return LogLevel.Trace;
                break;
            case "DBG":
                return LogLevel.Debug;
                break;
            case "INF":
                return LogLevel.Info;
                break;
            case "WRN":
                return LogLevel.Warning;
                break;
            case "ERR":
                return LogLevel.Error;
                break;
            case "FTL":
                return LogLevel.Fatal;
                break;
            default:
                return LogLevel.Unknown;
        }

    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}

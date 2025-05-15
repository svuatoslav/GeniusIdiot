using GeniusIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    internal class FileLogger : ILogger
    {
        private readonly string _pathLogs = "Logs.txt";

        public FileLogger()
        {
            XMLManager.Logger = this;
            JSONManager.Logger = this;
        }

        public FileLogger(string PathLoggs) : this() => _pathLogs = PathLoggs;

        public void LogError(string message) => File.AppendAllText(_pathLogs, $"[ERROR] {DateTime.Now}: {message}\n");

        public void LogWarning(string message) => File.AppendAllText(_pathLogs, $"[WARNING] {DateTime.Now}: {message}\n");

        public void LogInfo(string message) => File.AppendAllText(_pathLogs, $"[INFO] {DateTime.Now}: {message}\n");
    }
}

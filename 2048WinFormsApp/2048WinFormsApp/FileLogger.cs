namespace _2048WinFormsApp
{
    public static class FileLogger
    {
        public static string Path { private get; set; } = "Logs.txt";

        public static void LogError(string message) => File.AppendAllText(Path, $"[ERROR] {DateTime.Now}: {message}\n");

        public static void LogWarning(string message) => File.AppendAllText(Path, $"[WARNING] {DateTime.Now}: {message}\n");

        public static void LogInfo(string message) => File.AppendAllText(Path, $"[INFO] {DateTime.Now}: {message}\n");
    }
}

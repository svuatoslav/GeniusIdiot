namespace _2048WinFormsApp
{
    internal static class StoragePath
    {
        internal const string PathLogs = "Logs.txt";
        internal readonly static string ProjectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
    }
}

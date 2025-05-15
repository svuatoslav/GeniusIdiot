namespace GeniusIdiotConsoleApp
{
    public static class StoragePath
    {
        internal readonly static string PathXMLsStorage = "Data\\XMLFiles";
        internal readonly static string PathJSONsStorage = "Data\\JSONFiles";
        internal readonly static string PathLogs = "Data\\Logs.txt";
        internal readonly static string ProjectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
    }
}
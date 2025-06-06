namespace GeniusIdiotWinFormsApp
{
    public static class StoragePath
    {
        internal const string PathXMLsStorage = "Data\\XMLFiles";
        internal const string PathJSONsStorage = "Data\\JSONFiles";
        internal const string PathLogs = "Data\\Logs.txt";
        internal readonly static string ProjectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
    }
}
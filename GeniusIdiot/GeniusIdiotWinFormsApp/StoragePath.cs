namespace GeniusIdiotWinFormsApp
{
    public static class StoragePath
    {
        internal readonly static string PathXMLsStorage = "Data\\XMLFiles";
        internal readonly static string PathLogs = "Logs.txt";
        internal readonly static string ProjectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
    }
}
using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    internal static class JSONManager
    {
        public static void WriteJSON<T>(string path, T data) where T : struct
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            var fullPath = Path.Combine(path, "Score.json");

            try
            { File.WriteAllText(fullPath, json); }
            catch (IOException ex)
            { FileLogger.LogError($"Failed to write a file:\n{ex.Message}"); }
        }

        public static T? ReadJSON<T>(string path) where T : struct
        {
            T? values = null;

            var filePath = Path.Combine(path, "Score.json");

            try
            {
                var file = File.ReadAllText(filePath);

                values = JsonConvert.DeserializeObject<T>(file);
            }
            catch (IOException ex)
            {
                FileLogger.LogError($"The file could not be read:\n{ex.Message}");
                return values;
            }

            return values;
        }
    }
}

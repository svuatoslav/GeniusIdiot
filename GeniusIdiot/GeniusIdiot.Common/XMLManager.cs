using System.Xml.Serialization;

namespace GeniusIdiot.Common
{
    public static class XMLManager
    {
        public static void WriteXML<T>(string path, List<T> data) where T : class, new()
        {
            var serializerList = new XmlSerializer(typeof(List<T>));

            var fullPath = CreateFullPath(path, data[0]);

            Record(data, serializerList, fullPath);
        }

        public static void WriteXML<T>(string path, T data) where T : class, new()
        {
            var serializer = new XmlSerializer(typeof(T));

            var filePath = CreateFullPath(path, data);

            Record(data, serializer, filePath);
        }

        public static List<T>? ReadXML<T>(string path) where T : class, new()
        {
            List<T>? values = null;
            
            try
            {
                var serializerList = new XmlSerializer(typeof(List<T>));

                var filePath = CreateFullPath(path, typeof(T).Name);

                using (var reader = new StreamReader(filePath))
                {
                    values = serializerList.Deserialize(reader) as List<T>;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                FileLogger.LogError($"The file could not be read:\nIncorrect file path\n{ex.Message}");
                return values;
            }
            catch (FileNotFoundException ex)
            {
                FileLogger.LogError($"The file could not be read:\nFile Not Found\n{ex.Message}");
                return values;
            }
            catch (Exception ex)
            {
                FileLogger.LogError($"The file could not be read:\n{ex.Message}");
                return values;
            }

            return values;
        }

        private static string CreateFullPath<T>(string path, T typeClass) => Path.Combine(path, typeClass is User ? "Users" : "Questions") + ".xml";

        private static string CreateFullPath(string path, string typeClass) => Path.Combine(path, typeClass == "User" ? "Users" : "Questions") + ".xml";

        private static void Record<T>(T data, XmlSerializer xml, string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    xml.Serialize(writer, data);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                FileLogger.LogError($"The file could not be read:\nIncorrect file path\n{ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                FileLogger.LogError("The file could not be read:\n" +
                $"The class has no constructor without parameters.\n{ex.Message}");
            }
            catch (Exception ex)
            {
                FileLogger.LogError($"Failed to write a file:\n{ex.Message}");
            }
        }
    }
}
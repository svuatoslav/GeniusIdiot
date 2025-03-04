using System.Xml.Serialization;

namespace GeniusIdiotConsoleApp.Data.XML
{
    public static class XMLManager
    {
        internal static void WriteXML<T>(List<T> ListSerialize, string pathRelativeProjectSolution, bool append) where T : class, new()
        {
            var serializerList = new XmlSerializer(typeof(List<T>));
            var filePath = Path.Combine(DataManager.ProjectPath, pathRelativeProjectSolution);
            try
            {
                using (var writer = new StreamWriter(filePath, append))
                {
                    serializerList.Serialize(writer, ListSerialize);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"The file could not be read:\nIncorrect file path\n{ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("The file could not be read:\n" +
                $"The class has no constructor without parameters.\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write a file:\n{ex.Message}");
            }
        }

        internal static List<T>? ReadXML<T>(string pathRelativeProjectSolution) where T : class, new()
        {
            List<T>? values = null;
            var serializerList = new XmlSerializer(typeof(List<T>));
            var filePath = Path.Combine(DataManager.ProjectPath, pathRelativeProjectSolution);
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    values = serializerList.Deserialize(reader) as List<T>;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"The file could not be read:\nIncorrect file path\n{ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"The file could not be read:\nFile Not Found\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The file could not be read:\n{ex.Message}");
            }
            return values;
        }
    }
}
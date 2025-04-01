using System.Xml.Serialization;

namespace GeniusIdiotConsoleApp.Data.XML
{
    public static class XMLManager
    {
        private static string _pathQuestionsXML = "Data/XML/XMLFiles/Questions.xml";
        private static string _pathUsersXML = "Data/XML/XMLFiles/Users.xml";
        internal static void WriteXML<T>(List<T> data) where T : class, new()
        {
            var serializerList = new XmlSerializer(typeof(List<T>));
            var filePath = Path.Combine(DataManager.ProjectPath, ChoosePath(data[0]));

            Record(data, serializerList, filePath);
        }

        internal static void WriteXML<T>(T data) where T : class, new()
        {
            var serializer = new XmlSerializer(typeof(T));
            var filePath = Path.Combine(DataManager.ProjectPath, ChoosePath(data));

            Record(data, serializer, filePath);
        }

        internal static List<T>? ReadXML<T>() where T : class, new()
        {
            List<T>? values = null;
            
            try
            {
                var serializerList = new XmlSerializer(typeof(List<T>));
                var filePath = Path.Combine(DataManager.ProjectPath, ChoosePath(typeof(T).Name));

                using (var reader = new StreamReader(filePath))
                {
                    values = serializerList.Deserialize(reader) as List<T>;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"The file could not be read:\nIncorrect file path\n{ex.Message}");
                return values;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"The file could not be read:\nFile Not Found\n{ex.Message}");
                return values;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The file could not be read:\n{ex.Message}");
                return values;
            }

            return values;
        }

        private static string ChoosePath<T>(T typeClass) => typeClass is User ? _pathUsersXML : _pathQuestionsXML;

        private static string ChoosePath(string typeClass) => typeClass == "User" ? _pathUsersXML : _pathQuestionsXML;

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
    }
}
using System.Xml.Serialization;

namespace GeniusIdiotConsoleApp.Data.XML
{
    public static class XMLManager
    {
        internal static void WriteXML<T>(List<T> ListSerialize)
        {
            var serializerList = new XmlSerializer(typeof(List<T>));
            using (var writer = new StreamWriter("DATA.xml", false))
            {
                serializerList.Serialize(writer, ListSerialize);
            }
        }
    }
}
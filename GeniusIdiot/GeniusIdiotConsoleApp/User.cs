using GeniusIdiotConsoleApp.Data.XML;
using System.Xml.Serialization;

namespace GeniusIdiotConsoleApp
{
    [Serializable]
    public class User
    {
        private int _bestResult = 0;
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string LevelKnowledge { get; set; }
        private static List<User> _users;
        public int BestResult
        {
            get => _bestResult;
            set
            {
                if (value > _bestResult)
                    _bestResult = value;
            }
        }
        public User(string lastName, string firstName) { LastName = lastName; FirstName = firstName; }
        public User() {}
        internal static List<User> GetUsers => _users ??= XMLManager.ReadXML<User>() ?? new List<User>();
        internal static void Save(User user)
        {
            var users = XMLManager.ReadXML<User>();
            users = GetUsers;
            users.Add(user);
            XMLManager.WriteXML(GetUsers);
        }
    }
}

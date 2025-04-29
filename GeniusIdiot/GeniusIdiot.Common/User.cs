namespace GeniusIdiot.Common
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
        public User() { }
        public static List<User> Users { get => _users ??= XMLManager.ReadXML<User>(string.Empty) ?? new List<User>(); }
        public static void GetUsersFromFileXML(string xmlStoragePath) => _users ??= XMLManager.ReadXML<User>(xmlStoragePath) ?? new List<User>();
    }
}

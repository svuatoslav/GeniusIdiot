namespace GeniusIdiotConsoleApp
{
    [Serializable]
    public class User
    {
        private int _bestResult = 0;
        public string FirstName { get; init; }
        public string LastName { get; init; }
        internal string LevelKnowledge { get; set; }
        internal int BestResult
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

    }
}

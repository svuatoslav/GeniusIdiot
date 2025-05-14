namespace GeniusIdiot.Common
{
    [Serializable]
    public class Question
    {
        private int _id;
        public int Id { get { return _id; } init { _id = value; } }
        public string Text { get; init; }
        public int Answer { get; init; }
        private static List<Question>? _questions;
        public Question(int id, string text, int answer) : this(text, answer) => Id = id;
        public Question(string text, int answer) : this() { Text = text; Answer = answer; }
        public Question() { }
        public static List<Question> Questions { get => _questions ??= XMLManager.ReadXML<Question>(string.Empty) ?? GetStandartQuestions(); }
        public static void GetQuestionsFromFileXML(string xmlStoragePath) => _questions ??= XMLManager.ReadXML<Question>(xmlStoragePath) ?? GetStandartQuestions();
        private static List<Question> GetStandartQuestions() => _questions = new List<Question>()
        {
            new(0, "Сколько будет два плюс два умноженное на два?", 6),
            new(1, "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new(2, "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new(3, "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new(4, "Пять свечей горело, две потухли. Сколько свечей осталось?", 3),
        };
        public static void Save(string xmlStoragePath)
        {
            RemoveDuplicatesByText();

            XMLManager.WriteXML(xmlStoragePath, Questions);
        }
        private static void RemoveDuplicatesByText()
        {
            _questions = Questions.DistinctBy(q => q.Text).ToList();

            CreateUniqueId();

        }
        public static void CreateUniqueId()
        {
            for (int i = 0; i < Questions.Count; i++)
                _questions[i]._id = i;
        }
    }
}
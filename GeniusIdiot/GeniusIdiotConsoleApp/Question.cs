using GeniusIdiotConsoleApp;
using GeniusIdiotConsoleApp.Data.XML;

namespace GeniusIdiotConsoleApp
{
    [Serializable]
    public class Question
    {
        public int Id { get; init; }
        public string Text { get; init; }
        public int Answer { get; init; }
        private static List<Question> _questions;
        public Question(int id, string text, int answer) { Id = id; Text = text; Answer = answer; }
        public Question() { }
        internal static List<Question> GetQuestions { get => _questions ??= XMLManager.ReadXML<Question>() ?? GetStandartQuestions(); }

        private static List<Question> GetStandartQuestions() => _questions = new List<Question>()
        {
            new Question(0, "Сколько будет два плюс два умноженное на два?", 6),
            new Question(1, "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new Question(2, "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question(3, "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new Question(4, "Пять свечей горело, две потухли. Сколько свечей осталось?", 3),
        };
    }
}
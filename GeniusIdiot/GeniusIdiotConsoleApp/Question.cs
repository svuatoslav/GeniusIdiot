using GeniusIdiotConsoleApp;
using GeniusIdiotConsoleApp.Data.XML;
using System.Xml;

namespace GeniusIdiotConsoleApp
{
    [Serializable]
    public class Question
    {
        private int _id;
        public int Id { get { return _id; } init { _id = value; } }
        public string Text { get; init; }
        public int Answer { get; init; }
        private static List<Question> _questions;
        public Question(int id, string text, int answer) { Id = id; Text = text; Answer = answer; }
        public Question(string text, int answer) { Text = text; Answer = answer; }
        public Question() { }
        public static List<Question> Questions { get => _questions ??= XMLManager.ReadXML<Question>() ?? GetStandartQuestions(); }

        private static List<Question> GetStandartQuestions() => _questions = new List<Question>()
        {
            new(0, "Сколько будет два плюс два умноженное на два?", 6),
            new(1, "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new(2, "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new(3, "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new(4, "Пять свечей горело, две потухли. Сколько свечей осталось?", 3),
        };
        internal static void Save()
        {
            RemoveDuplicatesByText();
            XMLManager.WriteXML(Questions);
        }
        private static void RemoveDuplicatesByText()
        {
            _questions = Questions.DistinctBy(q => q.Text).ToList();
            CreateUniqueNumbers();

        }
        internal static void CreateUniqueNumbers()
        {
            for (int i = 0; i < _questions.Count; i++)
                Questions[i]._id = i;
        }
        internal static void AddQuestion()
        {
            string text;
            int answer;

            do
            {
                Console.WriteLine("Введите вопрос");
                text = Console.ReadLine();
                Console.WriteLine("Введите ответ числом");
                answer = GeneralMethods.CheckNumber<int>(Console.ReadLine());

                Questions.Add(new Question(text, answer));
                Console.WriteLine("Создать ешё один вопрос?");
            }
            while (Console.ReadLine()?.ToLower() == "yes");

            Console.WriteLine("Присвивание уникальных id....");
            CreateUniqueNumbers();
        }
        internal static void RemoveQuestion()
        {
            int id;

            PrintQuestions();
            Console.WriteLine("Введите Id вопроса, которое хотите удалить из списка выше:");

            do
            {
                id = GeneralMethods.CheckNumber<int>(Console.ReadLine());
                Questions.RemoveAt(id);
                Console.WriteLine("Удалить ешё один вопрос?");
            }
            while (Console.ReadLine()?.ToLower() == "yes");
        }
        public static void PrintQuestions()
        {
            Console.WriteLine("Id\tВопрос\tОтвет");

            foreach (var question in Questions)
                Console.WriteLine($"{question.Id}\t{question.Text}\t{question.Answer}");
        }
    }
}
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
            new(0, "������� ����� ��� ���� ��� ���������� �� ���?", 6),
            new(1, "������ ����� ��������� �� 10 ������. ������� �������� ����� �������?", 9),
            new(2, "�� ���� ����� 10 �������. ������� ������� �� 5 �����?", 25),
            new(3, "���� ������ ������ �������. ������� ����� �����, ����� ������� ��� �����?", 60),
            new(4, "���� ������ ������, ��� �������. ������� ������ ��������?", 3),
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
                Console.WriteLine("������� ������");
                text = Console.ReadLine();
                Console.WriteLine("������� ����� ������");
                answer = GeneralMethods.CheckNumber<int>(Console.ReadLine());

                Questions.Add(new Question(text, answer));
                Console.WriteLine("������� ��� ���� ������?");
            }
            while (Console.ReadLine()?.ToLower() == "yes");

            Console.WriteLine("����������� ���������� id....");
            CreateUniqueNumbers();
        }
        internal static void RemoveQuestion()
        {
            int id;

            PrintQuestions();
            Console.WriteLine("������� Id �������, ������� ������ ������� �� ������ ����:");

            do
            {
                id = GeneralMethods.CheckNumber<int>(Console.ReadLine());
                Questions.RemoveAt(id);
                Console.WriteLine("������� ��� ���� ������?");
            }
            while (Console.ReadLine()?.ToLower() == "yes");
        }
        public static void PrintQuestions()
        {
            Console.WriteLine("Id\t������\t�����");

            foreach (var question in Questions)
                Console.WriteLine($"{question.Id}\t{question.Text}\t{question.Answer}");
        }
    }
}
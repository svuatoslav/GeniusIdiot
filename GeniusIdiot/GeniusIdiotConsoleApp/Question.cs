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
            new Question(0, "������� ����� ��� ���� ��� ���������� �� ���?", 6),
            new Question(1, "������ ����� ��������� �� 10 ������. ������� �������� ����� �������?", 9),
            new Question(2, "�� ���� ����� 10 �������. ������� ������� �� 5 �����?", 25),
            new Question(3, "���� ������ ������ �������. ������� ����� �����, ����� ������� ��� �����?", 60),
            new Question(4, "���� ������ ������, ��� �������. ������� ������ ��������?", 3),
        };
    }
}
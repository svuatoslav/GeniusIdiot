namespace GeniusIdiot.Common
{
    [Serializable]
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; init; }
        
        public int Answer { get; init; }
        
        private static List<Question>? _questions;
        
        public Question(int id, string text, int answer) : this(text, answer) => Id = id;
        
        public Question(string text, int answer) : this() { Text = text; Answer = answer; }
        
        public Question() { }
        
        public static List<Question> Questions { get => _questions ??= JSONManager.ReadJSON<Question>(string.Empty) ?? XMLManager.ReadXML<Question>(string.Empty) ?? GetStandartQuestions(); }
        
        public static void GetQuestionsFromFileXML(string xmlStoragePath) => _questions ??= XMLManager.ReadXML<Question>(xmlStoragePath) ?? GetStandartQuestions();
        
        public static void GetQuestionsFromFileJSON(string jsonStoragePath) => _questions ??= JSONManager.ReadJSON<Question>(jsonStoragePath) ?? GetStandartQuestions();
        
        private static List<Question> GetStandartQuestions() => _questions = new List<Question>()
        {
            new(0, "������� ����� ��� ���� ��� ���������� �� ���?", 6),
            new(1, "������ ����� ��������� �� 10 ������. ������� �������� ����� �������?", 9),
            new(2, "�� ���� ����� 10 �������. ������� ������� �� 5 �����?", 25),
            new(3, "���� ������ ������ �������. ������� ����� �����, ����� ������� ��� �����?", 60),
            new(4, "���� ������ ������, ��� �������. ������� ������ ��������?", 3),
        };
        
        public static void Save(string jsonStoragePath)
        {
            RemoveDuplicatesByText();

            JSONManager.WriteJSON(jsonStoragePath, Questions);
        }
        
        private static void RemoveDuplicatesByText()
        {
            _questions = Questions.DistinctBy(q => q.Text).ToList();

            CreateUniqueId();

        }
        
        public static void CreateUniqueId()
        {
            for (int i = 0; i < Questions.Count; i++)
                _questions[i].Id = i;
        }
    }
}
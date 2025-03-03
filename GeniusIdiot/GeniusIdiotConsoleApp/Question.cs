namespace GeniusIdiotConsoleApp
{
    [Serializable]
    public class Question
    {
        public int Id { get; init; }
        public string Text { get; init; }
        public int Answer { get; init; }
        public Question(int id, string text, int answer) { Id = id; Text = text; Answer = answer; }
        public Question() {}
    }
}
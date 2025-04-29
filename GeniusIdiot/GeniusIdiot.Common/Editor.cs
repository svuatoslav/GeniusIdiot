namespace GeniusIdiot.Common
{
    public static class Editor
    {
        public static void EditTests(Test test, IMessage message, string pathSave)
        {
            message.Write("Это редактор вопросника!");

            message.Write("Написать список вопросов?\nНеобходимо написать \"Yes\"");

            if (message.Read().ToLower() == "yes")
                PrintQuestions(message);

            message.Write("Добавить вопросы?\nНеобходимо написать \"Yes\"");

            if (message.Read().ToLower() == "yes")
                AddQuestion(message);

            message.Write("Удалить вопросы?\nНеобходимо написать \"Yes\"");

            if (message.Read().ToLower() == "yes")
                RemoveQuestion(message);

            Question.Save(pathSave);
        }
        private static void AddQuestion(IMessage message)
        {
            string text;
            int answer;

            do
            {
                message.Write("Введите вопрос");
                text = message.Read();
                message.Write("Введите ответ числом");
                answer = GeneralMethods.CheckNumber<int>(message.Read(), message);

                Question.Questions.Add(new Question(text, answer));
                message.Write("Создать ешё один вопрос?\nНеобходимо написать \"Yes\"");
            }
            while (message.Read().ToLower() == "yes");

            message.Write("Присвивание уникальных id....");
            Question.CreateUniqueId();
        }
        private static void RemoveQuestion(IMessage message)
        {
            int id;

            PrintQuestions(message);
            message.Write("Введите Id вопроса, которое хотите удалить из списка выше:");

            do
            {
                id = GeneralMethods.CheckNumber<int>(message.Read(), message);
                Question.Questions.RemoveAt(id);
                message.Write("Удалить ешё один вопрос?\nНеобходимо написать \"Yes\"");
            }
            while (message.Read().ToLower() == "yes");
        }

        private static void PrintQuestions(IMessage message)
        {
            message.Write("Id\tВопрос\tОтвет");

            var sortedQuestions = Question.Questions.OrderBy(q => q.Id).ToList();

            foreach (var question in sortedQuestions)
                message.Write($"{question.Id}\t{question.Text}\t{question.Answer}");
        }
    }
}

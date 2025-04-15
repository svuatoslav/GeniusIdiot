using System.Timers;
using GeniusIdiotConsoleApp.Data;

namespace GeniusIdiotConsoleApp
{
    public static class Questionnaire
    {
        private static bool _timeElapsed = false;
        internal static void FormFilling()
        {
            Console.WriteLine("Заполните анкету.\nНапишите сначала фамилию, потом имя через Enter");

            var user = new User(Console.ReadLine(), Console.ReadLine());

            Interviewing(user, Question.Questions);
        }
        internal static void Interviewing(User user, List<Question> questions)
        {
            int countCorrectAnswers;
            do
            {
                var timer = new System.Timers.Timer(10000);
                timer.Elapsed += OnTimerElapsed;
                timer.AutoReset = false;

                countCorrectAnswers = 0;

                GeneralMethods.ShuffleList(questions);

                for (int i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine($"Вопрос под номером {i + 1}\nНа ответ 10 секунд.");
                    Console.WriteLine(questions[i].Text);
                    _timeElapsed = false;
                    
                    timer.Start();
                    int input = GeneralMethods.CheckInt(Console.ReadLine(), !_timeElapsed);
                    timer.Stop();

                    if (!_timeElapsed)
                        if (questions[i].Answer == input)
                            countCorrectAnswers++;
                    
                }

                user.LevelKnowledge = DataManager.GetDiagnosis(questions.Count, countCorrectAnswers);
                user.BestResult = countCorrectAnswers;

                Console.WriteLine($"{user.LastName} {user.FirstName}, ваш диагноз: {user.LevelKnowledge} " +
                $"c {countCorrectAnswers} правильными ответами, Ваш лучший результат {user.BestResult}." +
                "\nЕсли хотите повторить напишите \"Yes\"");
            }
            while (Console.ReadLine()?.ToLower() == "yes");

            User.Save(user);
        }
        private static void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Время истекло, нажмите Enter");
            _timeElapsed = true;
        }
        internal static void Edit()
        {
            Console.WriteLine("Это редактор вопросника!");

            Console.WriteLine("Написать список вопросов?\nНеобходимо написать \"Yes\"");

            if (Console.ReadLine()?.ToLower() == "yes")
                Question.PrintQuestions();

                Console.WriteLine("Добавить вопросы?\nНеобходимо написать \"Yes\"");

            if (Console.ReadLine()?.ToLower() == "yes")
                Question.AddQuestion();

            Console.WriteLine("Удалить вопросы?\nНеобходимо написать \"Yes\"");

            if (Console.ReadLine()?.ToLower() == "yes")
                Question.RemoveQuestion();

            Question.Save();

        }

    }
}
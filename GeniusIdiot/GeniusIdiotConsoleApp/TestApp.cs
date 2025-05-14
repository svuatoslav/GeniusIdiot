using GeniusIdiot.Common;
using System.Timers;

namespace GeniusIdiotConsoleApp
{
    public sealed class TestApp : BaseTest
    {
        private MessageManager _message = new();
        private bool _timeUp = true;
        public TestApp(List<Question> questions, string rootPathFiles) 
        {
            Questions = questions;
            _rootPathFiles = rootPathFiles;
        }
        internal void Testing()
        {
            var user = FormFilling();

            Interviewing(user);

            SaveResults(user, _rootPathFiles);
        }
        private User FormFilling()
        {
            _message.Write("Заполните анкету.\nНапишите сначала фамилию, потом имя через Enter");

            var user = new User(_message.Read(), _message.Read());

            return user;
        }

        protected override void Interviewing(User user, int countCorrectAnswers = 0)
        {
            do
            {
                var timer = new System.Timers.Timer(10000);
                timer.Elapsed += OnTimerElapsed;
                timer.AutoReset = false;

                GeneralMethods.ShuffleList(Questions);

                for (int i = 0; i < Questions.Count; i++)
                {
                    _message.Write($"Вопрос под номером {i + 1}\nНа ответ 10 секунд.");
                    _message.Write(Questions[i].Text);
                    _timeUp = true;
                    
                    timer.Start();
                    int? input = GeneralMethods.CheckInt(_message.Read(), ref _timeUp, _message);
                    timer.Stop();

                    if (_timeUp)
                        if (Questions[i].Answer == input)
                            countCorrectAnswers++;
                }

                CalculatingResults(user, countCorrectAnswers);

                ShowResults(user, countCorrectAnswers, _message);

                _message.Write("Если хотите повторить напишите \"Yes\"");
            }
            while (_message.Read().ToLower() == "yes");
        }

        public override void ShowResults(User user, int countCorrectAnswers, IMessage message) => message.Write(
            $"{user.LastName} {user.FirstName}, ваш диагноз: {user.LevelKnowledge} " +
            $"c {countCorrectAnswers} правильными ответами, Ваш лучший результат {user.BestResult}.");

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _message.Write("Время истекло. Перейдите к следующему вопросу.");
            _timeUp = false;
        }

    }
}
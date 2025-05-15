using GeniusIdiot.Common;
using System.Windows.Forms;

namespace GeniusIdiotWinFormsApp
{
    public sealed class TestControl : BaseTest
    {
        private int _questionCounter = 0;

        public TestControl(List<Question> questions, string rootPathFiles) 
        {
            Questions = questions; 
            _rootPathFiles = rootPathFiles; 
        }

        public override void ShowResults(User user, int countCorrectAnswers, IMessage message) => message.Write(
            $"{user.LastName} {user.FirstName}, ваш диагноз: {user.LevelKnowledge} " +
            $"c {countCorrectAnswers} правильными ответами, Ваш лучший результат {user.BestResult}.");

        protected override void Interviewing(User user, int countCorrectAnswers = 0) => CalculatingResults(user, countCorrectAnswers);

        internal Question? NextQuestion(User user, int? answer, ref int countCorrectAnswers)
        {
            if (answer is not null)
                if (Questions[_questionCounter].Answer == answer)
                    countCorrectAnswers++;

            _questionCounter++;
            if (Questions.Count > _questionCounter) return Questions[_questionCounter];
            else
            {
                Interviewing(user, countCorrectAnswers);
                return null;
            }
        }

        internal void RestartTest() => _questionCounter = 0;

        internal void Save(User user) => SaveResults(user, _rootPathFiles);
    }
}
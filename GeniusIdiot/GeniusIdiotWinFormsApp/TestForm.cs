using GeniusIdiot.Common;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GeniusIdiotWinFormsApp
{
    public partial class TestForm : Form
    {
        private static int _maxTime = 10;
        private int _time = 0;
        private int _countCorrectAnswers = 0;
        private TestControl _myTest { get; init; }
        private User _user { get; init; }

        private bool _timer = true;
        private readonly MessageManager _message;

        private TestForm()
        {
            InitializeComponent();

            _message = new(AnswerToQuestionTextBox);

            SwitchingButtons(false);

            _myTest = new(Question.Questions, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));

            QuestionTextLabel.Text = _myTest.Questions[0].Text;
            QuestionTimer.Start();

        }

        public TestForm(User user) : this() => _user = user;

        private void FinishTestButton_Click(object sender, EventArgs e)
        {
            _myTest.Save(_user);
            Close();
        }

        private void RestartTestButton_Click(object sender, EventArgs e)
        {
            SwitchingButtons(false);

            _myTest.RestertTest();
            QuestionTextLabel.Text = _myTest.Questions[0].Text;

            _timer = true;
            QuestionTimer.Start();

            _countCorrectAnswers = 0;
            _time = 0;
        }

        private void NextQuestionbutton_Click(object sender, EventArgs e)
        {
            int? answer = _timer && AnswerToQuestionTextBox.Text != "" ? int.Parse(AnswerToQuestionTextBox.Text) : null;

            Question? question = _myTest.NextQuestion(_user, answer, ref _countCorrectAnswers);

            if (question is not null)
            {
                QuestionTextLabel.Text = question.Text;

                TimerTextLabel.Text = $"Осталось {_maxTime} секунд";
                _timer = true;
                _time = 0;
                QuestionTimer.Start();
            }
            else
            {
                QuestionTimer.Stop();
                _myTest.ShowResults(_user, _countCorrectAnswers, _message);
                _message.Write("Тест закончился.\n Вы можете сохранить результаты или перезапустить тест");
                SwitchingButtons(true);
            }
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            _time++;

            if (_time == _maxTime)
            {
                QuestionTimer.Stop();
                _timer = false;
                _message.Write("Время истекло, перейдите к следующему вопросу");
            }

            TimerTextLabel.Text = $"Осталось {_maxTime - _time} секунд";
        }

        private void SwitchingButtons(bool activity)
        {
            RestartTestButton.Enabled = activity;
            FinishTestButton.Enabled = activity;
        }

        private void AnswerToQuestionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out int _) && e.KeyChar != '\b')
            {
                _message.Write("Пожалуйста, вводите цифры");
                e.Handled = true;
            }
        }

    }
}

using GeniusIdiotConsoleApp.Data.XML;

namespace GeniusIdiotConsoleApp.Data
{
    public class DataManager
    {
        private List<Question> _questions;
        internal static string ProjectPath
        {
            get => Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../"));
        }
        internal List<Question> Questions { get => _questions; }
        private List<Question> GetStandartQuestions() => _questions = new List<Question>()
        {
            new Question(0, "Сколько будет два плюс два умноженное на два?", 6),
            new Question(1, "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new Question(2, "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question(3, "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new Question(4, "Пять свечей горело, две потухли. Сколько свечей осталось?", 3)
        };
        public DataManager(string pathRelativeProjectSolutionXML)
        {
            var temp = XMLManager.ReadXML<Question>(pathRelativeProjectSolutionXML);
            _questions = temp == null ? GetStandartQuestions() : temp;
        } 
        
        internal static Dictionary<double, string> GetDiagnoses(int countQuestions) => new Dictionary<double, string>()
        {
            {0, "кретин"},
            {(double)countQuestions / 100 * 20, "идиот"},
            {(double)countQuestions / 100 * 40, "дурак"},
            {(double)countQuestions / 100 * 60, "нормальный"},
            {(double)countQuestions / 100 * 80, "талант"},
            {countQuestions, "гений"}
        };
        internal static string GetDiagnosis(int countQuestions, int countCorrectAnswers)
        {
            Dictionary<double, string> diagnoses = GetDiagnoses(countQuestions);
            string diagnos = "гений";
            foreach (var score in diagnoses.Keys)
                if (countCorrectAnswers >= score)
                    diagnos = diagnoses[score];
                else
                    return diagnos;
            return diagnos;
        }
    }
}

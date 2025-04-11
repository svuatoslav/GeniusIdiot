namespace GeniusIdiotConsoleApp.Data
{
    public static class DataManager
    {
        internal static string ProjectPath
        { get => Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\")); }

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
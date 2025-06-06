using GeniusIdiot.Common;

namespace GeniusIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FileLogger.Path = StoragePath.PathLogs;
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            Question.GetQuestionsFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
            User.GetUsersFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));

            var testForm = new TestForm(registrationForm.User);
            testForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Question.GetQuestionsFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
            var editorForm = new EditorForm();
            editorForm.ShowDialog();
            //GeniusIdiot.Common.EditTests();

            //Editor.EditTests(_test, _messageManager, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
        }

        private void Results_Click(object sender, EventArgs e)
        {
            User.GetUsersFromFileJSON(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
    }
}

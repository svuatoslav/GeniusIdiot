using GeniusIdiot.Common;

namespace GeniusIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        internal static MainForm MainMenuForm { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            MainMenuForm = this;

            FileLogger.Path = StoragePath.PathLogs;
            
        }
        private void StartTestButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

            Question.GetQuestionsFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
            User.GetUsersFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));

            var testForm = new TestForm(registrationForm.User);
            testForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Question.GetQuestionsFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
            var editorForm = new EditorForm();
            editorForm.ShowDialog();
            //GeniusIdiot.Common.EditTests();

            //Editor.EditTests(_test, _messageManager, Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
        }

        private void Results_Click(object sender, EventArgs e)
        {
            User.GetUsersFromFileXML(Path.Combine(StoragePath.ProjectPath, StoragePath.PathXMLsStorage));
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
    }
}

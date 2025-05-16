using GeniusIdiot.Common;

namespace GeniusIdiotWinFormsApp
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion() => QuestionBindingSource.DataSource = Question.Questions;

        private void SaveQuestions_Click(object sender, EventArgs e)
        {
            Question.Save(Path.Combine(StoragePath.ProjectPath, StoragePath.PathJSONsStorage));
            Close();
        }

        private void QuestionDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (QuestionDataGridView.Columns[e.ColumnIndex].DataPropertyName == "Answer")
            {
                MessageBox.Show(
                    "Ошибка: Поле 'Ответ' должно содержать целое число!",
                    "Некорректные данные",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                QuestionDataGridView.CancelEdit();
            }
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionDataGridView.CurrentRow.IsNewRow) return;

            var selectedQuestion = (Question)QuestionDataGridView.CurrentRow.DataBoundItem;

            Question.Questions.Remove(selectedQuestion);

            QuestionBindingSource.ResetBindings(false); 
        }

        private void QuestionDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var hitTest = QuestionDataGridView.HitTest(e.X, e.Y);
            if (hitTest.RowIndex >= 0 && !QuestionDataGridView.Rows[hitTest.RowIndex].IsNewRow)
            {
                QuestionDataGridView.Rows[hitTest.RowIndex].Selected = true;
                QuestionContextMenu.Show(QuestionDataGridView, e.Location);
            }
        }
    }
}

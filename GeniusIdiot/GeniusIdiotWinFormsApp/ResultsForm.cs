using GeniusIdiot.Common;

namespace GeniusIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            foreach (var user in User.Users)
            {
                var lvi = new ListViewItem(user.FirstName);
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.LevelKnowledge);

                UsersListView.Items.Add(lvi);
            }

        }

        private void Exit_Click(object sender, EventArgs e) => Close();
    }
}

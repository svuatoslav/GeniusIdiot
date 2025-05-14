using GeniusIdiot.Common;
using System.Xml.Linq;

namespace GeniusIdiotWinFormsApp
{
    public partial class RegistrationForm : Form
    {
        public User User { get; private set; }
        public RegistrationForm() { InitializeComponent(); }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            if (!Check())
                MessageBox.Show("Заполните все поля!"); 
            else
                User = new User(NameTextBox.Text, LastNameTextBox.Text);

            Close();
        }
        private bool Check() => NameTextBox.Text != string.Empty && LastNameTextBox.Text != string.Empty;
    }
}

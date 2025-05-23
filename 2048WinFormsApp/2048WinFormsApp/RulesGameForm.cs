using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class RulesGameForm : Form
    {
        public RulesGameForm()
        {
            InitializeComponent();
        }

        private void ButtionRestart_Click(object sender, EventArgs e) => Application.Exit();
    }
}

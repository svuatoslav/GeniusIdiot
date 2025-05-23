namespace _2048WinFormsApp
{
    partial class RulesGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtionRestart = new Button();
            listView1 = new ListView();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // ButtionRestart
            // 
            ButtionRestart.BackColor = SystemColors.WindowText;
            ButtionRestart.ForeColor = SystemColors.Window;
            ButtionRestart.Location = new Point(963, 575);
            ButtionRestart.Name = "ButtionRestart";
            ButtionRestart.Size = new Size(225, 75);
            ButtionRestart.TabIndex = 10;
            ButtionRestart.Text = "Закрыть";
            ButtionRestart.UseVisualStyleBackColor = false;
            ButtionRestart.Click += ButtionRestart_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(290, 159);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(689, 400);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 12;
            // 
            // RulesGameForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1200, 684);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(ButtionRestart);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RulesGameForm";
            Text = "RulesGameForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtionRestart;
        private ListView listView1;
        private TreeView treeView1;
    }
}
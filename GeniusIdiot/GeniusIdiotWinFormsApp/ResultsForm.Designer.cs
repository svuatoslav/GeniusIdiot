namespace GeniusIdiotWinFormsApp
{
    partial class ResultsForm
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
            UsersListView = new ListView();
            FirstNameColumn = new ColumnHeader();
            LastNameColumn = new ColumnHeader();
            LevelKnowledgeColumn = new ColumnHeader();
            Exit = new Button();
            SuspendLayout();
            // 
            // UsersListView
            // 
            UsersListView.Columns.AddRange(new ColumnHeader[] { FirstNameColumn, LastNameColumn, LevelKnowledgeColumn });
            UsersListView.Location = new Point(3, 3);
            UsersListView.Name = "UsersListView";
            UsersListView.Size = new Size(950, 735);
            UsersListView.TabIndex = 0;
            UsersListView.UseCompatibleStateImageBehavior = false;
            UsersListView.View = View.Details;
            // 
            // FirstNameColumn
            // 
            FirstNameColumn.Text = "Имя";
            FirstNameColumn.Width = 350;
            // 
            // LastNameColumn
            // 
            LastNameColumn.Text = "Фамилия";
            LastNameColumn.TextAlign = HorizontalAlignment.Center;
            LastNameColumn.Width = 350;
            // 
            // LevelKnowledgeColumn
            // 
            LevelKnowledgeColumn.Text = "Уровень Знаний";
            LevelKnowledgeColumn.TextAlign = HorizontalAlignment.Center;
            LevelKnowledgeColumn.Width = 200;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.InfoText;
            Exit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Exit.ForeColor = SystemColors.Window;
            Exit.Location = new Point(968, 676);
            Exit.Margin = new Padding(5);
            Exit.Name = "Exit";
            Exit.Size = new Size(275, 60);
            Exit.TabIndex = 5;
            Exit.Text = "Вернуться в главное меню";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1257, 750);
            Controls.Add(Exit);
            Controls.Add(UsersListView);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Menu;
            Margin = new Padding(5);
            Name = "ResultsForm";
            Text = "ResultsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView UsersListView;
        private ColumnHeader FirstNameColumn;
        private ColumnHeader LastNameColumn;
        private ColumnHeader LevelKnowledgeColumn;
        private Button Exit;
    }
}
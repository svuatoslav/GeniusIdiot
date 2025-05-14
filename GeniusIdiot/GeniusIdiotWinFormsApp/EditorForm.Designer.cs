using System.Windows.Forms;

namespace GeniusIdiotWinFormsApp
{
    partial class EditorForm
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
            components = new System.ComponentModel.Container();
            QuestionDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            answerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QuestionBindingSource = new BindingSource(components);
            SaveQuestions = new Button();
            QuestionContextMenu = new ContextMenuStrip(components);
            DeleteQuestionToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)QuestionDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuestionBindingSource).BeginInit();
            QuestionContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionDataGridView
            // 
            QuestionDataGridView.AutoGenerateColumns = false;
            QuestionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, answerDataGridViewTextBoxColumn });
            QuestionDataGridView.DataSource = QuestionBindingSource;
            QuestionDataGridView.Location = new Point(3, 3);
            QuestionDataGridView.Name = "QuestionDataGridView";
            QuestionDataGridView.Size = new Size(1026, 735);
            QuestionDataGridView.TabIndex = 4;
            QuestionDataGridView.DataError += QuestionDataGridView_DataError;
            QuestionDataGridView.MouseClick += QuestionDataGridView_MouseClick;
            QuestionDataGridView.ContextMenuStrip = QuestionContextMenu;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Номер";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Вопрос";
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            textDataGridViewTextBoxColumn.Width = 101;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            answerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            answerDataGridViewTextBoxColumn.HeaderText = "Ответ";
            answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            answerDataGridViewTextBoxColumn.Width = 87;
            // 
            // QuestionBindingSource
            // 
            QuestionBindingSource.DataSource = typeof(GeniusIdiot.Common.Question);
            // 
            // SaveQuestions
            // 
            SaveQuestions.BackColor = SystemColors.WindowText;
            SaveQuestions.ForeColor = SystemColors.Window;
            SaveQuestions.Location = new Point(1035, 321);
            SaveQuestions.Name = "SaveQuestions";
            SaveQuestions.Size = new Size(200, 50);
            SaveQuestions.TabIndex = 7;
            SaveQuestions.Text = "Сохранить вопросы";
            SaveQuestions.UseVisualStyleBackColor = false;
            SaveQuestions.Click += SaveQuestions_Click;
            // 
            // QuestionContextMenu
            // 
            QuestionContextMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuestionContextMenu.Items.AddRange(new ToolStripItem[] { DeleteQuestionToolStripMenuItem });
            QuestionContextMenu.Name = "QuestionContextMenu";
            QuestionContextMenu.Size = new Size(172, 26);
            // 
            // DeleteQuestionToolStripMenuItem
            // 
            DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem";
            DeleteQuestionToolStripMenuItem.Size = new Size(171, 22);
            DeleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            DeleteQuestionToolStripMenuItem.Click += DeleteQuestionToolStripMenuItem_Click;
            // 
            // EditorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1257, 750);
            Controls.Add(SaveQuestions);
            Controls.Add(QuestionDataGridView);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "EditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)QuestionDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuestionBindingSource).EndInit();
            QuestionContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView QuestionDataGridView;
        private BindingSource QuestionBindingSource;
        private Button SaveQuestions;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private ContextMenuStrip QuestionContextMenu;
        private ToolStripMenuItem DeleteQuestionToolStripMenuItem;
    }
}
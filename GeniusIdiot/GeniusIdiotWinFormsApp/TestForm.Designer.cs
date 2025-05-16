namespace GeniusIdiotWinFormsApp
{
    partial class TestForm
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
            RestartTestButton = new Button();
            QuestionTextLabel = new Label();
            AnswerToQuestionTextBox = new TextBox();
            QuestionTimer = new System.Windows.Forms.Timer(components);
            FinishTestButton = new Button();
            TimerTextLabel = new Label();
            NextQuestionbutton = new Button();
            SuspendLayout();
            // 
            // RestartTestButton
            // 
            RestartTestButton.BackColor = SystemColors.WindowText;
            RestartTestButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RestartTestButton.ForeColor = SystemColors.Window;
            RestartTestButton.Location = new Point(91, 628);
            RestartTestButton.Margin = new Padding(5);
            RestartTestButton.Name = "RestartTestButton";
            RestartTestButton.Size = new Size(278, 67);
            RestartTestButton.TabIndex = 1;
            RestartTestButton.Text = "Перепройти тест";
            RestartTestButton.UseVisualStyleBackColor = false;
            RestartTestButton.Click += RestartTestButton_Click;
            // 
            // QuestionTextLabel
            // 
            QuestionTextLabel.AutoSize = true;
            QuestionTextLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuestionTextLabel.Location = new Point(541, 200);
            QuestionTextLabel.Margin = new Padding(5, 0, 5, 0);
            QuestionTextLabel.Name = "QuestionTextLabel";
            QuestionTextLabel.Size = new Size(76, 25);
            QuestionTextLabel.TabIndex = 2;
            QuestionTextLabel.Text = "Вопрос";
            // 
            // AnswerToQuestionTextBox
            // 
            AnswerToQuestionTextBox.BackColor = SystemColors.WindowText;
            AnswerToQuestionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AnswerToQuestionTextBox.ForeColor = SystemColors.Window;
            AnswerToQuestionTextBox.Location = new Point(457, 362);
            AnswerToQuestionTextBox.Margin = new Padding(5);
            AnswerToQuestionTextBox.Name = "AnswerToQuestionTextBox";
            AnswerToQuestionTextBox.Size = new Size(293, 33);
            AnswerToQuestionTextBox.TabIndex = 3;
            AnswerToQuestionTextBox.KeyPress += AnswerToQuestionTextBox_KeyPress;
            // 
            // QuestionTimer
            // 
            QuestionTimer.Enabled = true;
            QuestionTimer.Interval = 1000;
            QuestionTimer.Tick += QuestionTimer_Tick;
            // 
            // FinishTestButton
            // 
            FinishTestButton.BackColor = SystemColors.InfoText;
            FinishTestButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FinishTestButton.ForeColor = SystemColors.Window;
            FinishTestButton.Location = new Point(825, 627);
            FinishTestButton.Margin = new Padding(5);
            FinishTestButton.Name = "FinishTestButton";
            FinishTestButton.Size = new Size(325, 68);
            FinishTestButton.TabIndex = 4;
            FinishTestButton.Text = "Заквершить тест";
            FinishTestButton.UseVisualStyleBackColor = false;
            FinishTestButton.Click += FinishTestButton_Click;
            // 
            // TimerTextLabel
            // 
            TimerTextLabel.AutoSize = true;
            TimerTextLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TimerTextLabel.ForeColor = Color.FromArgb(192, 0, 0);
            TimerTextLabel.Location = new Point(497, 112);
            TimerTextLabel.Margin = new Padding(5, 0, 5, 0);
            TimerTextLabel.Name = "TimerTextLabel";
            TimerTextLabel.Size = new Size(181, 25);
            TimerTextLabel.TabIndex = 5;
            TimerTextLabel.Text = "Осталось 10 секунд";
            // 
            // NextQuestionbutton
            // 
            NextQuestionbutton.BackColor = SystemColors.WindowText;
            NextQuestionbutton.ForeColor = SystemColors.Window;
            NextQuestionbutton.Location = new Point(480, 461);
            NextQuestionbutton.Name = "NextQuestionbutton";
            NextQuestionbutton.Size = new Size(203, 57);
            NextQuestionbutton.TabIndex = 6;
            NextQuestionbutton.Text = "Следующий вопрос";
            NextQuestionbutton.UseVisualStyleBackColor = false;
            NextQuestionbutton.Click += NextQuestionbutton_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1257, 750);
            Controls.Add(NextQuestionbutton);
            Controls.Add(TimerTextLabel);
            Controls.Add(FinishTestButton);
            Controls.Add(AnswerToQuestionTextBox);
            Controls.Add(QuestionTextLabel);
            Controls.Add(RestartTestButton);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "TestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RestartTestButton;
        private Label QuestionTextLabel;
        private TextBox AnswerToQuestionTextBox;
        private System.Windows.Forms.Timer QuestionTimer;
        private Button FinishTestButton;
        private Label TimerTextLabel;
        private Button NextQuestionbutton;
    }
}
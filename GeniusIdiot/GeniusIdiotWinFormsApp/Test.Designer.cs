namespace GeniusIdiotWinFormsApp
{
    partial class Test
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
            RestartTest = new Button();
            QuestionText = new Label();
            textBox1 = new TextBox();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // RestartTest
            // 
            RestartTest.Location = new Point(287, 289);
            RestartTest.Name = "RestartTest";
            RestartTest.Size = new Size(100, 39);
            RestartTest.TabIndex = 1;
            RestartTest.Text = "Перепройти тест";
            RestartTest.UseVisualStyleBackColor = true;
            // 
            // QuestionText
            // 
            QuestionText.AutoSize = true;
            QuestionText.Location = new Point(339, 145);
            QuestionText.Name = "QuestionText";
            QuestionText.Size = new Size(48, 15);
            QuestionText.TabIndex = 2;
            QuestionText.Text = "Вопрос";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(484, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // Timer
            // 
            Timer.Interval = 10000;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(QuestionText);
            Controls.Add(RestartTest);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RestartTest;
        private Label QuestionText;
        private TextBox textBox1;
        private System.Windows.Forms.Timer Timer;
    }
}
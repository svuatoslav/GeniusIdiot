namespace GeniusIdiotWinFormsApp
{
    partial class RegistrationForm
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
            NameTextBox = new TextBox();
            NameLabel = new Label();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            SaveUserButton = new Button();
            WarningLabel = new Label();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = SystemColors.WindowText;
            NameTextBox.ForeColor = SystemColors.Window;
            NameTextBox.Location = new Point(511, 207);
            NameTextBox.Margin = new Padding(5);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(283, 33);
            NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = SystemColors.WindowFrame;
            NameLabel.ForeColor = SystemColors.WindowText;
            NameLabel.Location = new Point(339, 210);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(146, 25);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Заполните Имя";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.BackColor = SystemColors.WindowFrame;
            LastNameLabel.ForeColor = SystemColors.WindowText;
            LastNameLabel.Location = new Point(292, 278);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(193, 25);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Заполните Фамилию";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BackColor = SystemColors.WindowText;
            LastNameTextBox.ForeColor = SystemColors.Window;
            LastNameTextBox.Location = new Point(511, 275);
            LastNameTextBox.Margin = new Padding(5);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(283, 33);
            LastNameTextBox.TabIndex = 3;
            // 
            // SaveUserButton
            // 
            SaveUserButton.BackColor = SystemColors.WindowText;
            SaveUserButton.ForeColor = SystemColors.Window;
            SaveUserButton.Location = new Point(920, 401);
            SaveUserButton.Name = "SaveUserButton";
            SaveUserButton.Size = new Size(119, 38);
            SaveUserButton.TabIndex = 4;
            SaveUserButton.Text = "Сохранить";
            SaveUserButton.UseVisualStyleBackColor = false;
            SaveUserButton.Click += SaveUserButton_Click;
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.BackColor = SystemColors.WindowFrame;
            WarningLabel.ForeColor = Color.Maroon;
            WarningLabel.Location = new Point(491, 121);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(303, 25);
            WarningLabel.TabIndex = 5;
            WarningLabel.Text = "Необходимо заполнить все поля!";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1257, 750);
            Controls.Add(WarningLabel);
            Controls.Add(SaveUserButton);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameTextBox);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Window;
            Margin = new Padding(5);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private Label NameLabel;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private Button SaveUserButton;
        private Label WarningLabel;
    }
}
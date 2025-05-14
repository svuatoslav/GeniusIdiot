namespace GeniusIdiotWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartTestButton = new Button();
            ExitButton = new Button();
            EditButton = new Button();
            Results = new Button();
            SuspendLayout();
            // 
            // StartTestButton
            // 
            StartTestButton.BackColor = SystemColors.WindowText;
            StartTestButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StartTestButton.ForeColor = SystemColors.Window;
            StartTestButton.Location = new Point(71, 304);
            StartTestButton.Margin = new Padding(5);
            StartTestButton.Name = "StartTestButton";
            StartTestButton.Size = new Size(225, 50);
            StartTestButton.TabIndex = 0;
            StartTestButton.Text = "Начать тестирование";
            StartTestButton.UseVisualStyleBackColor = false;
            StartTestButton.Click += StartTestButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.WindowText;
            ExitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitButton.ForeColor = SystemColors.Window;
            ExitButton.Location = new Point(71, 597);
            ExitButton.Margin = new Padding(5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 50);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.WindowText;
            EditButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditButton.ForeColor = SystemColors.Window;
            EditButton.Location = new Point(71, 413);
            EditButton.Margin = new Padding(5);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(125, 50);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактор";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // Results
            // 
            Results.BackColor = SystemColors.WindowText;
            Results.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Results.ForeColor = SystemColors.Window;
            Results.Location = new Point(71, 509);
            Results.Margin = new Padding(5);
            Results.Name = "Results";
            Results.Size = new Size(275, 50);
            Results.TabIndex = 3;
            Results.Text = "Посмотреть результаты игр";
            Results.UseVisualStyleBackColor = false;
            Results.Click += Results_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1257, 750);
            Controls.Add(Results);
            Controls.Add(EditButton);
            Controls.Add(ExitButton);
            Controls.Add(StartTestButton);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений Идиот";
            ResumeLayout(false);
        }

        #endregion

        private Button StartTestButton;
        private Button ExitButton;
        private Button EditButton;
        private Button Results;
    }
}

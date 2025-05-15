namespace _2048WinFormsApp
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
            LabelCell = new Label();
            ButtinExit = new Button();
            ButtionRestart = new Button();
            ButtonRulesGame = new Button();
            LabelBorder = new Label();
            LabelRecord = new Label();
            LabelPoints = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // LabelCell
            // 
            LabelCell.BackColor = SystemColors.WindowText;
            LabelCell.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCell.Location = new Point(200, 200);
            LabelCell.Name = "LabelCell";
            LabelCell.Size = new Size(100, 100);
            LabelCell.TabIndex = 0;
            LabelCell.Text = "2048";
            LabelCell.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtinExit
            // 
            ButtinExit.BackColor = SystemColors.WindowText;
            ButtinExit.ForeColor = SystemColors.Window;
            ButtinExit.Location = new Point(1041, 750);
            ButtinExit.Name = "ButtinExit";
            ButtinExit.Size = new Size(225, 75);
            ButtinExit.TabIndex = 8;
            ButtinExit.Text = "Выход";
            ButtinExit.UseVisualStyleBackColor = false;
            ButtinExit.Click += ButtinExit_Click;
            // 
            // ButtionRestart
            // 
            ButtionRestart.BackColor = SystemColors.WindowText;
            ButtionRestart.ForeColor = SystemColors.Window;
            ButtionRestart.Location = new Point(1041, 250);
            ButtionRestart.Name = "ButtionRestart";
            ButtionRestart.Size = new Size(225, 75);
            ButtionRestart.TabIndex = 9;
            ButtionRestart.Text = "Переиграть";
            ButtionRestart.UseVisualStyleBackColor = false;
            ButtionRestart.Click += ButtionRestart_Click;
            // 
            // ButtonRulesGame
            // 
            ButtonRulesGame.BackColor = SystemColors.WindowText;
            ButtonRulesGame.ForeColor = SystemColors.Window;
            ButtonRulesGame.Location = new Point(1041, 500);
            ButtonRulesGame.Name = "ButtonRulesGame";
            ButtonRulesGame.Size = new Size(225, 75);
            ButtonRulesGame.TabIndex = 10;
            ButtonRulesGame.Text = "Правила игры";
            ButtonRulesGame.UseVisualStyleBackColor = false;
            // 
            // LabelBorder
            // 
            LabelBorder.BackColor = SystemColors.WindowText;
            LabelBorder.ForeColor = SystemColors.WindowText;
            LabelBorder.Location = new Point(1000, 10);
            LabelBorder.Name = "LabelBorder";
            LabelBorder.Size = new Size(10, 925);
            LabelBorder.TabIndex = 11;
            // 
            // LabelRecord
            // 
            LabelRecord.AutoSize = true;
            LabelRecord.ForeColor = SystemColors.WindowText;
            LabelRecord.Location = new Point(600, 40);
            LabelRecord.Name = "LabelRecord";
            LabelRecord.Size = new Size(222, 40);
            LabelRecord.TabIndex = 12;
            LabelRecord.Text = "Рекорд: 999999";
            // 
            // LabelPoints
            // 
            LabelPoints.AutoSize = true;
            LabelPoints.ForeColor = SystemColors.WindowText;
            LabelPoints.Location = new Point(200, 40);
            LabelPoints.Name = "LabelPoints";
            LabelPoints.Size = new Size(196, 40);
            LabelPoints.TabIndex = 13;
            LabelPoints.Text = "Очки: 999999";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.WindowText;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(800, 800);
            label1.Name = "label1";
            label1.Size = new Size(100, 100);
            label1.TabIndex = 14;
            label1.Text = "2048";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.WindowText;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(600, 200);
            label2.Name = "label2";
            label2.Size = new Size(100, 100);
            label2.TabIndex = 15;
            label2.Text = "2048";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 800);
            label3.Name = "label3";
            label3.Size = new Size(100, 100);
            label3.TabIndex = 16;
            label3.Text = "2048";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.WindowText;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(400, 200);
            label4.Name = "label4";
            label4.Size = new Size(100, 100);
            label4.TabIndex = 17;
            label4.Text = "2048";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.WindowText;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(800, 200);
            label5.Name = "label5";
            label5.Size = new Size(100, 100);
            label5.TabIndex = 18;
            label5.Text = "2048";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1278, 944);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelPoints);
            Controls.Add(LabelRecord);
            Controls.Add(LabelBorder);
            Controls.Add(ButtonRulesGame);
            Controls.Add(ButtionRestart);
            Controls.Add(ButtinExit);
            Controls.Add(LabelCell);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.Window;
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCell;
        private Button ButtinExit;
        private Button ButtionRestart;
        private Button ButtonRulesGame;
        private Label LabelBorder;
        private Label LabelRecord;
        private Label LabelPoints;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

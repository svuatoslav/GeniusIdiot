using System.Collections.Generic;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] _labelCells;
        private List<Label> _labels;
        private bool GameStatus = true;

        public MainForm()
        {
            InitializeComponent();
            SettingGame();
        }

        private void SettingGame(int rows = 4, int columns = 4)
        {
            //_labelCells = new Label[rows, columns];
            _labels = new List<Label>(Math.Max(rows, columns));

            FieldGeneration(LabelCell, tableLayoutPanelField, rows, columns);
            //FieldGeneration(LabelCell, rows, columns);

            this.Controls.Remove(LabelCell);

            NumberGeneration(tableLayoutPanelField.Controls.OfType<Label>().Where(label => label.Text == "0").ToList());

            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (GameStatus)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                    case Keys.W:
                        ChangeColomns(0, tableLayoutPanelField.RowCount - 1, 1);
                        CheckGame();
                        break;
                    case Keys.Down:
                    case Keys.S:
                        ChangeColomns(tableLayoutPanelField.RowCount - 1, 0, -1);
                        CheckGame();
                        break;
                    case Keys.Left:
                    case Keys.A:
                        ChangeRows(0, tableLayoutPanelField.RowCount - 1, 1);
                        CheckGame();
                        break;
                    case Keys.Right:
                    case Keys.D:
                        ChangeRows(tableLayoutPanelField.RowCount - 1, 0, -1);
                        CheckGame();
                        break;
                }
                e.Handled = true;
            }
            else
                MessageBox.Show("Игра окончена");
        }

        private void ChangeRows(int startColumn, int endColumn, int step)
        {
            for (int row = 0; row < tableLayoutPanelField.ColumnCount; row++)
            {
                _labels.Clear();
                for (int col = startColumn; step > 0 ? col <= endColumn : col >= endColumn; col += step)
                    _labels.Add((Label)tableLayoutPanelField.GetControlFromPosition(col, row));
                MoveValues(_labels);
            }
        }

        private void ChangeColomns(int startRows, int endRows, int step)
        {
            for (int col = 0; col < tableLayoutPanelField.ColumnCount; col++)
            {
                _labels.Clear();
                for (int row = startRows; step > 0 ? row <= endRows : row >= endRows; row += step)
                    _labels.Add((Label)tableLayoutPanelField.GetControlFromPosition(col, row));
                MoveValues(_labels);
            }
        }

        private void FieldGeneration(Label exemplar, int rows, int columns,
            int startX = 200,
            int startY = 200,
            int spacing = 100)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var label = CloneLabel(exemplar);
                    label.Name = $"LabelCell_{row}_{col}";
                    label.Location = CalculatePosition(row, col, startX, startY, spacing, exemplar.Width, exemplar.Height);
                    Controls.Add(label);

                    _labelCells[row, col] = label;
                }
            }
        }

        private void FieldGeneration(Label exemplar, TableLayoutPanel tableLayoutPanel, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var label = CloneLabel(exemplar);
                    label.Name = $"LabelCell_{row}_{col}";

                    tableLayoutPanel.Controls.Add(CloneLabel(LabelCell), col, row);
                }
            }
        }

        private Label CloneLabel(Label exemplar)
        {
            return new Label
            {
                BackColor = exemplar.BackColor,
                Font = (Font)exemplar.Font.Clone(),
                Size = exemplar.Size,
                Text = exemplar.Text,
                TextAlign = exemplar.TextAlign,
                MinimumSize = exemplar.MinimumSize,
                AutoSize = exemplar.AutoSize
            };
        }

        private Point CalculatePosition(
            int row,
            int col,
            int startX,
            int startY,
            int spacing,
            int cellWidth,
            int cellHeight)
        {
            return new Point(
                    x: startX + col * (cellWidth + spacing),
                    y: startY + row * (cellHeight + spacing));
        }

        private void MoveValues(List<Label> labels) // <-
        {
            var filledCells = labels.Where(label => label.Text != "0").ToList();

            if (filledCells.Count > 1)
            {
                for (int i = 0; i < filledCells.Count - 1; i++)
                {
                    if (string.Equals(filledCells[i].Text, filledCells[i + 1].Text, StringComparison.Ordinal))
                    {
                        filledCells[i].Text = (int.Parse(filledCells[i].Text) * 2).ToString();
                        filledCells.RemoveAt(i + 1);
                        ChangingGamePoints(int.Parse(filledCells[i].Text));
                    }
                }
            }

            for (int i = 0; i < labels.Count; i++)
                if (i < filledCells.Count)
                    labels[i].Text = filledCells[i].Text;
                else
                    labels[i].Text = "0";
        }

        private void NumberGeneration(List<Label> labels)
        {
            var rand = new Random();
            var index = rand.Next(0, labels.Count);

            if (rand.NextDouble() < 0.75)
                labels[index].Text = "2";
            else
                labels[index].Text = "4";
        }

        private void SaveResult()
        {

        }

        private void CheckGame()
        {
            var emptyCells = tableLayoutPanelField.Controls.OfType<Label>().Where(label => label.Text == "0").ToList();

            if (emptyCells.Count == 0)
            {
                GameStatus = false;
                SaveResult();
                MessageBox.Show("Игра окончена");
            }
            else
                NumberGeneration(emptyCells);
        }

        private void ChangingGamePoints(int count)
        {
            if (int.TryParse(labelScore.Text, out int score))
            {
                labelScore.Text = (score + count).ToString();
                if (int.TryParse(labelRecord.Text, out int record))
                    if (record < int.Parse(labelScore.Text))
                        labelRecord.Text = labelScore.Text; // из-за ссылки при перезапуске
            }
        }

        private void ButtionRestart_Click(object sender, EventArgs e)
        {
            GameStatus = true;
            labelScore.Text = "0";

            foreach (Label cell in tableLayoutPanelField.Controls )
                cell.Text = "0";

            NumberGeneration(tableLayoutPanelField.Controls.OfType<Label>().Where(label => label.Text == "0").ToList());
        }

        private void ButtonExit_Click(object sender, EventArgs e) => Application.Exit();

        private void ButtonRulesGame_Click(object sender, EventArgs e)
        {
            RulesGameForm RGF = new();
            RGF.ShowDialog();
        }
    }
}

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private Label[,] _labelCells;
        private List<Label> _labels;
        private bool _gameStatus = true;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame(int rows = 4, int columns = 4)
        {
            //_labelCells = new Label[rows, columns];
            _labels = new List<Label>(Math.Max(rows, columns));

            GenerateGameField(LabelCell, tableLayoutPanelField, rows, columns);
            //FieldGeneration(LabelCell, rows, columns);

            this.Controls.Remove(LabelCell);

            NumberGeneration(tableLayoutPanelField.Controls.OfType<Label>().Where(label => label.Text == "0").ToList());

            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            LoadBestScore();
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (_gameStatus)
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

        private void GenerateGameField(Label template, TableLayoutPanel panel, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var label = CloneLabel(template);
                    label.Name = $"LabelCell_{row}_{col}";

                    panel.Controls.Add(CloneLabel(LabelCell), col, row);
                }
            }
        }

        private Label CloneLabel(Label original)
        {
            return new Label
            {
                BackColor = original.BackColor,
                Font = (Font)original.Font.Clone(),
                Size = original.Size,
                Text = original.Text,
                TextAlign = original.TextAlign,
                MinimumSize = original.MinimumSize,
                AutoSize = original.AutoSize
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

        private void SaveBestScore(int score) => JSONManager.WriteJSON(StoragePath.ProjectPath, score); 
        
        private void LoadBestScore() => labelRecord.Text = JSONManager.ReadJSON<int>(StoragePath.ProjectPath)?.ToString() ?? "0";

        private void CheckGame()
        {
            var emptyCells = tableLayoutPanelField.Controls.OfType<Label>().Where(label => label.Text == "0").ToList();

            if (emptyCells.Count == 0)
            {
                _gameStatus = false;
                SaveBestScore(int.Parse(labelRecord.Text));
                MessageBox.Show("Игра окончена");
            }
            else
                NumberGeneration(emptyCells);
        }

        private bool CheckMerger()
        {
            return true;
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
        private void RestartGame()
        {
            _gameStatus = true;
            labelScore.Text = "0";

            foreach (Label tile in tableLayoutPanelField.Controls)
                tile.Text = "0";

            NumberGeneration(tableLayoutPanelField.Controls.OfType<Label>().Where(label => label.Text == "0").ToList());
        }

        private void ButtionRestart_Click(object sender, EventArgs e) => RestartGame();

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            SaveBestScore(int.Parse(labelRecord.Text));
            Application.Exit();
        }

        private void ButtonRulesGame_Click(object sender, EventArgs e)
        {
            var rulesForm = new RulesGameForm();
            rulesForm.ShowDialog();
        }
    }
}

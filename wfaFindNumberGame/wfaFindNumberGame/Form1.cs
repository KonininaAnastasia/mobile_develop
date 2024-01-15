using System.Drawing;
using System;

namespace wfaFindNumberGame
{
    public partial class Form1 : Form
    {
        private List<int> numberRund;
        private int Level;
        private int Attempt; //попытка
        private int remainingTime; //оставшееся время
        private bool isGameStarted;
        Color color;
        int SaveNumber;
        Label lbSaveNumber;
        Label lbTimer;
        private bool isMessageBoxShown = false;
        List<Point> SaveIndexes = new();

        Label labelWork;
        TableLayoutPanel tlp;
        System.Windows.Forms.Timer timerStart;

        private int Rows = 3;
        private int Col = 3;

        Random rnd = new();

        public Form1()
        {
            InitializeComponent();

            remainingTime = 10;
            isGameStarted = false;

            numberRund = new List<int>();
            tlp = new TableLayoutPanel();
            tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; //видимые границы ячеек
            tlp.Location = new Point(this.Width / 2 - tlp.Width, this.Height / 2 - tlp.Height);

            Button bu_Start1 = new();
            Button bu_Start2 = new();
            Button bu_Start3 = new();

            bu_Start1.Text = "Легкий";
            bu_Start1.Tag = 1;
            bu_Start1.Width = 150;
            bu_Start1.Height = 30;
            
            bu_Start2.Text = "Средний";
            bu_Start2.Tag = 2;
            bu_Start2.Location = new Point(bu_Start1.Width + 10, 0);
            bu_Start2.Width = 150;
            bu_Start2.Height = 30;

            bu_Start3.Text = "Сложный";
            bu_Start3.Tag = 3;
            bu_Start3.Location = new Point(bu_Start1.Width + bu_Start2.Width + 20, 0);
            bu_Start3.Width = 150;
            bu_Start3.Height = 30;

            this.Controls.Add(bu_Start1);
            this.Controls.Add(bu_Start2);
            this.Controls.Add(bu_Start3);

            bu_Start1.Click += BuStart_Click;
            bu_Start2.Click += BuStart_Click;
            bu_Start3.Click += BuStart_Click;
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;

            if (clickedLabel.Text == lbSaveNumber.Tag.ToString())
            {
                MessageBox.Show("правильно!");
                //
            }
            else if(Attempt < 2 && clickedLabel.Text != lbSaveNumber.Text)
            {
                Attempt++;
                clickedLabel.BackColor = Color.FromArgb(0, clickedLabel.BackColor);
            }
            else
            {
                MessageBox.Show("Вы проиграли!");
                Final();
            }
        }

        private void BuStart_Click(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Level = (int)clickedButton.Tag;

            isGameStarted = true;
            Attempt = 0;

            if (Level == 1)
            {
                remainingTime = 10;
            }
            else if (Level == 2)
            {
                remainingTime = 5;
                Rows = 4;
                Col = 4;
            }
            else if (Level == 3)
            {
                remainingTime = 3;
                Rows = 4;
                Col = 4;
            }

            // Генерируем случайные числа
            GenerateNumberRund(Level);

            // Показываем числа пользователю
            ShowNumbers();

            // Счет времени
            Timer(clickedButton);
        }

        private void Timer(Button clickedButton)
        {
            timerStart = new System.Windows.Forms.Timer();
            timerStart.Interval = 1000;


            TimeSpan remainTime = TimeSpan.FromSeconds(remainingTime);
            string formattedTime = string.Format("{0:00}:{1:00}", remainTime.Minutes, remainTime.Seconds);

            lbTimer = new Label();
            //lbTimer.Text = $"{remainingTime.ToString()}";
            lbTimer.Text = formattedTime;
            lbTimer.Location = new Point(0, clickedButton.Height);

            this.Controls.Add(lbTimer);
            timerStart.Tick += TimerStart_Tick; ;
            timerStart.Start();
        }

        private void TimerStart_Tick(object? sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime >= 0)
            {
                TimeSpan remainTime = TimeSpan.FromSeconds(remainingTime);
                string formattedTime = string.Format("{0:00}:{1:00}", remainTime.Minutes, remainTime.Seconds);

                lbTimer.Text = formattedTime;
            }
            else
            {
                Final();
            }
        }

        private void Final()
        {
            if (remainingTime <= 0 && !isMessageBoxShown)
            {
                isGameStarted = false;
                isMessageBoxShown = true;

                MessageBox.Show("Время вышло!");

                timerStart.Stop();

                //

            }
        }

        private void ShowNumbers()
        {
            tlp.RowCount = Rows;
            tlp.ColumnCount = Col;
            tlp.ColumnStyles.Clear();
            tlp.RowStyles.Clear();

            for (int row = 0; row < Rows; row++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Rows)); //пропорциональные ячейки по строке

                for (int col = 0; col < Col; col++)
                {
                    labelWork = new Label();
                    labelWork.TextAlign = ContentAlignment.MiddleCenter;
                    labelWork.Dock = DockStyle.Fill;

                    color = new Color();
                    color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

                    // Получаем следующее число из списка
                    int numb = numberRund[0];

                    if (SaveIndexes.Contains(new Point(row, col)) && numb != (int)lbSaveNumber.Tag)
                    {
                        labelWork.Text = "";
                    }
                    else if (numberRund.Count > 0)
                    {
                        numberRund.RemoveAt(0);

                        labelWork.Text = numb.ToString();
                        labelWork.BackColor = color;
                    }

                    labelWork.Click += Label_Click;

                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / Col));
                    tlp.Controls.Add(labelWork, col, row);
                }
            }

            lbSaveNumber.Location = new Point(this.Width/2 - lbSaveNumber.Width, 100);

            this.Controls.Add(lbSaveNumber);
            this.Controls.Add(tlp);
        }

        private void GenerateNumberRund(int level)
        {
            numberRund.Clear();
            SaveNumber = rnd.Next(0, Rows * Col);
            lbSaveNumber = new Label();
            lbSaveNumber.Width = 200;
            lbSaveNumber.Text = "";
            int n;

            for (int i = 0; i < Rows*Col; i++)
            {
                if (level == 1 || level == 2)
                {
                    n = rnd.Next(100, 1000);
                }
                else
                {
                    n = rnd.Next(1000, 10000);
                }

                if (SaveNumber == i)
                {
                    lbSaveNumber.Text = $"Найдите число : {n.ToString()}";
                    lbSaveNumber.Tag = n;
                }

                numberRund.Add(n);
            }

            int countEmpty = rnd.Next(0, 6);

            for (int i = 0; i < countEmpty; i++)
            {
                int rowIndex = rnd.Next(Rows);
                int colIndex = rnd.Next(Col);

                SaveIndexes.Add(new Point(rowIndex, colIndex));

            }

        }
    }
}

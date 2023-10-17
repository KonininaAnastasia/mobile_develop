namespace wfaControlPuzzle
{
    public partial class Form1 : Form
    {
        private const int STEP = 25;
        private Random rnd = new();
        private PictureBox[,] px;
        private int cellWidth;
        private int cellHeight;
        private Point startMouseDown;

        public int Rows { get; private set; } = 3;
        public int Cols { get; private set; } = 5;

        public Form1()
        {
            InitializeComponent();

            CreateCells();
            ResizeCells();
            StartLocationCells();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1:
                    StartLocationCells();
                    break;

                case Keys.F2:
                    ResizeCells(); 
                    break;

                case Keys.F3:
                    RandomLocationCells();
                    break;

                case Keys.F4:
                    Random2LocationCells();
                    break;
            }
        }

        private void Random2LocationCells()
        {
            StartLocationCells();
            for (int i = 0; i < 10; i++)
            {
                var r1 = rnd.Next(Rows);
                var c1 = rnd.Next(Cols);
                var r2 = rnd.Next(Rows);
                var c2 = rnd.Next(Cols);

                (px[r1, c1].Location, px[r2, c2].Location) = (px[r2, c2].Location, px[r1, c1].Location);
            }
        }

        private void RandomLocationCells()
        {
            for (int r = 0; r < Rows; r++)       // Y
                for (int c = 0; c < Cols; c++)   // X
                {
                    px[r, c].Location = new Point(
                        rnd.Next(this.ClientSize.Width - px[r, c].Width),
                        rnd.Next(this.ClientSize.Height - px[r, c].Height));

                }
        }

        private void StartLocationCells()
        {
            for (int r = 0; r < Rows; r++)       // Y
                for (int c = 0; c < Cols; c++)   // X
                {
                    px[r, c].Location = new Point(c * cellWidth, r * cellHeight);

                }
        }

        private void ResizeCells()
        {

            cellWidth = this.ClientSize.Width / Cols;
            cellHeight = this.ClientSize.Height / Rows;

            for (int r = 0; r < Rows; r++)       // Y
                for (int c = 0; c < Cols; c++)   // X
                {
                    px[r, c].Width = cellWidth;
                    px[r, c].Height = cellHeight;
                    px[r, c].Image = new Bitmap(cellWidth, cellHeight);
                    var g = Graphics.FromImage(px[r, c].Image);
                    g.DrawImage(
                        Properties.Resources.city_tower,
                        new Rectangle(0, 0, cellWidth, cellHeight),
                        new Rectangle(c * cellWidth, r * cellHeight, cellWidth, cellHeight),
                        GraphicsUnit.Pixel
                        );
                    g.DrawString($"[{r},{c}]",
                        new Font("", 20),
                        new SolidBrush(Color.Black),
                        new Rectangle(0, 0, cellWidth, cellHeight),
                        new StringFormat() {Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center});
                    g.Dispose();
                }
        }

        private void CreateCells()
        {
            px = new PictureBox[Rows, Cols];

            for (int r = 0; r < Rows; r++)       // Y
                for (int c = 0; c < Cols; c++)   // X
                {
                    px[r, c] = new PictureBox();
                    px[r, c].Tag = (r, c);
                    px[r, c].BorderStyle = BorderStyle.FixedSingle;
                    px[r, c].MouseDown += PictureBoxAll_MouseDown;
                    px[r, c].MouseMove += PictureBoxAll_MouseMove;
                    px[r, c].MouseUp += PictureBoxAll_MouseUp;
                    this.Controls.Add(px[r, c]);
                }
            //(int, int)v.tag
        }

        private void PictureBoxAll_MouseUp(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox v)
            {
                v.Cursor = Cursors.Default;
                if (e.Button == MouseButtons.Left)
                {
                    var p = v.Location;
                    // магия (проверка)

                    for (int r = 0; r < Rows; r++)       // Y
                        for (int c = 0; c < Cols; c++)   // X
                        {
                            //px[r, c].Location = new Point(c * cellWidth, r * cellHeight);
                            if (p.X > c * cellWidth - STEP && p.X < c * cellWidth + STEP)
                                p.X = c * cellWidth;

                            if (p.Y > r * cellHeight - STEP && p.Y < r * cellHeight + STEP)
                                p.Y = r * cellHeight;
                        }

                    v.Location = p;
                }
            }
        }

        private void PictureBoxAll_MouseMove(object? sender, MouseEventArgs e)
        {
            if (sender is Control v)
            {
                if (e.Button == MouseButtons.Left)
                {
                    v.Location = new Point(
                        v.Location.X + e.X - startMouseDown.X,
                        v.Location.Y + e.Y - startMouseDown.Y
                        );
                }
            }
        }

        private void PictureBoxAll_MouseDown(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox v)
            {
                startMouseDown = e.Location;
                v.BringToFront(); // на верхний уровень перемещается элемент, который берем
                v.Cursor = Cursors.Hand;

                if (e.Button == MouseButtons.Right)
                {
                    v.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    v.Invalidate();
                }
            }
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace wfaDrawPlayBoard
{
    public partial class Form1 : Form
    {
        private Panel containerPanel;
        PictureBox pictureBox;

        private int Width;
        private int Height;

        private bool f = false;
        int color = 0;


        public Form1()
        {
            InitializeComponent();


            DrawAll();
            this.ResizeEnd += (s, e) => DrawAll();
            radio_1.CheckedChanged += Radio_CheckedChanged;
            radio_2.CheckedChanged += Radio_CheckedChanged;
            bu_parametrs.Click += Bu_parametrs_Click;

        }

        private void Radio_CheckedChanged(object? sender, EventArgs e)
        {
            pictureBox?.Dispose();

            pictureBox = new PictureBox();

            if (radio_1.Checked)
            {
                color = 0;
                pictureBox.Image = Properties.Resources._1;
            }
            if (radio_2.Checked)
            {
                color = 1;
                pictureBox.Image = Properties.Resources._2;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            DrawAll();
            //panel1.Controls.Add(pictureBox);
            //panel1.Controls.SetChildIndex(pictureBox, 0);
        }

        private void DrawAll()
        {
            if (f)
            {
                Color col1;
                Color col2;
                if (color == 0)
                {
                    col1 = Color.Black;
                    col2 = Color.White;
                }
                else
                {
                    col1 = Color.Blue;
                    col2 = Color.FromArgb(230, 218, 166);
                }
                MyChessboard Chessboard = new(panel1.Width, panel1.Height, col1, col2);

                Chessboard.DrawÑells();
                panel1.BackgroundImage = (Bitmap)Chessboard.GetBitmap().Clone();
            }
            else
            {
                MessageBox.Show("Âגוהטעו ןאנאלוענû");
            }
        }

        private void Bu_parametrs_Click(object? sender, EventArgs e)
        {
            Width = int.Parse(tb_width.Text);
            Height = int.Parse(tb_hieght.Text);

            f = true;
        }

    }
}

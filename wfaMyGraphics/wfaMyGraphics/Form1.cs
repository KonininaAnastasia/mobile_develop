using System.Drawing;
using System.Windows.Forms;

namespace wfaMyGraphics
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.Transparent;
            this.Controls.Add(pictureBox);

            this.Click += Form1_Click;
        }

        private void Form1_Click(object? sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(800, 600);
            MyGraphics g = MyGraphics.FromImage(myBitmap);
            g.Romb(100, 100, 200, 200, Color.Red);

            pictureBox.Image = g;
        }
    }
}

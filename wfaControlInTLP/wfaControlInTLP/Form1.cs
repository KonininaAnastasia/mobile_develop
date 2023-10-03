using System.Windows.Forms;

namespace wfaControlInTLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // (1)
            //pictureBox1.Tag = 1;
            //pictureBox2.Tag = 2;
            //pictureBox3.Tag = 3;
            //pictureBox4.Tag = 4;
            //pictureBox5.Tag = 5;
            //pictureBox6.Tag = 6;
            //pictureBox7.Tag = 7;
            //pictureBox8.Tag = 8;
            //pictureBox9.Tag = 9;

            //pictureBox1.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox2.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox3.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox4.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox5.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox6.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox7.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox8.MouseEnter += PictureBoxall_MouseEnter;
            //pictureBox9.MouseEnter += PictureBoxall_MouseEnter;

            //pictureBox1.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox2.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox3.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox4.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox5.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox6.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox7.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox8.MouseLeave += PictureBoxAll_MouseLeave;
            //pictureBox9.MouseLeave += PictureBoxAll_MouseLeave;

            // (2)
            //List<PictureBox> list = new();
            //list.Add(pictureBox1);
            //list.Add(pictureBox2);
            //list.Add(pictureBox3);
            //list.Add(pictureBox4);
            //list.Add(pictureBox5);
            //list.Add(pictureBox6);
            //list.Add(pictureBox7);
            //list.Add(pictureBox8);
            //list.Add(pictureBox9);

            // (3)
            List<PictureBox> list = new()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9
            };

            int n = 1;
            foreach (var item in list)
            {
                item.Tag = n++;
                item.MouseEnter += PictureBoxall_MouseEnter;
                item.MouseLeave += PictureBoxAll_MouseLeave;
                item.MouseClick += PictureBoxAll_MouseClick;
                item.Image = imageList1.Images[0];
                item.SizeMode = PictureBoxSizeMode.Zoom;
            }

            this.Text += " : LClick/RClick - Select item";

        }

        private void PictureBoxAll_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox px)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        px.BorderStyle = px.BorderStyle == BorderStyle.None ? BorderStyle.FixedSingle : BorderStyle.None;
                        break;
                    case MouseButtons.Right:
                        px.BackColor = px.BackColor == SystemColors.Control ? Color.LightBlue : SystemColors.Control;
                        break;
                }
            }
        }

        private void PictureBoxAll_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is PictureBox px)
                px.Image = imageList1.Images[0];
        }

        private void PictureBoxall_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is PictureBox px)
                px.Image = imageList1.Images[Convert.ToInt32(px.Tag)];
        }
    }
}
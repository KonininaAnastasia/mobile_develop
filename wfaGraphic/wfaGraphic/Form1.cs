namespace wfaGraphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text += " : (Sin - красный, Cos - синий, Tan - зеленый)";
            DrawAll();
            this.Resize += (s, e) => DrawAll();
        }

        private void DrawAll()
        {
            this.BackgroundImageLayout = ImageLayout.None;

            MyGraphic myGraphic = new(
                this.ClientSize.Width,
                this.ClientSize.Height);

            myGraphic.DrawAxes();
            myGraphic.DrawSin();
            myGraphic.DrawCos();
            myGraphic.DrawTan();

            this.BackgroundImage = (Bitmap)myGraphic.GetBitmap()?.Clone();
        }
    }
}
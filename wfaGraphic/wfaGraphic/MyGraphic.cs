namespace wfaGraphic
{
    internal class MyGraphic
    {
        public int Width { get; }
        public int Height { get; }
        public int CountWave { get; private set; } = 5;
        public int DOTDiameter { get; } = 4;

        private Bitmap b;
        private Graphics g;
        private int grShiftY;
        private double grHeight;
        private double grWidthPI;

        public MyGraphic(int width, int height)
        {
            Width = width;
            Height = height;

            b = new Bitmap(Width, Height);
            g = Graphics.FromImage(b);

            grShiftY = b.Height / 2;
            grHeight = grShiftY * 0.9;
            grWidthPI = Math.PI / (b.Width - 1);
        }

        internal void DrawAxes()
        {

            // рисуем ось X
            g.DrawLine(new Pen(Color.Black), 0, grShiftY, b.Width, grShiftY);

            for (int i = 0; i < CountWave; i++)
            {
                var _x = b.Width / CountWave * i;
                g.DrawLine(Pens.DarkGray, _x, 0, _x, b.Height);
            }

            // рисуем ось Y
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, b.Height);

        }

        internal Bitmap? GetBitmap()
        {
            return b;
        }

        internal void DrawSin()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grHeight * -Math.Sin(i * CountWave * grWidthPI) + grShiftY;
                g.FillEllipse(new SolidBrush(Color.Red),
                    (int)_x - DOTDiameter/2, (int)_y - DOTDiameter/2, DOTDiameter, DOTDiameter);
            }
        }

        internal void DrawCos()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grHeight * -Math.Cos(i * CountWave * grWidthPI) + grShiftY;
                g.FillEllipse(new SolidBrush(Color.Blue),
                    (int)_x - DOTDiameter / 2, (int)_y - DOTDiameter / 2, DOTDiameter, DOTDiameter);
            }
        }

        internal void DrawTan()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grHeight * -Math.Tan(i * CountWave * grWidthPI) + grShiftY;
                if (_y > 0 && _y < b.Height)
                    g.FillEllipse(new SolidBrush(Color.Green),
                        (int)_x - DOTDiameter / 2, (int)_y - DOTDiameter / 2, DOTDiameter, DOTDiameter);
            }
        }
    }
}
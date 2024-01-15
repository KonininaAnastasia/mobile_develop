
namespace wfaDrawPlayBoard
{
    internal class MyChessboard
    {
        private int width;
        private int height;
        private Bitmap b;
        private Graphics g;
        int widthRec = 50;
        int heightRec = 50;
        int sizeRec;
        private Color darkColor;
        private Color lightColor;

        public MyChessboard(int width, int height, Color darkColor, Color lightColor)
        {
            this.width = width;
            this.height = height;
            this.darkColor = darkColor;
            this.lightColor = lightColor;
            b = new Bitmap(width, height);
            g = Graphics.FromImage(b);
            widthRec = width / 10;
            heightRec = height / 10;
            if (width / 10 < height / 10) { sizeRec = width / 10; } else { sizeRec = height / 10; }
        }

        private void DrawRectangle(bool color, int x, int y, int width, int height)
        {
            Brush brush;
            if (color)
            {
                brush = new SolidBrush(darkColor);
            }
            else
            {
                brush = new SolidBrush(lightColor);
            }
            g.FillRectangle(brush, x, y, width, height);
        }

        internal void DrawСells()
        {
            int fontSize = sizeRec / 4 * 2;
            Font font = new Font("Arial", fontSize);
            SolidBrush pen = new SolidBrush(Color.Black);
            int x = (width - (sizeRec * 8)) / 2;
            int y = (height - (sizeRec * 8)) / 2;
            bool color = true;
            int number = 8;
            string leters = "ABCDEFGH";
            int numLeter = 0;
            for (int i = x; i < x + sizeRec * 8; i += sizeRec)
            {
                color = !color;
                for (int j = y; j < y + sizeRec * 8; j += sizeRec)
                {
                    DrawRectangle(color, i, j, sizeRec, sizeRec);
                    if (i == x)
                    {
                        g.DrawString($"{number}", font, pen, new PointF(i - sizeRec, j + sizeRec / 8));
                        number--;
                    }
                    if (j == y + sizeRec * 7)
                    {
                        g.DrawString($"{leters[numLeter]}", font, pen, new PointF(i + sizeRec / 8, j + sizeRec));
                        numLeter++;


                    }
                    color = !color;
                }

            }
        }

        internal Bitmap? GetBitmap()
        {
            return b;
        }
    }
}
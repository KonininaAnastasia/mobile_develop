namespace wfaMyGraphics
{
    internal class MyGraphics
    {
        private Graphics graphics;

        private MyGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public static MyGraphics FromImage(Image image)
        {
            Graphics graphics = Graphics.FromImage(image);
            return new MyGraphics(graphics);
        }

        public void Romb(int x, int y, int width, int height, Color color)
        {
            Pen pen = new Pen(color);
            Point[] points =
            {
            new Point(x + width / 2, y),
            new Point(x + width, y + height / 2),
            new Point(x + width / 2, y + height),
            new Point(x, y + height / 2)
        };
            graphics.DrawPolygon(pen, points);
        }
    }
}
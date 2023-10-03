namespace labOOPRectangle
{
    internal class MyRectangle
    {
        private int length;
        private int wigth;

        public MyRectangle()
        {
            this.length = 1;
            this.wigth = 1;
        }

        public MyRectangle(int length, int wigth)
        {
            this.length = length;
            this.wigth = wigth;
        }

        internal int GetArea()
        {
            return length * wigth;
        }
    }
}
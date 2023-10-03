using System.Drawing;

namespace labOOPRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle x = new();
            Console.WriteLine(x.GetArea());

            MyRectangle y = new(10, 20);
            Console.WriteLine(y.GetArea());
        }
    }
}
namespace cnsEnum
{
    internal class Program
    {
        public enum SingleColar {Red, Green = 100500, Blue}

        public enum MultiColor: byte
        {
            Red = 1,    //0b_00000_0001
            Green = 2,  //0b_00000_0010
            Blue = 4,   //0b_00000_0100
            All = Red | Green | Blue,
            RG = Red | Green
        }

        public enum MultiColor2 : byte
        {
            Red = 1,    //0b_00000_0001
            Green = 1 << 1,  //0b_00000_0010
            Blue = 1 << 2,   //0b_00000_0100
            Black = 1 << 3,
        }

        static void Main(string[] args)
        {
            SingleColar singleColar;
            singleColar = SingleColar.Red;
            Console.WriteLine(singleColar);
            Console.WriteLine(singleColar.ToString("D"));

            MultiColor multiColor = MultiColor.Red;
            multiColor |= MultiColor.Green;
            multiColor |= MultiColor.Blue; // добавить
            Console.WriteLine(multiColor);
            multiColor ^= MultiColor.Blue; // удалить
            Console.WriteLine(multiColor);
            Console.WriteLine($"Is only Red = {multiColor == MultiColor.Red}");
            Console.WriteLine($"Has Red = {multiColor.HasFlag(MultiColor.Red)}");
        }
    }
}
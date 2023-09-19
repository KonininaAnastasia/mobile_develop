
bool isContinue;

do
{
    Console.WriteLine("Длина?");
    int.TryParse(Console.ReadLine(), out int width);

    //(1)
    //for (int i = 0; i < width; i++)
    //{
    //    Console.Write('*');
    //}

    //(2)
    Console.WriteLine(new String('*',width));

    Console.WriteLine("Продолжить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";
} while (isContinue);

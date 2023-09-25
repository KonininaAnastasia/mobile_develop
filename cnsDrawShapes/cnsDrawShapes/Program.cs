
bool isContinue;

do
{
    //не получилось сделать нормальный ромб
    Console.WriteLine("Меньшая диаганаль полуромба?");
    int.TryParse(Console.ReadLine(), out int length);

    Console.WriteLine("Символ?");
    string? simbol = Console.ReadLine();

    char s = Convert.ToChar(simbol);

    Console.WriteLine("");

    for (int i = 1; i < length; i++)
    {
        Console.WriteLine(new String(s, i));
    }

    for (int j = length; j > 0; j--)
    {
        Console.WriteLine(new String(s, j));
    }

    Console.WriteLine("");

    //змейка
    Console.WriteLine("Длина змейки?");
    int.TryParse(Console.ReadLine(), out int length1);

    Console.WriteLine("Ширина змейки?");
    int.TryParse(Console.ReadLine(), out int width1);

    Console.WriteLine("Символ?");
    string? simbol1 = Console.ReadLine();

    Console.WriteLine("");

    char s1 = Convert.ToChar(simbol1);

    string space1 = "";

    if (length1 > 0 && width1 > 1)
    {

        for (int j = 0; j < length1 - 1; j++)
        {
            space1 += " ";
        }

        Console.WriteLine(new String(s1, length1));
        for (int i = 0; i < width1 - 2; i++)
        {
            if (length1 > 1)
            {
                Console.WriteLine(space1 + s1);
            }
            else
            {
                Console.WriteLine(s1);
            }
        }
        Console.WriteLine(new String(s1, length1));
        for (int i = 0; i < width1 - 2; i++)
        {
            if (length1 > 1)
            {
                Console.WriteLine(s1 + space1); 
            }
            else
            {
                Console.WriteLine(s1);
            }
        }
        Console.WriteLine(new String(s1, length1));

    }
    else
    {
        Console.WriteLine("Введите длину > 0 и ширину > 1");
    }

    Console.WriteLine("");

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);

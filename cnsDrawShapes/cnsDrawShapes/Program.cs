
bool isContinue;

do
{
    //песочные часы
    Console.WriteLine("Ширина песочных часов?");
    int.TryParse(Console.ReadLine(), out int wigth);

    Console.WriteLine("Символ?");
    string? simbol = Console.ReadLine();

    char s = Convert.ToChar(simbol);


    for (int i = 0; i < wigth / 2; i++)
    {
        Console.Write(new String(' ', i));
        Console.WriteLine(new String(s, wigth - i * 2));
    };

    for (int i = wigth / 2; i >= 0; i--)
    {
        Console.Write(new String(' ', i));
        Console.WriteLine(new String(s, wigth - i * 2));
    };

    Console.WriteLine("");



    //ромб
    Console.WriteLine("Длина меньшей диагонали ромба?");
    int.TryParse(Console.ReadLine(), out int wigth1);

    Console.WriteLine("Символ?");
    string? simbol2 = Console.ReadLine();

    char sim = Convert.ToChar(simbol);

    for (int i = wigth1 / 2; i > 0; i--)
    {
        Console.Write(new String(' ', i));
        Console.WriteLine(new String(sim, wigth1 - i * 2));
    };
    for (int i = 0; i <= wigth1 / 2; i++)
    {
        Console.Write(new String(' ', i));
        Console.WriteLine(new String(sim, wigth1 - i * 2));
    };

    Console.WriteLine("");



    //стрела
    Console.WriteLine("Длина стрелы?");
    int.TryParse(Console.ReadLine(), out int length);

    Console.WriteLine("Символ?");
    string? simbol0 = Console.ReadLine();

    char s0 = Convert.ToChar(simbol);

    Console.WriteLine("");

    for (int i = 1; i < length; i++)
    {
        Console.Write(new String(' ', i));
        Console.WriteLine(new String(s0, i));
    }

    for (int i = length; i > 0; i--)
    {
        Console.Write(new String(' ', i));
        Console.WriteLine(new String(s0, i));
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

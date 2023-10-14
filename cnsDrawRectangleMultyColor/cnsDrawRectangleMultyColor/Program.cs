
using System;
using System.Drawing;

bool isContinue;

do
{
    Console.WriteLine("Длина?");
    int.TryParse(Console.ReadLine(), out int length);

    Console.WriteLine("Ширина?");
    int.TryParse(Console.ReadLine(), out int width);
    
    Console.WriteLine("Количество цветов?");
    int.TryParse(Console.ReadLine(), out int color_int);

/*    ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan,
    ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.DarkGray,
    ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow,
    ConsoleColor.White};*/

    List<int> colors = new List<int>();


    Console.WriteLine();
    Console.WriteLine("Цвета:");
    Console.WriteLine();

    foreach (var color_default in Enum.GetValues<ConsoleColor>())
        Console.WriteLine(color_default);

    Console.WriteLine();


    for (int i = 0; i < color_int; i++)
    {
        Console.WriteLine($"Введите цвет {i+1}");
        string c = Console.ReadLine();
        int.TryParse(c, out int color);
        colors.Add(color);
    }

    Console.WriteLine("Символ?");
    string? simbol = Console.ReadLine();

    char s = Convert.ToChar(simbol);

    string space = "";

    if (length > 0 && width > 0)
    {
        if (width / 2 <= length / 2)
        {
            int l = length;
            for (int j = 0; j < width / 2; j++)
            {
                Console.Write(space);
                Console.WriteLine(new String(s, l));
                if (l > 1)
                    l -= 2;
                space += " ";
            }
            space = "";
            for (int j = 0; j < width / 2; j++)
            {
                space += " ";
            }
            for (int j = width / 2; j > 0; j++)
            {
                Console.Write(space);
                Console.WriteLine(new String(s, l));
                l += 2;
                space.TrimEnd(' ');
                if (l == length) { break; }
            }
            
        }
        if (width / 2 > length / 2)
        {

        }

        /*        for (int j = 0; j < length - 2; j++)
                {
                    space += " ";
                }

                if (width > 1)
                {
                    Console.WriteLine(new String(s, length));
                    for (int i = 0; i < width - 2; i++)
                    {
                        if (length > 1)
                        {
                            Console.WriteLine(s + space + s);
                        }
                        else
                        {
                            Console.WriteLine(s);
                        }
                    }
                    Console.WriteLine(new String(s, length));
                }
                else
                {
                    Console.WriteLine(new String(s, length));
                }*/
    }

    


        Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);
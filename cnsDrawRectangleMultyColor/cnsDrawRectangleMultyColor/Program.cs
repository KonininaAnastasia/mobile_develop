
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

    //List<string> colors = new List<string>();
    string[] colors = new string[color_int];

    Console.WriteLine();
    Console.WriteLine("Цвета:");
    Console.WriteLine();

    foreach (var color_default in Enum.GetValues<ConsoleColor>())
        Console.WriteLine(color_default);

    Console.WriteLine();

    for (int i = 0; i < color_int; i++)
    {
        Console.WriteLine($"Введите цвет {i+1}");
        colors[i] = Console.ReadLine();
        //string c = Console.ReadLine();
        //colors.Add(c);
    }

    Console.WriteLine(String.Join(' ', colors));

    Console.WriteLine("Символ?");
    string? simbol = Console.ReadLine();

    char s = Convert.ToChar(simbol);

    int max_ount_color = width <= length ? width / 2 : length / 2; // для повтора цветов

    ConsoleColor color;

    if (length > 0 && width > 0)
    {
        if (width / 2 <= length / 2)
        {
            int colorIndex = 0;
            int l = length;
            for (int j = 0; j < width / 2; j++)
            {

                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[colorIndex]);

                Console.Write(new String(s, j));

                if (j != 0)
                    colorIndex = (colorIndex + 1) % colors.Length;
                //Console.ResetColor();

                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[colorIndex]);

                Console.Write(new String(s, l));

                //Console.ResetColor();
                if (j != 0 && colorIndex != 0)
                    colorIndex = (colorIndex - 1) % colors.Length;

                if (colorIndex == 0)
                    colorIndex = 2;

                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[colorIndex]);

                //Console.ResetColor();

                Console.WriteLine(new String(s, j));

                if (l > 1)
                    l -= 2;

                if (j != 0)
                    colorIndex = (colorIndex + 1) % colors.Length;

            }
            for (int j = width / 2; j >= 0; j--)
            {

                //if (j < color_int)
                //{
                //    Enum.TryParse(colors[j], true, out color);
                //    Console.ForegroundColor = color;
                //}

                Console.Write(new String(s, j));
                Console.Write(new String(s, l));
                Console.WriteLine(new String(s, j));

                l += 2;

                if (l == length) { break; }

                Console.ResetColor();

            }

        }
        if (width / 2 > length / 2)
        {

        }

    }
    Console.ResetColor();

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);
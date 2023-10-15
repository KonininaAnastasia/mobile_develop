
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
    }

    Console.WriteLine(String.Join(' ', colors));

    Console.WriteLine("Символ?");
    string? simbol = Console.ReadLine();

    Console.WriteLine();

    char s = Convert.ToChar(simbol);

    int max_сount = width <= length ? width / 2 : length / 2; // количество прямоугольников и цветов

    int origRow = Console.CursorTop;
    int origCol = Console.CursorLeft;

/*    int[,] cursor = new int[length, width]; // место, где стоит курсор

    int x = 0, y = 0; // сначала курсор в нуле

    int top = cursor[x, 0];
    int left = cursor[0, y];
    int right = cursor[length - 1, y];
    int bottom = cursor[x, width - 1];
    int l = length;
    int w = width;*/

    int colorIndex = 0;

    static void DrawRectangle(int x, int y, int length_, int width_, char s)//, int colorIndex, string[] colors)
    {
        for (int i = 0; i < width_; i++)
        {
            for (int j = 0; j < length_; j++)
            {
                // Проверяем, является ли текущая позиция границей прямоугольника
                if (i == 0 || i == width_ - 1 || j == 0 || j == length_ - 1)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(s);
                }

                if (i == 1 || i == width_ - 2 || j == 1 || j == length_ - 2)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(s);
                }
            }
        }
    }

    for (int i = 0; i < max_сount; i++)
    {

        int x = origCol + (i * 2); int y = origRow + (i * 2); // координата, из которой строится прямоугольник

        int length1 = length - (i * 4);
        int width1 = width - (i * 4); // координата, которой заканчивается прямоугольник

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[colorIndex]);

        DrawRectangle(x, y, length1, width1, s);//, 0, colors);

        colorIndex = (colorIndex + 1) % colors.Length;

    }


    Console.SetCursorPosition(0, origRow + width + 1);
    Console.ResetColor();


    /*    for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {




                x = i; y = j;

                if (cursor[i, j] == cursor[x, 0])
                {
                    top = cursor[i, j];
                }

                if (cursor[i, j] == cursor[0, y])
                {
                    left = cursor[i, j];
                }

                if (cursor[i, j] == cursor[length - 1, y])
                {
                    right = cursor[i, j];
                }

                if (cursor[i, j] == cursor[x, width - 1])
                {
                    bottom = cursor[i, j];
                }


                if (j == width - 1 || i == length - 1 || j == 0 || i == 0)
                {
                    if (cursor[i, j] == top)
                    {
                        Console.Write(new String(s, l));
                    }

                    if (cursor[i, j] == left)
                    {
                        Console.WriteLine(new String(s, w));
                    }

                    if (cursor[i, j] == right)
                    {
                        Console.WriteLine(new String(s, w));
                    }

                    if (cursor[i, j] == bottom)
                    {
                        Console.Write(new String(s, l));
                    }

                    l -= 2;
                    w -= 2;
                    cursor[i, j] = cursor[i + 1, j + 1];
                }
            }
        }*/

    /*   if (length > 0 && width > 0)
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
       Console.ResetColor();*/



    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);
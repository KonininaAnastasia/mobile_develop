

bool isContinue;

do
{
    Console.WriteLine("Длина?");
    int.TryParse(Console.ReadLine(), out int length);

    Console.WriteLine("Ширина?");
    int.TryParse(Console.ReadLine(), out int width);

    Console.WriteLine("Символ?");
    string? simbol = Console.ReadLine();

    char s = Convert.ToChar(simbol);

    Console.WriteLine("Направление? [>/<] ->");

    int max_сount = width <= length ? width / 2 : length / 2; // количество прямоугольников и цветов

    int origRow = Console.CursorTop;
    int origCol = Console.CursorLeft;

    static void DrawRectangle(int x, int y, int length_, int width_, char s)
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
            }
        }
    }

    for (int i = 0; i < max_сount; i++)
    {

        int x = origCol + i; int y = origRow + i; // координата, из которой строится прямоугольник

        int length1 = length - (i * 2);
        int width1 = width - (i * 2); // координата, которой заканчивается прямоугольник

        DrawRectangle(x, y, length1, width1, s);

    }


    Console.SetCursorPosition(0, origRow + width + 1);
    Console.ResetColor();

    /*    string space1 = "";

        for (int j = 0; j < length - 1; j++)
        {
            space1 += " ";
        }

        string space2 = "";
        for (int j = 1; j < length - 1; j++)
        {
            space2 += " ";
        }

        string space3 = " ";

        if (isPaint = Console.ReadLine() == ">")
        {
            Console.WriteLine(new String(s, length));
            Console.WriteLine(space1 + s);

            for (int i = 2; i < wigth / 2 - 1; i++)
            {

                if (i % 2 == 0) //если змея ползет горисонтально в этой строке (верхняя половина)
                {
                    if (i != 2)
                        Console.Write(new String(' ', i));

                    for (int j = 0; j < length - Math.Pow(2, i - 1); j++) //длина
                        Console.Write(s);
                    Console.WriteLine(space3 + s);
                    space3 += "  ";

                    Console.WriteLine(s + space2 + s); //ширина
                }
            }
            //Console.WriteLine("закончился цикл");

            if (wigth > 5)
            {
                Console.Write(s + " ");
                Console.Write(new String(s, length - 6));
                Console.Write(" " + s + " " + s);

                Console.WriteLine();
            }
            else if (wigth <= 5 && wigth > 3)
            {
                Console.Write(new String(s, length - 2));
                Console.Write(" " + s);
                Console.WriteLine();
            }

            for (int i = wigth / 2 - 2; i >= 1; i--)
            {
                if (i % 2 == 1) //если змея ползет горисонтально в этой строкем (нижняя половина)
                {
                    Console.WriteLine(space2 + s);

                    Console.Write(new String(' ', i));
                    for (int j = 0; j < length - Math.Pow(2, i); j++)
                        Console.Write(s);
                    Console.WriteLine(space3 + s);
                    space3 += " ";

                }

            }
            if (wigth > 3)
            {
                Console.Write(s);
                Console.Write(new String(' ', length - 2));
                Console.WriteLine(s);
                Console.WriteLine(new String(s, length));
            }
            else
                Console.WriteLine(new String(s, length));


        }
        else
        {
            for (int i = 0; i < wigth; i++)
            {
                Console.WriteLine(new String(s, length));
            }
        }*/

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);

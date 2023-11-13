bool isContinue;

Random rnd = new();

do
{
    const int bomba = 5;

    Console.WriteLine("Введите длину поля (по умолчанию 9)");
    int.TryParse(Console.ReadLine(), out int height);
    if (height < 2) height = 9;

    Console.WriteLine("Введите ширина поля (по умолчанию 9)");
    int.TryParse(Console.ReadLine(), out int width);
    if (width < 2) width = 9;

    Console.WriteLine("Количество случайно расставленных мин на поле (по умолчанию = 10)");
    int.TryParse(Console.ReadLine(), out int count_bombs);
    if (count_bombs < 2) count_bombs = 10;

    Console.WriteLine("Хотите ввести мины с точными координатами? [Y/N] ->");
    bool my_bombs = Console.ReadLine()?.ToUpper() == "Y";

    int[,] matrix = new int[height, width];

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i, j] = 0;
        }
    }

    if (my_bombs)
    {
        for (int i = 0; i < count_bombs; i++)
        {
            Console.WriteLine("Введите x, y координаты");
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);

            matrix[x - 1, y - 1] = bomba;
        }
    }
    else
    {
        for (int i = 0; i < count_bombs; i++)
        {
            int x = rnd.Next(0, height - 1);
            int y = rnd.Next(0, width - 1);

            matrix[x, y] = bomba;
        }
    }

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = -1; k < 2; k++)
            {
                for (int l = -1; l < 2; l++)
                {
                    if (i + k > -1 && j + l > -1 && i + k < height && j + l < width)
                    {
                        if (matrix[i, j] == bomba && matrix[i + k, j + l] != bomba)
                        {
                            matrix[i + k, j + l] += 1;
                        }
                    }

                }
            }
        }
    }

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (matrix[i, j] == bomba) { Console.Write('*'); } else { Console.Write($"{matrix[i, j]}"); }
        }
        Console.WriteLine();
    }

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);

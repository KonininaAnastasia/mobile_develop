﻿
bool isContinue;
bool isPaint;

do
{
    Console.WriteLine("Длина?");
    int.TryParse(Console.ReadLine(), out int length);

    Console.WriteLine("Ширина?");
    int.TryParse(Console.ReadLine(), out int width);

    string space = "";
    if (length > 0 && width > 0)
    {

        for (int j = 0; j < length - 2; j++)
        {
            space += " ";
        }

        if (width > 1)
        {
            Console.WriteLine(new String('*', length));
            for (int i = 0; i < width - 2; i++)
            {
                if (length > 1)
                {
                    Console.WriteLine('*' + space + '*');
                }
                else
                {
                    Console.WriteLine('*');
                }
            }
            Console.WriteLine(new String('*', length));
        } else
        {
            Console.WriteLine(new String('*', length));
        }

        Console.WriteLine("Закрасить? [Y/N] ->");
        isPaint = Console.ReadLine()?.ToUpper() == "Y";

        if (isPaint)
        {
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(new String('*', length));
            }
        }
    } else
    {
        Console.WriteLine("Введите длину > 0 и ширину > 0");
    }

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);

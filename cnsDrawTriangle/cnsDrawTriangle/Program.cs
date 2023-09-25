
Console.WriteLine("Сторона треугольника =");
int.TryParse(Console.ReadLine(), out int a);

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < i+1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}



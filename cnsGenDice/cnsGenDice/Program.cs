
bool isContinue;

Random rnd = new();

do
{
    Console.WriteLine("Введите количество кубиков (от 1 до 10)");
    int count_cubes = 0;
    while (count_cubes < 1 || count_cubes > 10) 
    {
        int.TryParse(Console.ReadLine(), out count_cubes); 
    }


    Console.WriteLine("Введите количество граней у кубика (не меньше 1; умолчанию 6)");
    int.TryParse(Console.ReadLine(), out int count_edge);
    if (count_edge < 1) { count_edge = 6; }


    Console.WriteLine("Введите значения на гранях кубика (не меньше 1; по умолчанию(1, 2, 3, 4, 5, 6)");

    List<int> values = new List<int>();

    for (int i = 0; i < count_edge; i++)
    {
        Console.WriteLine($"Введите значение грани {i + 1}");
        int.TryParse(Console.ReadLine(), out int value);
        if (value < 1)
        {
            value = rnd.Next(1,6);
            Console.WriteLine(value);
        }
        values.Add(value);
    }
    for (int i = 0; i < count_cubes; i++)
    {
        int rnd_index = rnd.Next(0, values.Count);
        Console.Write(values[rnd_index]);
        Console.Write(" ");
    }

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);
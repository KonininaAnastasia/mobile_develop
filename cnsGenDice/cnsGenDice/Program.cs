
Console.WriteLine("Количество кубиков (от 1 до 10)");
int count_cubes = 0;
while (count_cubes < 1 || count_cubes > 10) { int.TryParse(Console.ReadLine(), out count_cubes); }


Console.WriteLine("Количество граней у кубика (не меньше 1; умолчанию 6)");
int count_edge;
int.TryParse(Console.ReadLine(), out count_edge);
if (count_edge < 1) { count_edge = 6; }


Console.WriteLine("Значения на гранях кубика (не меньше 1; по умолчанию(1, 2, 3, ...)");

List<int> values = new List<int>();

for (int i = 0; i < count_edge; i++)
{
    Console.WriteLine($"Введите значение грани {i + 1}");
    int.TryParse(Console.ReadLine(), out int value);
    if (value < 1)
    {
        value = i + 1;
        Console.WriteLine(value);
    }
    values.Add(value);
}
for (int i = 0; i < count_cubes; i++)
{
    Random random = new Random();
    int randomIndex = random.Next(0, values.Count);
    Console.Write(values[randomIndex]);
    Console.Write(" ");
}
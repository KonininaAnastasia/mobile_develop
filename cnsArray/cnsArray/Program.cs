
// Массив (Array)

string[] cities = { "Тула", "Уфа", "Ялта", "Минск" };
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]); // первый элемент с конца 
Console.WriteLine(cities.Length);
Console.WriteLine($"Length = {cities.Length}");

//(1)
for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}
Console.WriteLine();

//(2)
foreach (var city in cities)
{
    Console.WriteLine(city);
}
Console.WriteLine();

//(3)
Console.WriteLine(String.Join('\n', cities));
Console.WriteLine();

Array.Resize<string>(ref cities, 10);
cities[5] = "Москва";
Console.WriteLine(String.Join(' ', cities)); 
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Имя?");
string? name = Console.ReadLine();
Console.WriteLine("Город?");
string? city = Console.ReadLine();

Console.WriteLine("Имя = " + name + ", город = " + city);
Console.WriteLine("Имя = {0}, город = {1}", name, city);
Console.WriteLine($"Имя = {name}, город = {city}");


Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Красный текст на белом фоне");
Console.ResetColor();
Console.WriteLine("Обычный текст");

foreach (var color in Enum.GetValues<ConsoleColor>())
{
    Console.WriteLine(color);
}

Console.WriteLine(new String('-', 80));
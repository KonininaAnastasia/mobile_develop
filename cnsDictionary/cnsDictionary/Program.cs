
// Словарь (Dictionary)
// Ключ (уникальный) - Значение

Dictionary<int, string> x = new();
x.Add(10, "Калуга");
x.Add(75, "Москва");
x.Add(25, "Тула");
Console.WriteLine(x[75]);
x[75] = "Воронеж"; // обновили номер
x[99] = "Курск"; // добавили номер

foreach (var item in x)
    Console.WriteLine($"key={item.Key}, value={item.Value}");

var arr = new string[] { "Москва", "Сочи", "Самара", "Тула", "Ялта", "Севастополь" };

var a1 = arr.Where(v => v.StartsWith("С") && v.Length > 4).OrderBy(v => v).ToArray();

Console.WriteLine(string.Join(" ", a1));

var a2 = arr.Select(v => $"{v} - {v.Length}").ToArray();
Console.WriteLine(string.Join(Environment.NewLine, a2));

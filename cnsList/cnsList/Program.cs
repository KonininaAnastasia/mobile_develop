
// Список (list)

// Обычный список

using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add(3);
arrayList.Add("Привет");
arrayList.Add(3.14);

// Обобщенный список

List<string> cities = new() { "Москва", "Минск", "Белград"};
cities.Add("Астана");
cities.AddRange(new string[] { "Севастополь", "Ялта" });
cities.RemoveAt(1);
Console.WriteLine(String.Join(' ', cities));
cities.Sort();
Console.WriteLine(String.Join(' ', cities));
cities.Reverse();
Console.WriteLine(String.Join(' ', cities));

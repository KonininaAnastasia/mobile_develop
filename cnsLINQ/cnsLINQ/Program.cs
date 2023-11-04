
//var arr = new int[] { 3, 2, 1, 7, 8, 9 };
var arr = Enumerable.Range(0, 10).ToArray();

Console.WriteLine(string.Join(" ", arr));

var myQuery =
    from v in arr
    where v > 5 && v < 9
    orderby v descending
    select $"_{v}_";

Console.WriteLine(string.Join(" ", myQuery));

var arrNames = new string[] {"Юра", "Миша", "Сергей", "максим", "Игорь"};

var myQuery2 =
    from v in arrNames
    where v.ToUpper().StartsWith("М")
    orderby v
    select v.ToUpper();

Console.WriteLine(string.Join(" ", myQuery2));
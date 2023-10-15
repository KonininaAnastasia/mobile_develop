
internal class Program
{
    private static void Main(string[] args)
    {
        Student x = new();
        x.AgeChange += X_AgeChange; // подписались на событие
        x.AgeChange2 += X_AgeChange2;
        x.Name = "Иван";
        x.Surname = "Иванович";
        x.Age = 19;
        Console.WriteLine(x.GetFullName());
        x.Age = 22;
        Console.WriteLine(x.GetFullName());

    }

    private static void X_AgeChange2(object? sender, int age)
    {
        Console.WriteLine($"Новый возраст, {age}");
    }

    private static void X_AgeChange(object? sender, EventArgs e)
    {
        if (sender is Student v) // если sender типа Student
            Console.WriteLine($"Изменился возраст, {v.Age}");
    }
}
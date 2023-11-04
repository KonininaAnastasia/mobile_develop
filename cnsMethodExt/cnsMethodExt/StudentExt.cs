static class StudentExt
{
    internal static void hello()
    {
        Console.WriteLine("hello");
    }

    internal static string get_FullName(this Student v)
    {
        return $"{v.Surname} {v.Name}";
    }
}
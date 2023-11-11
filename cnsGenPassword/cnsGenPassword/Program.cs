
using System;
using System.Text;

bool isContinue;
bool isPaint;

do
{
    Console.WriteLine("Введите количество паролей");
    int.TryParse(Console.ReadLine(), out int count_pass);

    Console.WriteLine("Введите количество символов в пароле");
    int.TryParse(Console.ReadLine(), out int count_simbol);

    Console.WriteLine("Хотите использовать доп символы? (кроме цифр, букв и спец символов) [Y/N] ->");
    bool answer = Console.ReadLine()?.ToUpper() == "Y";

    List<char> values = new List<char>();

    if (answer)
    {
        Console.WriteLine("Количество доп символов?");
        int.TryParse(Console.ReadLine(), out int count_dop_simbol);

        for (int i = 0; i < count_dop_simbol; i++)
        {
            Console.WriteLine($"Введите символ {i + 1}");
            char.TryParse(Console.ReadLine(), out char value);
            values.Add(value);
        }
    }
    for (int i = 0; i < count_pass; i++)
       Random(count_simbol, values);

    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";

} while (isContinue);

static string Random(int length, List<char> values)
{
    string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_-+=<>?";
    StringBuilder pass = new();
    Random rnd = new();

    chars += new string(values.ToArray());

    for (int i = 0; i < length - 1; i++)
    {
        int index = rnd.Next(chars.Length);
        pass.Append(chars[index]);
    }

    Console.WriteLine(pass.ToString());

    return pass.ToString();
}
internal class Student
{
    private int age;

    public event EventHandler AgeChange;

    public delegate void EventHandlerAge(object? sender, int age); //наш делигат
    public event EventHandlerAge AgeChange2;

    public string Name { get; internal set; }
    public string Surname { get; internal set; }
    public int Age
    {
        get // выдает это
        {
            return age;
        }

        internal set // получает и записывает сюда
        {
            if (value > 0)
                age = value;
            
            AgeChange?.Invoke(this, EventArgs.Empty); //без знака вопроса не работает, поэтому есть второй вариант
            AgeChange2?.Invoke(this, Age); //без знака вопроса не работает, поэтому есть второй вариант
            
            //if (AgeChange != null)
            //    AgeChange(this, EventArgs.Empty);
        }
    }

    public string GetFullName()
    {
        return $"{Name} {Surname} ({Age})";
    }
}
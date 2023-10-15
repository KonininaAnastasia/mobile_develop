
// Стек

using System.Collections;

// Обычный стек

Stack stack = new();
stack.Push("hello");
stack.Push(3.14);
Console.WriteLine($"Смотрим --> {stack.Peek()}"); //смотрим
Console.WriteLine(stack.Pop()); //извлекаем
Console.WriteLine(stack.Pop()); //нельзя написать больше двух cw, т к в стеке всего две переменные

// Обобщенный стек

Stack<int> numbers = new();
numbers.Push(1);

// HW
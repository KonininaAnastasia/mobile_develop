
// Очередь 

using System.Collections;

// Обычная очередь

Queue queue = new(); // хранятся любые объекты
queue.Enqueue(123);
queue.Enqueue(100500);
queue.Enqueue("Hello");
queue.Enqueue(3.14);
Console.WriteLine($"Смотрим --> {queue.Peek()}");  // просто посмотреть
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue()); // извлечь
}

// Обобщенная очередь

Queue<int> numbers = new(); // хранится конкретно int
numbers.Enqueue(1);
numbers.Enqueue(333);
numbers.Enqueue(256);

Console.WriteLine($"Sum = {numbers.Sum()}");

while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue()); // извлечь
}
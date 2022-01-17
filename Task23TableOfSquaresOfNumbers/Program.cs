// Показать таблицу квадратов чисел от 1 до N.

Console.Write("Enter number: ");
ulong finishNumber = ulong.Parse(Console.ReadLine());
for (ulong i = 1; i <= finishNumber; i++)
    Console.WriteLine($"{i}^2 = {i * i}");
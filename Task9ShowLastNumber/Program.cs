// Показать последнюю цифру трёхзначного числа.

int number = new Random().Next(100, 1000);
Console.WriteLine("Total number: " + number);

number = number % 10;
Console.Write("Last number: " + number);
// Написать программу вычисления значения функции y = f(a)
// f(x) = x^2+1

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
number = number * number + 1;
Console.WriteLine(number);
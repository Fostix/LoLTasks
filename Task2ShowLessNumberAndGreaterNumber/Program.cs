// Даны два числа. Показать большее и меньшее число.

Console.Write("Enter first number: ");
int firstN = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondN = int.Parse(Console.ReadLine());

if (firstN < secondN) Console.WriteLine($"first number: {firstN} less than second number: {secondN}.");
if (firstN > secondN) Console.WriteLine($"first number: {firstN} more than second number: {secondN}.");
if (firstN == secondN) Console.Write($"numbers equals: {firstN}, {secondN}.");
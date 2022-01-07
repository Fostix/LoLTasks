// Удалить вторую цифру трёхзначного числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int lastDigit = number % 10;
number = number / 100;
int firstDigit = number % 10;
firstDigit = firstDigit * 10;
firstDigit = firstDigit + lastDigit;
Console.WriteLine(firstDigit);

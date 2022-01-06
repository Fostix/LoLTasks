// Найти максимальное из трех чисел.

int firstNumber = new Random().Next(0, 10),
secondNumber = new Random().Next(0, 10),
thirdNumber = new Random().Next(0, 10),
max = firstNumber;

if (secondNumber > max)
{
    max = secondNumber;
}
if (thirdNumber > max)
{
    max = thirdNumber;
}
Console.WriteLine("first number: " + firstNumber  + "; second number: " + secondNumber + "; third number: " + thirdNumber + ".");
Console.WriteLine("max number of the tree numbers: " + max + ".");

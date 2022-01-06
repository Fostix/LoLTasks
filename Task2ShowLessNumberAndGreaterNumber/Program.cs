// Даны два числа. Показать большее и меньшее число.

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("First number: " + firstNumber + " greater than second number: " + secondNumber + ".");
}
else
{
    Console.WriteLine("First number: " + firstNumber + " less than second number: "  +secondNumber + ".");
}
// По двум заданным числам проверять является ли одно квадратом другого.

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

if (secondNumber == firstNumber * firstNumber)
{
    Console.Write("The second number: " + secondNumber + " is the square of the first: " + firstNumber + ".");
}
if (firstNumber == secondNumber * secondNumber)
{
    Console.Write("The first number" + firstNumber + " is the square of the second: " + secondNumber + ".");
}
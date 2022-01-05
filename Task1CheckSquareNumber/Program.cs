// По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

firstNumber = firstNumber * firstNumber;

if (firstNumber == secondNumber)
{
    Console.WriteLine("the first number is the square of the second");
}
else
{
    Console.WriteLine("the first number is not the square of the second");
}
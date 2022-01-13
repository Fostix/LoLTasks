// Программа проверяет пятизначное число на палиндромом.

Console.Write("Enter five digit number: ");
int number = int.Parse(Console.ReadLine());

if (number < 100000 && number > 9999)
{
    int lastNumber = number % 10;
    int secondLastNumber = number / 10 % 10;
    int firstNumber = number / 10000 % 10;
    int secondNumber = number / 1000 % 10;
    if (firstNumber == lastNumber && secondLastNumber == secondNumber)
    {
        Console.WriteLine("Polindrome");
    }
    else
    {
        Console.WriteLine("Not polindrome");

    }
}
else
{
    Console.WriteLine("More than five digit or less");
}
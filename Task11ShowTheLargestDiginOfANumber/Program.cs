// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int number = new Random().Next(10, 100),
firstDigit = number % 10,
secondDigit = number / 10;
Console.WriteLine("Number: " + number + ".");

if (firstDigit > secondDigit)
{
    Console.Write("The first digit: " + firstDigit + " of the number is greater than: " + secondDigit + ".");
}
else if(firstDigit < secondDigit)
{
    Console.WriteLine("The second digit: " + secondDigit + " of the number is greater than: " + firstDigit + ".");
}
else
{
    Console.WriteLine("Are the equal first digit: " + firstDigit + " second digit: " + secondDigit + ".");
}
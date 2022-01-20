// Подсчитать сумму цифр в числе.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()),
sum = 0,
digit;

if (number < 0)
{
    number = number * -1;
}

for (int i = 0; number > 0; i++)
{
    digit = number % 10;
    sum += digit;
    number /= 10;
}

    Console.WriteLine("The sum of the digits in a number: " + sum);
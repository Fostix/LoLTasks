// Определить количество цифр в числе.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()),
count = 0;

if (number < 0)
{
    number = number * -1;
}

while (number > 0)
{
    number /= 10;
    count++;
}

Console.WriteLine("The number of digits in a number: " + count);
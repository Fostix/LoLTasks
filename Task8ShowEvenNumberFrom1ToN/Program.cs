// Показать четные числа от 1 до N.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()),
N = 2;

if (number < 1)
{
    number = -number;
}

if (0 != number % 2)
{
    number--;
}

while (N < number)
{
    Console.Write(N + " ");
    N += 2;
}
if (number != 0)
{

    Console.Write(number);
}
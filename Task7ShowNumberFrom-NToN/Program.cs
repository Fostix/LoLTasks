// Показать числа от -N до N.

Console.Write("Enter negative number: ");
int number = int.Parse(Console.ReadLine());

int tempNumber;
if (number > 0)
{
    tempNumber = +number;
    number = -number;
    Console.Write(number + " ");
}
else
{
    tempNumber = -number;
    Console.Write(number + " ");
}

while (number != tempNumber)
{
    Console.Write($"{number = number + 1} ");
}
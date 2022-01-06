// Показать числа от -N до N.

Console.Write("Enter negative number: ");
int number = int.Parse(Console.ReadLine());

int tempNumber;
if (number > 0)
{
    tempNumber = +number;
    number = -number;
    Console.WriteLine("you entered a non-negative number, I will change the number to negative");
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